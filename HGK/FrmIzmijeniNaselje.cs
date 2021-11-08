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
    public partial class FrmIzmijeniNaselje : Form
    {
        private Naselje_table odabrano = new Naselje_table();

        private List<Zupanija_table> listaZupanija = new List<Zupanija_table>();

        public FrmIzmijeniNaselje(Naselje_table naselje )
        {
            InitializeComponent();
            odabrano = naselje;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmIzmijeniNaselje_Load(object sender, EventArgs e)
        {
            using (var db = new PI20_037_DBEntities1())
            {

                listaZupanija = db.Zupanija_table.ToList();

            }

            txtNazivNaselja.Text = odabrano.naziv;
            txtMaticniBrojNaselja.Text = odabrano.matbroj;

            //selketiranje combo boxa
            cmbZupanije.DataSource = listaZupanija.ToList();
            cmbZupanije.SelectedIndex = odabrano.zupanija_id-1;
            cmbZupanije.DisplayMember = "naziv";
  

          
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            
            using (var db = new PI20_037_DBEntities1())
            {
                db.Naselje_table.Attach(odabrano);
                string ime = txtNazivNaselja.Text;
                string maticniBroj = txtMaticniBrojNaselja.Text;

                Zupanija_table odabranaZupanija = cmbZupanije.SelectedItem as Zupanija_table;
                db.Zupanija_table.Attach(odabranaZupanija);

                odabrano.naziv = ime;
                odabrano.matbroj = maticniBroj;
                odabrano.Zupanija_table = odabranaZupanija;

                db.SaveChanges();


            }

            Close();
        }
    }
}
