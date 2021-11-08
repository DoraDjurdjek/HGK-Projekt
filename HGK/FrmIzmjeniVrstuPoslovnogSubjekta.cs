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
    public partial class FrmIzmjeniVrstuPoslovnogSubjekta : Form
    {
        Vrsta_poslovnog_subjekta_table selektirani=new Vrsta_poslovnog_subjekta_table();

        public FrmIzmjeniVrstuPoslovnogSubjekta(Vrsta_poslovnog_subjekta_table vrsta_Poslovnog_Subjekta_Table)
        {
            InitializeComponent();
            selektirani = vrsta_Poslovnog_Subjekta_Table;
        }

        private void FrmIzmjeniVrstuPoslovnogSubjekta_Load(object sender, EventArgs e)
        {
            txtNazivVrstePoslovnogSubjekta.Text = selektirani.naziv.ToString();
            txtOznaka.Text = selektirani.Oznaka.ToString();
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            using (var db = new PI20_037_DBEntities1())
            {
                db.Vrsta_poslovnog_subjekta_table.Attach(selektirani);
                selektirani.naziv = txtNazivVrstePoslovnogSubjekta.Text;
                selektirani.Oznaka = txtOznaka.Text;

                db.SaveChanges();
            }
            Close();
        }
    }
}
