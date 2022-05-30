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
    public partial class DodajUgovorForm : Form {

        int idZgrade, idUgovora;


        public DodajUgovorForm(int idZgrade) {
            this.idZgrade = idZgrade;
            idUgovora = -1;
            InitializeComponent();
        }

        public DodajUgovorForm(int idZgrade, int idUgovora, string sifra, string vazenje, string datum) {
            this.idZgrade = idZgrade;
            this.idUgovora = idUgovora;
            InitializeComponent();

            sifraUgovoraTxtBox.Text = sifra;
            periodVazenjaTxtBox.Text = vazenje;
            datumPocetkaPicker.Value = DateTime.Parse(datum);
        }

        private void DodajUgovorForm_Load(object sender, EventArgs e) {
            if (idUgovora == -1) {
                label1.Text = "Dodaj novi ugovor";
                datumPocetkaPicker.Value = DateTime.Now;
            }
            else {
                label1.Text = "Izmeni ugovor";
            }
            label1.Left = (this.Width - label1.Width) / 2;

        }

        private void sifraUgovoraTxtBox_TextChanged(object sender, EventArgs e) {
            if (!int.TryParse(sifraUgovoraTxtBox.Text, out int r)) {
                sifraUgovoraTxtBox.Text = "";
            }
        }

        private void periodVazenjaTxtBox_TextChanged(object sender, EventArgs e) {
            if (!int.TryParse(periodVazenjaTxtBox.Text, out int r)) {
                periodVazenjaTxtBox.Text = "";
            }
        }

        private void upisiBtn_Click(object sender, EventArgs e) {

            if (sifraUgovoraTxtBox.Text.Length == 0) {
                MessageBox.Show("Morate uneti sifru ugovora!", "Paznja!");
                return;
            }

            if (periodVazenjaTxtBox.Text.Length == 0) {
                MessageBox.Show("Morate uneti period vazenja ugovora!", "Paznja!");
                return;
            }


            string poruka;
            if (idUgovora == -1)
                poruka = "Da li zelite da dodate novi ugovor?";
            else
                poruka = "Da li zelite da izmenite ugovor?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK) {
                if (idUgovora == -1) {
                    if (DTOManager.dodajUgovor(idZgrade, sifraUgovoraTxtBox.Text, periodVazenjaTxtBox.Text, datumPocetkaPicker.Value)) {
                        MessageBox.Show("Uspesno ste dodali novi ugovor!", "Obavestenje");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Doslo je do greske! Ugovor nije dodat!", "Paznja!");
                    }
                }
                else {
                    if (DTOManager.izmeniUgovor(idUgovora, sifraUgovoraTxtBox.Text, periodVazenjaTxtBox.Text, datumPocetkaPicker.Value)) {
                        MessageBox.Show("Uspesno ste izmenili ugovor!", "Obavestenje");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Doslo je do greske! Ugovor nije izmenjen!", "Paznja!");
                    }
                }
            }


        }
    }
}
