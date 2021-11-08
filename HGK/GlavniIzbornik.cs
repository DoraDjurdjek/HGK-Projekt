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
    public partial class GlavniIzbornik : Form
    {
        private Korisnik_table LogiraniKorisnik;
       

        public GlavniIzbornik(Korisnik_table loggedUser){ 
            InitializeComponent();
           LogiraniKorisnik = loggedUser;
        }

      

        private void GlavniIzbornik_Load(object sender, EventArgs e)
        {
            if(LogiraniKorisnik.tip_korisnika_id == 2)
            {
                btnDodajZaposlenika.Visible = false;
                btnUnosNaselja.Visible = false;
                btnUnosStrucneSpreme.Visible = false;
                btnUnosZupanija.Visible = false;
                lblAdministratorskeOpcije.Visible = false;
                btnUnosVrstePoslovnogSubjekta.Visible = false;
            }
        }

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            FrmDodajZaposlenika frmDodajZaposlenika = new FrmDodajZaposlenika();
            frmDodajZaposlenika.ShowDialog();
        }
        
        private void btnUnosVrstePoslovnogSubjekta_Click(object sender, EventArgs e)
        {
            FrmUnosVrstePoslovnogSubjekta frmUnosVrstePoslovnogSubjekta = new FrmUnosVrstePoslovnogSubjekta();
            frmUnosVrstePoslovnogSubjekta.ShowDialog();
        
           
        }

        private void btnUnosStrucneSpreme_Click(object sender, EventArgs e)
        {
            FrmUnosStrucneSpreme frmUnosStrucneSpreme = new FrmUnosStrucneSpreme();
            frmUnosStrucneSpreme.ShowDialog();
        }

        private void btnUnosZupanija_Click(object sender, EventArgs e)
        {
            FrmUnosZupanija frmUnosZupanija = new FrmUnosZupanija();
            frmUnosZupanija.ShowDialog();
        }

        private void btnUnosNaselja_Click(object sender, EventArgs e)
        {
            FrmUnosNaselja unosNaselja = new FrmUnosNaselja();
            unosNaselja.ShowDialog();
        }

        private void btnUnosOsoba_Click(object sender, EventArgs e)
        {
            FrmUnosZapisaOsoba frmUnosZapisaOsoba = new FrmUnosZapisaOsoba(LogiraniKorisnik);
            frmUnosZapisaOsoba.ShowDialog();
        }

        private void btnZapisPoslovnogSubjekta_Click(object sender, EventArgs e)
        {
            FrmZapisPoslovnogSubjekta frmZapisPoslovnogSubjekta = new FrmZapisPoslovnogSubjekta();
            frmZapisPoslovnogSubjekta.ShowDialog();

        }

        private void btnDodjeliAgentaSubjektu_Click(object sender, EventArgs e)
        {
            FrmDodjeliAgentaSubjektu frmDodjeliAgentaSubjektu = new FrmDodjeliAgentaSubjektu();
            frmDodjeliAgentaSubjektu.ShowDialog();

        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            FrmStatistika frmStatistika = new FrmStatistika();
            frmStatistika.ShowDialog();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            LogiraniKorisnik = null;
            Close();
        }
    }
}
