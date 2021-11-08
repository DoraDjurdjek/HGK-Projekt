using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HGK
{
    public partial class FrmDeaktivirajUgovor : Form
    {
        private List<Agent_posrednika_table> listaUgovora = new List<Agent_posrednika_table>();
        private List<Zapis_poslovnog_subjekta_table> listaSubjekata = new List<Zapis_poslovnog_subjekta_table>();
        private List<Agent_table2> listaAgenata = new List<Agent_table2>();
        private List<Zapis_osobe_table> listaAgenataImena = new List<Zapis_osobe_table>();


        public FrmDeaktivirajUgovor()
        {
            InitializeComponent();
        }

        private void Osvjezi()
        {
            dgvUgovori.DataSource = null;
            using (var db = new PI20_037_DBEntities1())
            {
                listaUgovora = db.Agent_posrednika_table.ToList();
                dgvUgovori.DataSource = listaUgovora.ToList();
                UrediDataGridView();
            }
        }

        private void UrediDataGridView()
        {
            dgvUgovori.Columns["Agent_table2"].Visible = false;
            dgvUgovori.Columns["Zapis_poslovnog_subjekta_table"].Visible = false;

            dgvUgovori.Columns[0].HeaderCell.Value = "ID";
            dgvUgovori.Columns[1].HeaderCell.Value = "Datum unosa";
            dgvUgovori.Columns[2].HeaderCell.Value = "Ime agenta";
            dgvUgovori.Columns[3].HeaderCell.Value = "Registarski broj";
            dgvUgovori.Columns[4].HeaderCell.Value = "Aktivan ugovor";
            dgvUgovori.Columns[5].HeaderCell.Value = "Datum raskida";
            dgvUgovori.Columns[6].HeaderCell.Value = "Naziv poslovnog subjekta";
        }

        private void PopuniComboBox()
        {
            using (var db = new PI20_037_DBEntities1())
            {
                listaAgenata = db.Agent_table2.ToList();
                listaSubjekata = db.Zapis_poslovnog_subjekta_table.ToList();
                listaUgovora = db.Agent_posrednika_table.ToList();
                listaAgenataImena = db.Zapis_osobe_table.Where(x => x.agent_id != null).ToList();
            }
            cmbFilterAgent.DataSource = listaAgenataImena.ToList();
            cmbFilterAgent.DisplayMember = "prezime";

            cmbFilterBrUgovor.DataSource = listaUgovora.ToList();
            cmbFilterBrUgovor.DisplayMember = "registarskibroj";

            cmbFilterSubjekt.DataSource = listaSubjekata.ToList();
            cmbFilterSubjekt.DisplayMember = "naziv";
        }


        private void FrmDeaktivirajUgovor_Load(object sender, EventArgs e)
        {
            Osvjezi();
            PopuniComboBox();
        }

        private void btnFilterAgent_Click_1(object sender, EventArgs e)
        {
            Zapis_osobe_table zaposlenik = cmbFilterAgent.SelectedValue as Zapis_osobe_table;

            string registarskiBrojAgenta = zaposlenik.agent_id.ToString();

            dgvUgovori.DataSource = listaUgovora.Where(x => x.agent_id.ToString() == registarskiBrojAgenta).ToList();
            UrediDataGridView();
        }

        private void btnFilterBrojUgovora_Click(object sender, EventArgs e)
        {
            Agent_posrednika_table ugovor = cmbFilterBrUgovor.SelectedValue as Agent_posrednika_table;

            string brojUgovora = ugovor.registarskibroj.ToString();

            dgvUgovori.DataSource = listaUgovora.Where(x => x.registarskibroj == brojUgovora).ToList();
            UrediDataGridView();
        }

        private void btnFilterSubjekt_Click_1(object sender, EventArgs e)
        {
            Zapis_poslovnog_subjekta_table subjekt = cmbFilterSubjekt.SelectedValue as Zapis_poslovnog_subjekta_table;

            string naziv = subjekt.naziv.ToString();

            dgvUgovori.DataSource = listaUgovora.Where(x => x.poslovni_subjekt_id == subjekt.id).ToList();
            UrediDataGridView();
        }

        private void btnVrati_Click_1(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void btnDeaktiviraj_Click_1(object sender, EventArgs e)
        {
            Agent_posrednika_table ugovorZaDeaktivaciju = dgvUgovori.CurrentRow.DataBoundItem as Agent_posrednika_table;

            using (var db = new PI20_037_DBEntities1())
            {
                db.Agent_posrednika_table.Attach(ugovorZaDeaktivaciju);

                ugovorZaDeaktivaciju.UgovorAktivan = false;
                ugovorZaDeaktivaciju.DatumRaskidaUgovora = dtpRaskidaUgovora.Value;

                db.SaveChanges();
            }
            Osvjezi();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

