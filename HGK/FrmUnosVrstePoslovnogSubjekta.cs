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
    public partial class FrmUnosVrstePoslovnogSubjekta : Form
    {
        public List<Vrsta_poslovnog_subjekta_table> listaPoslovnihSubjekta = new List<Vrsta_poslovnog_subjekta_table>();

        public FrmUnosVrstePoslovnogSubjekta()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string naziv = txtNazivVrstePoslovnogSubjekta.Text;
            string oznak = txtOznaka.Text;

            using (var db = new PI20_037_DBEntities1())
            {
                Vrsta_poslovnog_subjekta_table vrsta_Poslovnog_Subjekta_Table = new Vrsta_poslovnog_subjekta_table()
                {
                    naziv = naziv,
                    Oznaka = oznak
                };

                db.Vrsta_poslovnog_subjekta_table.Add(vrsta_Poslovnog_Subjekta_Table);
                db.SaveChanges();
            }
            Osvjezi();
        }

        private void FrmUnosVrstePoslovnogSubjekta_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            dgvVrstaPoslovnogSubjekta.DataSource = null;

            using (var db = new PI20_037_DBEntities1())
            {
                listaPoslovnihSubjekta = db.Vrsta_poslovnog_subjekta_table.ToList();
            }
            dgvVrstaPoslovnogSubjekta.DataSource = listaPoslovnihSubjekta.ToList();
            dgvVrstaPoslovnogSubjekta.Columns["Zapis_poslovnog_subjekta_table"].Visible = false;

            dgvVrstaPoslovnogSubjekta.Columns[0].HeaderCell.Value = "ID";
            dgvVrstaPoslovnogSubjekta.Columns[1].HeaderCell.Value = "Naziv";
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            using (var db = new PI20_037_DBEntities1())
            {
                Vrsta_poslovnog_subjekta_table odabrani = dgvVrstaPoslovnogSubjekta.CurrentRow.DataBoundItem as Vrsta_poslovnog_subjekta_table;
                db.Vrsta_poslovnog_subjekta_table.Attach(odabrani);
                db.Vrsta_poslovnog_subjekta_table.Remove(odabrani);
                db.SaveChanges();
            }
            Osvjezi();
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            Vrsta_poslovnog_subjekta_table odabrani = dgvVrstaPoslovnogSubjekta.CurrentRow.DataBoundItem as Vrsta_poslovnog_subjekta_table;
            FrmIzmjeniVrstuPoslovnogSubjekta frmIzmjeniVrstuPoslovnogSubjekta = new FrmIzmjeniVrstuPoslovnogSubjekta(odabrani);
            frmIzmjeniVrstuPoslovnogSubjekta.ShowDialog();
            Osvjezi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
