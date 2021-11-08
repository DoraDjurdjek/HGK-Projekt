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
    public partial class FrmPoloziIspit : Form
    {
        private Zapis_osobe_table selektirani = new Zapis_osobe_table();
        private Agent_table2 noviAgent = new Agent_table2();
        

        public FrmPoloziIspit(Zapis_osobe_table odabrani, Agent_table2 novi)
        {
            InitializeComponent();
            selektirani = odabrani;
            noviAgent = novi;
        }

        //btnIzmijeni je zapravo Položio
        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            using (var db = new PI20_037_DBEntities1())
            {
                db.Zapis_osobe_table.Attach(selektirani);
                db.Agent_table2.Attach(noviAgent);
                
                selektirani.Agent_table2 = noviAgent;
                selektirani.datumpolaganjaispita = dtpPolozenIspit.Value;

                db.SaveChanges();
            }
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

