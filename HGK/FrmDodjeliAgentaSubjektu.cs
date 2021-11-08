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
    public partial class FrmDodjeliAgentaSubjektu : Form
    {
        private List<Zapis_osobe_table> listaOsoba = new List<Zapis_osobe_table>();
        private List<Zapis_poslovnog_subjekta_table> listaSubjekata = new List<Zapis_poslovnog_subjekta_table>();
        private List<Agent_table2> listaAgenata = new List<Agent_table2>();

        public FrmDodjeliAgentaSubjektu()
        {
            InitializeComponent();
        }


        private void FrmDodjeliAgentaSubjektu_Load(object sender, EventArgs e)
        {
            Osvjezi();
            PopuniCombo();
            dtpUnosa.Value = DateTime.Today;
            dtpUnosa.Enabled = false;
        }

        private void PopuniCombo()
        {
            using (var db = new PI20_037_DBEntities1())
            {
                listaOsoba = db.Zapis_osobe_table.Where(x => x.agent_id != null).ToList();
                listaSubjekata = db.Zapis_poslovnog_subjekta_table.ToList();
                listaAgenata = db.Agent_table2.ToList();
            }

            cmbOsoba.DataSource = listaOsoba.ToList();
            cmbOsoba.DisplayMember = "prezime";

            cmbPoslovniSubjekt.DataSource = listaSubjekata.ToList();
            cmbPoslovniSubjekt.DisplayMember = "naziv";
        }

        private void Osvjezi()
        {
            dgvUgovori.DataSource = null;

            using (var db = new PI20_037_DBEntities1())
            {
                dgvUgovori.DataSource = db.Agent_posrednika_table.ToList();
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
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (var db = new PI20_037_DBEntities1())
            {
                string registarskiBroj = txtRegistarskiBroj.Text;
                Zapis_osobe_table odabranOsoba = cmbOsoba.SelectedItem as Zapis_osobe_table;

                Agent_table2 agent = listaAgenata.Find(x => x.id == odabranOsoba.agent_id);

                Zapis_poslovnog_subjekta_table poslovniSubjekt = cmbPoslovniSubjekt.SelectedItem as Zapis_poslovnog_subjekta_table;

                db.Zapis_poslovnog_subjekta_table.Attach(poslovniSubjekt);
                db.Agent_table2.Attach(agent);

                Agent_posrednika_table noviUgovor = new Agent_posrednika_table
                {
                    registarskibroj = registarskiBroj,
                    UgovorAktivan = true,

                    datumunosa = dtpUnosa.Value,
                    Agent_table2 = agent,
                    Zapis_poslovnog_subjekta_table = poslovniSubjekt
                };

                db.Agent_posrednika_table.Add(noviUgovor);
                db.SaveChanges();
            }
            Osvjezi();
        }

        private void btnDeaktiviraj_Click(object sender, EventArgs e)
        {
            FrmDeaktivirajUgovor frmDeaktivirajUgovor = new FrmDeaktivirajUgovor();
            frmDeaktivirajUgovor.ShowDialog();
            Osvjezi();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
