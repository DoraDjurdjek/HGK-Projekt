using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace HGK
{
    public partial class FrmDodajZaposlenika : Form
    {
        private List<Korisnik_table> listaKorisnika = new List<Korisnik_table>();

        public FrmDodajZaposlenika()
        {
            InitializeComponent();
        }

        private void brnDodaj_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string korime = txtKorisnickoIme.Text;

            DateTimePicker datumrodjenja = datumRodjenjaUnos;
            DateTime stvarniDatum = datumrodjenja.Value.Date;

            string lozinka = txtLozinka.Text;
            string kriptirana = CreatePassword(12);
            int tip;
            if (cmbTipKorisnika.SelectedItem.ToString() == "Zaposlenik")
            {
                tip = 2;
            }
            else tip = 1;


            using (var db = new PI20_037_DBEntities1())
            {
                Korisnik_table korisnik_Table = new Korisnik_table
                {
                    ime = ime,
                    prezime = prezime,
                    korime = korime,
                    datumrodj = stvarniDatum,
                    lozinka = lozinka,
                    kriptiranalozinka = kriptirana,
                    tip_korisnika_id = tip
                };

                db.Korisnik_table.Add(korisnik_Table);
                db.SaveChanges();
            }
            Osvjezi();
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
            FrmIzmijeniZaposlenika frmIzmjeniZaposlenika = new FrmIzmijeniZaposlenika();
            frmIzmjeniZaposlenika.ShowDialog();
            Osvjezi();
        }

        private void FrmDodajZaposlenika_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            using (var db = new PI20_037_DBEntities1())
            {
                listaKorisnika = db.Korisnik_table.ToList();
            }

            dgvZaposlenici.DataSource = null;
            dgvZaposlenici.DataSource = listaKorisnika.ToList();
            dgvZaposlenici.Columns["Tip_korisnika_table"].Visible = false;
            dgvZaposlenici.Columns["Zapis_osobe_table"].Visible = false;

            dgvZaposlenici.Columns[0].HeaderCell.Value = "ID";
            dgvZaposlenici.Columns[1].HeaderCell.Value = "Ime";
            dgvZaposlenici.Columns[2].HeaderCell.Value = "Prezime";
            dgvZaposlenici.Columns[3].HeaderCell.Value = "Korisničko ime";
            dgvZaposlenici.Columns[4].HeaderCell.Value = "Datum rođenja";
            dgvZaposlenici.Columns[5].HeaderCell.Value = "Lozinka";
            dgvZaposlenici.Columns[6].HeaderCell.Value = "Kriptirana lozinka";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
