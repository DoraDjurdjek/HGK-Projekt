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
    public partial class FrmIzmijeniZaposlenika : Form
    {
        private List<Korisnik_table> listaKorisnika = new List<Korisnik_table>();

        private Korisnik_table korisnik_za_izmjenu = new Korisnik_table();

        public FrmIzmijeniZaposlenika()
        {
            InitializeComponent();
        }

        private void FrmIzmijeniZaposlenika_Load(object sender, EventArgs e)
        {
            using (var db = new PI20_037_DBEntities1())
            {
                listaKorisnika = db.Korisnik_table.ToList();
            }

            dgvZaposlenici.DataSource = listaKorisnika.ToList();
            dgvZaposlenici.Columns["Tip_korisnika_table"].Visible = false;
            dgvZaposlenici.Columns["Zapis_osobe_table"].Visible = false;

            dgvZaposlenici.Columns[0].HeaderCell.Value = "ID";
            dgvZaposlenici.Columns[1].HeaderCell.Value = "Ime";
            dgvZaposlenici.Columns[2].HeaderCell.Value = "Prezime";
            dgvZaposlenici.Columns[3].HeaderCell.Value = "Korisničko ime";
            dgvZaposlenici.Columns[5].HeaderCell.Value = "Datum rođenja";
            dgvZaposlenici.Columns[6].HeaderCell.Value = "Lozinka";
            dgvZaposlenici.Columns[7].HeaderCell.Value = "Kriptirana lozinka";
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            Korisnik_table selektiraniKorisnik = dgvZaposlenici.CurrentRow.DataBoundItem as Korisnik_table;

            txtIme.Text = selektiraniKorisnik.ime;
            txtPrezime.Text = selektiraniKorisnik.prezime;
            txtKorisnickoIme.Text = selektiraniKorisnik.korime;
            txtLozinka.Text = selektiraniKorisnik.lozinka;
            datumRodjenjaUnos.Value = selektiraniKorisnik.datumrodj;

            if (selektiraniKorisnik.tip_korisnika_id == 1)
            {
                cmbTipKorisnika.SelectedItem = "Administrator";
            }
            else
            {
                cmbTipKorisnika.SelectedItem = "Zaposlenik";
            }

            korisnik_za_izmjenu = selektiraniKorisnik;
        }

        private int PostaviTipZaposlenika()
        {
            int tip;
            if (cmbTipKorisnika.SelectedItem.ToString() == "Zaposlenik")
            {
                tip = 2;
            }
            else
            {
                tip = 1;
            }
            return tip;
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string korime = txtKorisnickoIme.Text;

            DateTimePicker datumrodjenja = datumRodjenjaUnos;
            DateTime stvarniDatum = datumrodjenja.Value.Date;

            string lozinka = txtLozinka.Text;
            string kriptirana = CreatePassword(12);
            int tip = PostaviTipZaposlenika();

            using (var db = new PI20_037_DBEntities1())
            {
                db.Korisnik_table.Attach(korisnik_za_izmjenu);

                korisnik_za_izmjenu.ime = ime;
                korisnik_za_izmjenu.prezime = prezime;
                korisnik_za_izmjenu.korime = korime;
                korisnik_za_izmjenu.datumrodj = stvarniDatum;
                korisnik_za_izmjenu.lozinka= lozinka;
                korisnik_za_izmjenu.kriptiranalozinka = CreatePassword(20);
                korisnik_za_izmjenu.tip_korisnika_id = tip;
                
                db.SaveChanges();
            }
            dgvZaposlenici.DataSource = OsvjeziTablicu();
        }

        private string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!=?*_/";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Korisnik_table odabraniKorisnik = dgvZaposlenici.CurrentRow.DataBoundItem as Korisnik_table;
            using (var db = new PI20_037_DBEntities1())
            {
                db.Korisnik_table.Attach(odabraniKorisnik);
                db.Korisnik_table.Remove(odabraniKorisnik);
                db.SaveChanges();
            }

            dgvZaposlenici.DataSource = OsvjeziTablicu();
        }

        private List<Korisnik_table> OsvjeziTablicu()
        {
            using (var db = new PI20_037_DBEntities1())
            {
                listaKorisnika = db.Korisnik_table.ToList();
            }
            return listaKorisnika;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
