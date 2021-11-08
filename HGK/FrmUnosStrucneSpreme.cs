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
    public partial class FrmUnosStrucneSpreme : Form
    {
        private List<Strucna_sprema_table> listaStrucneSpreme = new List<Strucna_sprema_table>();

        public FrmUnosStrucneSpreme()
        {
            InitializeComponent();
        }

        private void FrmUnosStrucneSpreme_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi() {
            dgvStrucneSpreme.DataSource = null;

            using (var db = new PI20_037_DBEntities1()) {
                listaStrucneSpreme = db.Strucna_sprema_table.ToList();
            }

            dgvStrucneSpreme.DataSource = listaStrucneSpreme.ToList();
            dgvStrucneSpreme.Columns["Zapis_osobe_table"].Visible = false;
            dgvStrucneSpreme.Columns[0].HeaderCell.Value = "ID";
            dgvStrucneSpreme.Columns[1].HeaderCell.Value = "Naziv";
            dgvStrucneSpreme.Columns[2].HeaderCell.Value = "Oznaka";
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            string nazivStrucneSpreme = txtNazivStrucneSpreme.Text;
            string oznakaStrucneSpreme = txtOznakaStrucneSpreme.Text;

            using (var db = new PI20_037_DBEntities1())
            {
                Strucna_sprema_table strucna = new Strucna_sprema_table
                {
                    naziv=nazivStrucneSpreme,
                    oznaka=oznakaStrucneSpreme
                };

                db.Strucna_sprema_table.Add(strucna);
                db.SaveChanges();
            }
            Osvjezi();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            Strucna_sprema_table odabranaSprema = dgvStrucneSpreme.CurrentRow.DataBoundItem as Strucna_sprema_table;

            using (var db = new PI20_037_DBEntities1()) {
                db.Strucna_sprema_table.Attach(odabranaSprema);
                db.Strucna_sprema_table.Remove(odabranaSprema);
                db.SaveChanges();
            }
            Osvjezi();
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            Strucna_sprema_table odabrana = dgvStrucneSpreme.CurrentRow.DataBoundItem as Strucna_sprema_table;
            FrmIzmijeniStrucnuSpremu frmIzmijeniStrucnuSpremu = new FrmIzmijeniStrucnuSpremu(odabrana);
            frmIzmijeniStrucnuSpremu.ShowDialog();
        }
    }
}
