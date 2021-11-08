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
    public partial class FrmIzmijeniZapisUnosaOsobe : Form
    {
        private Korisnik_table loggedUser = new Korisnik_table();
        private Zapis_osobe_table odabranaOsoba = new Zapis_osobe_table();

        private List<Strucna_sprema_table> listaStrucneSpreme = new List<Strucna_sprema_table>();
        private List<Naselje_table> listaNaselja = new List<Naselje_table>();
        private List<Agent_table2> listaAgenata = new List<Agent_table2>();

       

        public FrmIzmijeniZapisUnosaOsobe(Korisnik_table user, Zapis_osobe_table osoba)
        {
            InitializeComponent();
            loggedUser = user;
            odabranaOsoba = osoba;
        }

        private void FrmIzmijeniZapisUnosaOsobe_Load(object sender, EventArgs e)
        {
            PopuniComboBox();
            PopuniTxT();
        }
    
        private void PopuniTxT()
        {
            txtUnioKorisnik.Text = loggedUser.korime.ToString();
            txtUnioKorisnik.Enabled = false;

            txtIme.Text = odabranaOsoba.ime;
            txtPrezime.Text = odabranaOsoba.prezime;
            txtIEmail.Text = odabranaOsoba.email;
            txtJMBG.Text = odabranaOsoba.jmbg;
            txtOib.Text = odabranaOsoba.oib;
            txtTelefon.Text = odabranaOsoba.telefon;
            txtUlica.Text = odabranaOsoba.ulica;
            dtpDatumRodenja.Value = odabranaOsoba.datumrodj;
            dtpDatumUnosa.Value = odabranaOsoba.datumunosa;
            dtpDatumUnosa.Enabled = false;
        }

        private void PopuniComboBox()
        {
            using (var db = new PI20_037_DBEntities1())
            {
                listaStrucneSpreme = db.Strucna_sprema_table.ToList();

                listaNaselja = db.Naselje_table.ToList();

               //listaAgenata = db.Agent_table2.ToList();
            }
            cmbNaselje.DataSource = listaNaselja.ToList();

            cmbNaselje.SelectedItem = listaNaselja.Find(x => x.id == odabranaOsoba.naselje_id);
            cmbNaselje.DisplayMember = "naziv";

            cmbStrucnaSprema.DataSource = listaStrucneSpreme.ToList();
            cmbStrucnaSprema.SelectedItem = listaStrucneSpreme.Find(x => x.id == odabranaOsoba.strucna_sprema_id);
            cmbStrucnaSprema.DisplayMember = "naziv";
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            Naselje_table cmbNaseljeSelektiran = cmbNaselje.SelectedItem as Naselje_table;
            Strucna_sprema_table cmbStrucnaSeletiran = cmbStrucnaSprema.SelectedItem as Strucna_sprema_table;

            using (var db = new PI20_037_DBEntities1())
            {
                db.Zapis_osobe_table.Attach(odabranaOsoba);
                db.Korisnik_table.Attach(loggedUser);
                db.Naselje_table.Attach(cmbNaseljeSelektiran);
                db.Strucna_sprema_table.Attach(cmbStrucnaSeletiran);


                string ime = txtIme.Text;
                string prezime = txtPrezime.Text;

                DateTimePicker datumrodjenja = dtpDatumRodenja;
                DateTime stvarniDatumRodjenja = datumrodjenja.Value.Date;

                DateTimePicker datumunosa = dtpDatumUnosa;
                DateTime stvarniDatumUnosa = dtpDatumUnosa.Value.Date;

                string ulica = txtUlica.Text;
                string JMBG = txtJMBG.Text;
                string OIB = txtOib.Text;
                string telefon = txtTelefon.Text;
                string email = txtIEmail.Text;

               
                odabranaOsoba.ime = ime;
                odabranaOsoba.prezime = prezime;
                odabranaOsoba.oib = OIB;
                odabranaOsoba.jmbg = JMBG;
                odabranaOsoba.telefon = telefon;
                odabranaOsoba.email = email;
                odabranaOsoba.ulica = ulica;
                odabranaOsoba.datumrodj = stvarniDatumRodjenja;
                odabranaOsoba.datumunosa = odabranaOsoba.datumunosa;
                odabranaOsoba.Strucna_sprema_table = cmbStrucnaSeletiran;
                odabranaOsoba.Naselje_table = cmbNaseljeSelektiran;
                odabranaOsoba.Korisnik_table = loggedUser;

                db.SaveChanges();
            }
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
