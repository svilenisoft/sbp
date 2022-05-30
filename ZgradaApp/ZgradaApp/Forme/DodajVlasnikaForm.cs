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
    public partial class DodajVlasnikaForm : Form {

        int idOsobe;
        public DodajVlasnikaForm(int idOsobe, long jmbg, string ime, string imer, string prezime, string telefon, string adresa, string tip) {
            this.idOsobe = idOsobe;

            InitializeComponent();

            if (idOsobe != -1) {
                tbJMBG.Text = jmbg.ToString() ;
                tbIme.Text = ime;
                tbPrezime.Text = prezime;
                tbImeR.Text = imer;
                tbTelefon.Text = telefon;
                tbAdresa.Text = adresa;
                label6.Text = "Izmena osobe";
                switch (tip) {
                    case "CLAN SAVETA":
                        comboBox1.SelectedIndex = 0;
                        break;
                    case "BLAGAJNIK":
                        comboBox1.SelectedIndex = 2;
                        break;
                    case "PREDSEDNIK":
                        comboBox1.SelectedIndex = 1;
                        break;
                }
            }
            else {
                label6.Text = "Dodavanje osobe";
            }

            label6.Left = (this.Width - label6.Width) / 2;
        }

        private void btnSave_Click(object sender, EventArgs e) {

            if (tbJMBG.Text.Length == 0) {
                MessageBox.Show("Morate uneti ime osobe!", "Obavestenje");
                return;
            }

            if (tbIme.Text.Length == 0) {
                MessageBox.Show("Morate uneti ime osobe!", "Obavestenje");
                return;
            }

            if (tbImeR.Text.Length == 0) {
                MessageBox.Show("Morate uneti ime roditelja!", "Obavestenje");
                return;
            }

            if (tbPrezime.Text.Length == 0) {
                MessageBox.Show("Morate uneti prezime osobe!", "Obavestenje");
                return;
            }

            if (tbTelefon.Text.Length == 0) {
                MessageBox.Show("Morate uneti broj telefona osobe!", "Obavestenje");
                return;
            }

            if (tbAdresa.Text.Length == 0) {
                MessageBox.Show("Morate uneti adresu osobe!", "Obavestenje");
                return;
            }

            if (comboBox1.SelectedIndex == -1) {
                MessageBox.Show("Morate odabrati tip vlasnika", "Obavestenje");
                return;
            }

            string poruka;
            if (idOsobe == -1)
                poruka = "Da li zelite da dodate osobu?";
            else
                poruka = "Da li zelite da izmenite osobu?";

            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK) {
                if (idOsobe == -1) {
                    if (DTOManager.dodajOsobu(long.Parse(tbJMBG.Text), tbIme.Text, tbImeR.Text, tbPrezime.Text, tbTelefon.Text, tbAdresa.Text, comboBox1.SelectedIndex)) {
                        MessageBox.Show("Uspesno ste dodali osobu!", "Obavestenje");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Doslo je do greske! Osoba nije dodata!");
                    }
                }
                else {
                    if (DTOManager.izmeniOsobu(idOsobe, long.Parse(tbJMBG.Text), tbIme.Text, tbImeR.Text, tbPrezime.Text, tbTelefon.Text, tbAdresa.Text, comboBox1.SelectedIndex)) {
                        MessageBox.Show("Uspesno ste izmenili osobu!", "Obavestenje");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Doslo je do greske! Osoba nije izmenjen!");
                    }
                }
            }
        }

        private void tbTelefon_TextChanged(object sender, EventArgs e) {
            if (!long.TryParse(tbTelefon.Text.ToString(), out _)) {
                tbTelefon.Text = "";
            }
        }

        private void tbJMBG_TextChanged(object sender, EventArgs e) {
            if (!long.TryParse(tbJMBG.Text.ToString(), out _)) {
                tbJMBG.Text = "";
            }
        }
    }
}
