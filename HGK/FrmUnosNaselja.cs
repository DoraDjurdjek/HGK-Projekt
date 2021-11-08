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
    public partial class FrmUnosNaselja : Form
    {
        private List<Zupanija_table> listaZupanija = new List<Zupanija_table>();

        public FrmUnosNaselja()
        {
            InitializeComponent();
        }

        private void FrmUnosNaselja_Load(object sender, EventArgs e)
        {
            Osvjezi();
            PopuniComboBox();
        }

        private void PopuniComboBox()
        {
            using (var db = new PI20_037_DBEntities1())
            {
                listaZupanija = db.Zupanija_table.ToList();
            }

            cmbZupanije.DataSource = listaZupanija.ToList();
            cmbZupanije.DisplayMember = "naziv";
        }

        private void Osvjezi()
        {
            dgvNaselja.DataSource = null;
            using (var db = new PI20_037_DBEntities1())
            {
                dgvNaselja.DataSource = db.Naselje_table.ToList();

                dgvNaselja.Columns["Zupanija_table"].Visible = false;
                dgvNaselja.Columns["Zapis_osobe_table"].Visible = false;
                dgvNaselja.Columns["Zapis_poslovnog_subjekta_table"].Visible = false;

                dgvNaselja.Columns[0].HeaderCell.Value = "ID";
                dgvNaselja.Columns[1].HeaderCell.Value = "Naziv";
                dgvNaselja.Columns[2].HeaderCell.Value = "Matični broj";
                dgvNaselja.Columns[3].HeaderCell.Value = "Županija";
            }
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            using (var db = new PI20_037_DBEntities1())
            {
                string ime = txtNazivNaselja.Text;
                string maticniBroj = txtMaticniBrojNaselja.Text;
                Zupanija_table odabranaZupanija = cmbZupanije.SelectedItem as Zupanija_table;
               
                db.Zupanija_table.Attach(odabranaZupanija);
                
                Naselje_table naselje = new Naselje_table
                {
                    naziv = ime,
                    matbroj = maticniBroj,
                    
                    Zupanija_table = odabranaZupanija
                };

                db.Naselje_table.Add(naselje);
                db.SaveChanges();
            }
            Osvjezi();
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            Naselje_table odabranoNaselje = dgvNaselja.CurrentRow.DataBoundItem as Naselje_table;
            FrmIzmijeniNaselje izmijeniNaselje = new FrmIzmijeniNaselje(odabranoNaselje);
            izmijeniNaselje.ShowDialog();
            Osvjezi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Naselje_table odabranoNaselje = dgvNaselja.CurrentRow.DataBoundItem as Naselje_table;

            using (var db = new PI20_037_DBEntities1())
            {
                db.Naselje_table.Attach(odabranoNaselje);
                db.Naselje_table.Remove(odabranoNaselje);

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


