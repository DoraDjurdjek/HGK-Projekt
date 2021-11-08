using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Statistika;

namespace HGK
{
    public partial class Login : Form
    {
        private List<Korisnik_table> listaKorisnika = new List<Korisnik_table>();

        private List<Tip_korisnika_table> tip_Korisnika_Tables = new List<Tip_korisnika_table>();

        public Login()
        {
            InitializeComponent();
        }
        

        private void Login_Load(object sender, EventArgs e)
        {
            using (var db = new PI20_037_DBEntities1())
            {
                listaKorisnika = db.Korisnik_table.ToList();
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string korime = txtUsername.Text;
            string lozinka = txtPassword.Text;


           if(listaKorisnika.Exists(x => x.korime==korime && x.lozinka == lozinka))
            {
                
               Korisnik_table logiraniKorisnik = listaKorisnika.Find(x => x.korime == korime);

               GlavniIzbornik glavniIzbornik = new GlavniIzbornik(logiraniKorisnik);      
               glavniIzbornik.Show();

            }
            else
            {
                MessageBox.Show("Nešto nije u redu!");
            }
        }
    }
}
