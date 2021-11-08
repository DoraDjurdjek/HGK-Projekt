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
    public partial class FrmStatistika : Form
    {
        private List<Agent_table2> listaAgenata = new List<Agent_table2>();
        private List<Zapis_osobe_table> listaOsoba = new List<Zapis_osobe_table>();
        private List<Naselje_table> listaNaselja = new List<Naselje_table>();
        private List<Zupanija_table> listaZupanija = new List<Zupanija_table>();
        private List<Strucna_sprema_table> listaStrucneSpreme = new List<Strucna_sprema_table>();


        public FrmStatistika()
        {
            InitializeComponent();
        }
        

        private void FrmStatistika_Load(object sender, EventArgs e)
        {
            using (var db = new PI20_037_DBEntities1())
            {
                listaAgenata = db.Agent_table2.ToList();
                listaNaselja = db.Naselje_table.ToList();
                listaZupanija = db.Zupanija_table.ToList();
                listaOsoba = db.Zapis_osobe_table.ToList();
                listaStrucneSpreme = db.Strucna_sprema_table.ToList();
            }
        }


        private void btnAgentiPoZupanijama_Click(object sender, EventArgs e)
        {
            string nazivZupanije = "";
            int brojac = 0;
            string rezultat = "";

            foreach (var zupanija in listaZupanija)
            {
                nazivZupanije = zupanija.naziv.ToString();

                foreach (var naselje in listaNaselja)
                {
                    if (naselje.zupanija_id == zupanija.id)
                    {
                        foreach (var osoba in listaOsoba)
                        {
                            if (osoba.naselje_id == naselje.id)
                            {
                                brojac = brojac + 1;
                            }
                        }
                    }
                }
                
                rezultat += IspisStatistike.IspisAgenataPoZupanijama(nazivZupanije, brojac);

                brojac = 0;
            }

            rtbStatiAgentipoZupanija.Text = rezultat;
        }

        private void btnAgentiPoStruci_Click(object sender, EventArgs e)
        {
            string naziv = "";
            int brojac = 0;
            string rezultat = "";

            foreach (var strucnaSprema in listaStrucneSpreme)
            {
                naziv = strucnaSprema.naziv;
                foreach (var osoba in listaOsoba)
                {
                    if (osoba.strucna_sprema_id == strucnaSprema.id)
                    {
                        brojac = brojac + 1;
                    }
                }
                rezultat += IspisStatistike.IspStrucneSpreme(naziv, brojac);
                brojac = 0;
            }

            rtbStrukeAgenata.Text = rezultat;
        }
    }
}
