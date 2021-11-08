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
    
    public partial class FrmZapisPoslovnogSubjekta : Form
    {
        private List<Naselje_table> listaNaselja = new List<Naselje_table>();
        private List<Vrsta_poslovnog_subjekta_table> vrsta_Poslovnog_Subjekta = new List<Vrsta_poslovnog_subjekta_table>();

        public FrmZapisPoslovnogSubjekta()
        {
            InitializeComponent();
        }

        private void FrmZapisPoslovnogSubjekta_Load(object sender, EventArgs e)
        {
            Osvjezi();
            PopuniComboBox();
            dtpDatumUnosa.Value = DateTime.Today;
            dtpDatumUnosa.Enabled = false;
        }

        private void Osvjezi()
       {
            using (var db = new PI20_037_DBEntities1())
            {
                dgvPoslovniSubjekt.DataSource = null;
                dgvPoslovniSubjekt.DataSource = db.Zapis_poslovnog_subjekta_table.ToList();

                dgvPoslovniSubjekt.Columns["Naselje_table"].Visible = false;
                dgvPoslovniSubjekt.Columns["Vrsta_poslovnog_subjekta_table"].Visible = false;
                dgvPoslovniSubjekt.Columns["Agent_posrednika_table"].Visible = false;

                dgvPoslovniSubjekt.Columns[0].HeaderCell.Value = "ID";
                dgvPoslovniSubjekt.Columns[1].HeaderCell.Value = "Matični broj";
                dgvPoslovniSubjekt.Columns[2].HeaderCell.Value = "Naziv";
                dgvPoslovniSubjekt.Columns[3].HeaderCell.Value = "Telefon";
                dgvPoslovniSubjekt.Columns[4].HeaderCell.Value = "E-mail";
                dgvPoslovniSubjekt.Columns[5].HeaderCell.Value = "Datum unosa";
                dgvPoslovniSubjekt.Columns[6].HeaderCell.Value = "OIB";
                dgvPoslovniSubjekt.Columns[7].HeaderCell.Value = "Naselje";
                dgvPoslovniSubjekt.Columns[8].HeaderCell.Value = "Vrsta poslovnog subjekta";
            }
       }
        private void PopuniComboBox()
        {
            using (var db = new PI20_037_DBEntities1())
            {
                listaNaselja = db.Naselje_table.ToList();

                vrsta_Poslovnog_Subjekta = db.Vrsta_poslovnog_subjekta_table.ToList();
            }
            cmbNaselja.DataSource = listaNaselja.ToList();
            cmbNaselja.DisplayMember = "naziv";
            cmbVrstaPoslovni.DataSource = vrsta_Poslovnog_Subjekta.ToList();
            cmbVrstaPoslovni.DisplayMember = "oznaka";

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            string maticniBroj = txtMaticniBroj.Text;
            string naziv = txtNaziv.Text;
            string OIB = txtOib.Text;
            string telefon = txtTelefon.Text;
            string email = txtEmail.Text;


            using (var db = new PI20_037_DBEntities1())
            {
                Naselje_table cmbNaselje = cmbNaselja.SelectedItem as Naselje_table;
                Vrsta_poslovnog_subjekta_table cmbVrstaPoslovnog = cmbVrstaPoslovni.SelectedItem as Vrsta_poslovnog_subjekta_table;

                db.Naselje_table.Attach(cmbNaselje);
                db.Vrsta_poslovnog_subjekta_table.Attach(cmbVrstaPoslovnog);

                Zapis_poslovnog_subjekta_table noviSubjekt = new Zapis_poslovnog_subjekta_table
                {
                    matbroj = maticniBroj,
                    naziv = naziv,
                    oib = OIB,
                    telefon = telefon,
                    email = email,
                    datumunosa = dtpDatumUnosa.Value,

                    Naselje_table = cmbNaselje,
                    Vrsta_poslovnog_subjekta_table = cmbVrstaPoslovnog

                };

                db.Zapis_poslovnog_subjekta_table.Add(noviSubjekt);
                db.SaveChanges();
            }
            Osvjezi();
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            Zapis_poslovnog_subjekta_table selektiraniPoslovniObjekt = dgvPoslovniSubjekt.CurrentRow.DataBoundItem as Zapis_poslovnog_subjekta_table;
            FrmIzmijenaPoslovnogSubjekta izmjeniPoslovni = new FrmIzmijenaPoslovnogSubjekta(selektiraniPoslovniObjekt);
            izmjeniPoslovni.ShowDialog();

            Osvjezi();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Zapis_poslovnog_subjekta_table selektiraniPoslovniObjekt = dgvPoslovniSubjekt.CurrentRow.DataBoundItem as Zapis_poslovnog_subjekta_table;

            using (var db = new PI20_037_DBEntities1())
            {
                db.Zapis_poslovnog_subjekta_table.Attach(selektiraniPoslovniObjekt);
                db.Zapis_poslovnog_subjekta_table.Remove(selektiraniPoslovniObjekt);

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
