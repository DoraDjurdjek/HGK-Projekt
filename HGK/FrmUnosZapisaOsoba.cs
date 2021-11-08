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
    public partial class FrmUnosZapisaOsoba : Form
    {
        private Korisnik_table loggedUser = new Korisnik_table();
        private List<Strucna_sprema_table> listaStrucneSpreme = new List<Strucna_sprema_table>();
        private List<Naselje_table> listaNaselja = new List<Naselje_table>();
        private List<Agent_table2> listaAgenata = new List<Agent_table2>();
        

        public FrmUnosZapisaOsoba(Korisnik_table odabrani)
        {
            InitializeComponent();
            loggedUser = odabrani;
        }

        private void FrmUnosZapisaOsoba_Load(object sender, EventArgs e)
        {
            Osvjezi();
            PopuniComboBox();
            txtUnioKorisnik.Text = loggedUser.korime.ToString();
            txtUnioKorisnik.Enabled = false;

            dtpDatumUnosa.Value.Date.ToShortDateString();
            dtpDatumUnosa.Enabled = false;
        }

        private void Osvjezi()
        {
            dgvUnosOsoba.DataSource = null;
            using (var db = new PI20_037_DBEntities1())
            {
                dgvUnosOsoba.DataSource = db.Zapis_osobe_table.ToList();
                dgvUnosOsoba.Columns["Agent_table2"].Visible = false;
                dgvUnosOsoba.Columns["Korisnik_table"].Visible = false;
                dgvUnosOsoba.Columns["Naselje_table"].Visible = false;
                dgvUnosOsoba.Columns["Strucna_sprema_table"].Visible = false;
                dgvUnosOsoba.Columns[0].HeaderCell.Value = "ID";
                dgvUnosOsoba.Columns[1].HeaderCell.Value = "Ime";
                dgvUnosOsoba.Columns[2].HeaderCell.Value = "Prezime";
                dgvUnosOsoba.Columns[3].HeaderCell.Value = "Datum rođenja";
                dgvUnosOsoba.Columns[4].HeaderCell.Value = "Ulica";
                dgvUnosOsoba.Columns[5].HeaderCell.Value = "JMBG";
                dgvUnosOsoba.Columns[6].HeaderCell.Value = "OIB";
                dgvUnosOsoba.Columns[7].HeaderCell.Value = "Telefon";
                dgvUnosOsoba.Columns[8].HeaderCell.Value = "Email";
                dgvUnosOsoba.Columns[9].HeaderCell.Value = "Datum unosa";
                dgvUnosOsoba.Columns[10].HeaderCell.Value = "Unio korisnika";  //logirani korisnik
                dgvUnosOsoba.Columns[11].HeaderCell.Value = "Stručna sprema";
                dgvUnosOsoba.Columns[12].HeaderCell.Value = "Naselje ";
                dgvUnosOsoba.Columns[13].HeaderCell.Value = "Agent";
                dgvUnosOsoba.Columns[14].HeaderCell.Value = "Datum polaganja ispita";
            }
        }

        private void PopuniComboBox()
        {
            using (var db = new PI20_037_DBEntities1())
            {
                listaStrucneSpreme = db.Strucna_sprema_table.ToList();
                
                listaNaselja = db.Naselje_table.ToList();
            }
            cmbNaselje.DataSource = listaNaselja.ToList();
            cmbNaselje.DisplayMember = "naziv";
            cmbStrucnaSprema.DataSource = listaStrucneSpreme.ToList();
            cmbStrucnaSprema.DisplayMember = "naziv";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;

            DateTimePicker datumrodjenja = dtpDatumRodenja;
            DateTime stvarniDatumRodjenja = datumrodjenja.Value.Date;

            DateTimePicker datumunosa = dtpDatumUnosa;
            DateTime stvarniDatumUnosa = dtpDatumUnosa.Value.Date;
            string ulica = txtUlica.Text;
            string JMBG = txtJMBG.Text;
            string OIB = txtOib.Text;
            string telefon = txtTelefon.Text;
            string email = txtIEmail.Text;

            Strucna_sprema_table odabranaStrucna = cmbStrucnaSprema.SelectedItem as Strucna_sprema_table;
            Naselje_table odabranoNaselje = cmbNaselje.SelectedItem as Naselje_table;

            using (var db = new PI20_037_DBEntities1())
            {
                db.Strucna_sprema_table.Attach(odabranaStrucna);
                db.Naselje_table.Attach(odabranoNaselje);
                db.Korisnik_table.Attach(loggedUser);

                Zapis_osobe_table novaOsoba = new Zapis_osobe_table
                {
                    ime = ime,
                    prezime = prezime,
                    datumrodj = stvarniDatumRodjenja,
                    datumunosa = stvarniDatumUnosa,
                    ulica = ulica,
                    jmbg = JMBG,
                    oib = OIB,
                    telefon = telefon,
                    email = email,

                    Strucna_sprema_table = odabranaStrucna,
                    Naselje_table = odabranoNaselje,
                    Korisnik_table = loggedUser,
                };

                db.Zapis_osobe_table.Add(novaOsoba);
                db.SaveChanges();
            }
            Osvjezi();
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            Zapis_osobe_table odabranaOsoba = dgvUnosOsoba.CurrentRow.DataBoundItem as Zapis_osobe_table;
            FrmIzmijeniZapisUnosaOsobe frmIzmijeniOsobu = new FrmIzmijeniZapisUnosaOsobe(loggedUser, odabranaOsoba);
            frmIzmijeniOsobu.ShowDialog();
            Osvjezi();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPoloziIspit_Click_1(object sender, EventArgs e)
        {
            Zapis_osobe_table selektirana = dgvUnosOsoba.CurrentRow.DataBoundItem as Zapis_osobe_table;

            if (selektirana.agent_id != null)
            {
                MessageBox.Show("Već položio ispit! ");
            }
            else
            {
                Agent_table2 novokKreiraniAgent = new Agent_table2();

                using (var db = new PI20_037_DBEntities1())
                {
                    string regBroj = (listaAgenata.Count + 1).ToString();

                    Agent_table2 agent = new Agent_table2
                    {
                        registarskibroj = regBroj,
                        datumupisa = DateTime.Today,
                        datumpolaganjaispita = null,
                        napomena = null
                    };
                    
                    db.Agent_table2.Add(agent);
                    novokKreiraniAgent = agent;
                    db.SaveChanges();
                }

                FrmPoloziIspit poloziIspit = new FrmPoloziIspit(selektirana, novokKreiraniAgent);
                poloziIspit.ShowDialog();
            }
            Osvjezi();
        }
    }
}
