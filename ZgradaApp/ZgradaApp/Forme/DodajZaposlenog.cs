using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZgradaApp.Forme {
    public partial class DodajZaposlenog : Form {
        private int id;
        public DodajZaposlenog() {
            this.id = -1;
            InitializeComponent();
            upravnikComboBox.SelectedIndex = 1;

        }
        public DodajZaposlenog(int id, string jmbg, string brlk, string ime, string imer, string prezime, string mestoizdavanja, string adresa, string datum, bool upravnik) {
            this.id = id;
            InitializeComponent();
            tbMesto.Text = mestoizdavanja;
            tbJmbg.Text = jmbg;
            tbBrlk.Text = brlk;
            tbIme.Text = ime;
            imeRTextBox.Text = imer;
            tbPrezime.Text = prezime;
            tbAdresa.Text = adresa;
            datumRodjenjaPicker.Value = DateTime.Parse(datum);
            if (upravnik)
                upravnikComboBox.SelectedIndex = 0;
            else
                upravnikComboBox.SelectedIndex = 1;
        }

        private void DodajZaposlenog_Load(object sender, EventArgs e) {
            if (id == -1) {
                label1.Text = "Dodaj novi zaposlenog";

            }
            else {
                label1.Text = "Izmeni zaposlenog";
            }
            label1.Left = (this.Width - label1.Width) / 2;
        }

        private void button1_Click(object sender, EventArgs e) {

            if (tbJmbg.Text.Length == 0) {
                MessageBox.Show("Morate uneti JMBG zaposlenog!", "Paznja!");
                return;
            }

            if (tbBrlk.Text.Length == 0) {
                MessageBox.Show("Morate uneti broj licne karte zaposlenog!", "Paznja!");
                return;
            }

            if (tbIme.Text.Length == 0) {
                MessageBox.Show("Morate uneti ime zaposlenog!", "Paznja!");
                return;
            }

            if (imeRTextBox.Text.Length == 0) {
                MessageBox.Show("Morate uneti ime roditelja zaposlenog!", "Paznja!");
                return;
            }

            if (tbPrezime.Text.Length == 0) {
                MessageBox.Show("Morate uneti prezime zaposlenog!", "Paznja!");
                return;
            }

            if (tbMesto.Text.Length == 0) {
                MessageBox.Show("Morate uneti mesto izdavajne licne karte zaposlenog!", "Paznja!");
                return;
            }

            if (tbAdresa.Text.Length == 0) {
                MessageBox.Show("Morate uneti adresu zaposlenog!", "Paznja!");
                return;
            }





            string poruka;
            if (id == -1)
                poruka = "Da li zelite da dodate novog zaposlenog?";
            else
                poruka = "Da li zelite da izmenite zaposlenog?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK) {
                if (id == -1) {
                    if (DTOManager.dodajZaposlenog(Int64.Parse(tbJmbg.Text), Int32.Parse(tbBrlk.Text), tbIme.Text, imeRTextBox.Text, tbPrezime.Text, tbMesto.Text, tbAdresa.Text, datumRodjenjaPicker.Value, upravnikComboBox.SelectedIndex == 0 ? true : false)) {
                        MessageBox.Show("Uspesno ste dodali novog zaposlenog!", "Obavestenje");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Doslo je do greske! Zaposleni nije dodat!", "Paznja!");
                    }
                }
                else {
                    if (DTOManager.izmeniZaposlenog(id, tbJmbg.Text, tbBrlk.Text, tbIme.Text, imeRTextBox.Text, tbPrezime.Text, tbMesto.Text, tbAdresa.Text, datumRodjenjaPicker.Value, upravnikComboBox.SelectedIndex == 0 ? true : false)) {
                        MessageBox.Show("Uspesno ste izmenili zaposlenog!", "Obavestenje");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Doslo je do greske! Zaposleni nije izmenjen!", "Paznja!");
                    }
                }
            }
        }
    }
}
