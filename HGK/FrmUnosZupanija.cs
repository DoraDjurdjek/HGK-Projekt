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
    public partial class FrmUnosZupanija : Form
    {
        private List<Zupanija_table> listaZupanija = new List<Zupanija_table>();

        public FrmUnosZupanija()
        {
            InitializeComponent();
        }

        private void FrmUnosZupanija_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            dgvZuapnije.DataSource = null;

            using (var db = new PI20_037_DBEntities1())
            {
                listaZupanija = db.Zupanija_table.ToList();
            }

            dgvZuapnije.DataSource = listaZupanija.ToList();
            dgvZuapnije.Columns["Naselje_table"].Visible = false;

            dgvZuapnije.Columns[0].HeaderCell.Value = "ID";
            dgvZuapnije.Columns[1].HeaderCell.Value = "Naziv županije";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string Naziv = txtZupanije.Text;

            using (var db = new PI20_037_DBEntities1())
            {
                Zupanija_table zupanija = new Zupanija_table
                {
                    naziv = Naziv,
                    
                };

                db.Zupanija_table.Add(zupanija);
                db.SaveChanges();
            }
            Osvjezi();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Zupanija_table odabrana = dgvZuapnije.CurrentRow.DataBoundItem as Zupanija_table;

            using (var db = new PI20_037_DBEntities1())
            {
                db.Zupanija_table.Attach(odabrana);
                db.Zupanija_table.Remove(odabrana);
                db.SaveChanges();
            }
            Osvjezi();
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            Zupanija_table odabrana = dgvZuapnije.CurrentRow.DataBoundItem as Zupanija_table;
            txtZupanijeIzmjena.Text = odabrana.naziv.ToString();
        }

        private void btnizmjeni_Click(object sender, EventArgs e)
        {
            Zupanija_table odabrana = dgvZuapnije.CurrentRow.DataBoundItem as Zupanija_table;

            using (var db = new PI20_037_DBEntities1())
            {
                db.Zupanija_table.Attach(odabrana);
                odabrana.naziv = txtZupanijeIzmjena.Text;
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
