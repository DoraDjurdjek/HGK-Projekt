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
    public partial class FrmIzmijeniStrucnuSpremu : Form
    {
        private Strucna_sprema_table odabrana = new Strucna_sprema_table();

        public FrmIzmijeniStrucnuSpremu(Strucna_sprema_table selektirana)
        {
            odabrana = selektirana;
            InitializeComponent();
        }

        private void FrmIzmijeniStrucnuSpremu_Load(object sender, EventArgs e)
        {
            txtNazivStrucneSpreme.Text = odabrana.naziv.ToString();
            txtOznakaStrucneSpreme.Text = odabrana.oznaka.ToString();
            Osvjezi();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new PI20_037_DBEntities1())
            {
                db.Strucna_sprema_table.Attach(odabrana);
                odabrana.naziv = txtNazivStrucneSpreme.Text;
                odabrana.oznaka = txtOznakaStrucneSpreme.Text;

                db.SaveChanges();
            }
            Osvjezi();
        }

        private void Osvjezi()
        {
            dgvStrucneSpreme.DataSource = null;
            using (var db = new PI20_037_DBEntities1())
            {
                dgvStrucneSpreme.DataSource = db.Strucna_sprema_table.ToList();
                dgvStrucneSpreme.Columns["Zapis_osobe_table"].Visible = false;

                dgvStrucneSpreme.Columns[0].HeaderCell.Value = "ID";
                dgvStrucneSpreme.Columns[1].HeaderCell.Value = "Naziv";
                dgvStrucneSpreme.Columns[2].HeaderCell.Value = "Oznaka";
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
