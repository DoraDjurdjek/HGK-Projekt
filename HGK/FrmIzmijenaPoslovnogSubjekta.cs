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
    public partial class FrmIzmijenaPoslovnogSubjekta : Form
    {
        private List<Naselje_table> listaNaselja = new List<Naselje_table>();
        private List<Vrsta_poslovnog_subjekta_table> vrsta_Poslovnog_Subjekta = new List<Vrsta_poslovnog_subjekta_table>();

        private Zapis_poslovnog_subjekta_table odabrani = new Zapis_poslovnog_subjekta_table();

        public FrmIzmijenaPoslovnogSubjekta(Zapis_poslovnog_subjekta_table selektirani)
        {
            InitializeComponent();
            odabrani = selektirani;
        }

        private void FrmIzmijenaPoslovnogSubjekta_Load(object sender, EventArgs e)
        {
            PopuniComboBox();

            dtpDatumUnosa.Value = odabrani.datumunosa;
            dtpDatumUnosa.Enabled = false;

            PopuniTxt();
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

        private void PopuniTxt()
        {
            txtMaticniBroj.Text = odabrani.matbroj;
            txtNaziv.Text = odabrani.naziv;
            txtEmail.Text = odabrani.email;
            txtOib.Text = odabrani.oib;
            txtTelefon.Text = odabrani.telefon;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
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
                db.Zapis_poslovnog_subjekta_table.Attach(odabrani);

                odabrani.matbroj = maticniBroj;
                odabrani.naziv = naziv;
                odabrani.oib = OIB;
                odabrani.telefon = telefon;
                odabrani.email = email;
                odabrani.Naselje_table = cmbNaselje;
                odabrani.Vrsta_poslovnog_subjekta_table = cmbVrstaPoslovnog;

                db.SaveChanges();
            }
            Close();
        }
    }
}
