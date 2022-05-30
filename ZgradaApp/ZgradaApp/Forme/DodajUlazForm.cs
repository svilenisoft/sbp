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
    public partial class DodajUlazForm : Form {

        int idZgrade, idUlaza;

        public DodajUlazForm(int idZgrade) {
            this.idZgrade = idZgrade;

            InitializeComponent();

            label1.Text = "Dodavanje ulaza";
            label1.Left = (this.Width - label1.Width) / 2;
            vremeOtvaranjaPicker.Value = DateTime.Now;
            vremeZatvaranjaPicker.Value = DateTime.Now;
            idUlaza = -1;
        }

        public DodajUlazForm(int idZgrade, int idUlaza, string rbr, bool kamera, string vo, string vz) {
            this.idZgrade = idZgrade;
            this.idUlaza = idUlaza;

            InitializeComponent();

            label1.Text = "Izmena ulaza";
            label1.Left = (this.Width - label1.Width) / 2;
            rbrTextBox.Text = rbr;
            if (kamera)
                kameraComboBox.SelectedIndex = 0;
            else
                kameraComboBox.SelectedIndex = 1;
            vremeOtvaranjaPicker.Value = DateTime.Parse(vo);
            vremeZatvaranjaPicker.Value = DateTime.Parse(vz);
        }


        private void rbrTextBox_TextChanged(object sender, EventArgs e) {
            if (!int.TryParse(rbrTextBox.Text, out int r)) {
                rbrTextBox.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e) {

            if (rbrTextBox.Text.Length == 0) {
                MessageBox.Show("Morate uneti redni broj ulaza!", "Paznja!");
                return;
            }

            if (kameraComboBox.SelectedIndex == -1) {
                MessageBox.Show("Morate uneti informaciju o video nadzoru!", "Paznja!");
                return;
            }

            string poruka;
            if (idUlaza == -1)
                poruka = "Da li zelite da dodate novi ulaz?";
            else
                poruka = "Da li zelite da izmenite ulaz?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK) {
                if (idUlaza == -1) {
                    if (DTOManager.dodajUlaz(idZgrade, rbrTextBox.Text, kameraComboBox.SelectedItem.ToString(), vremeOtvaranjaPicker.Value, vremeZatvaranjaPicker.Value)) {
                        MessageBox.Show("Uspesno ste dodali novi ulaz!", "Obavestenje");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Doslo je do greske! Ulaz nije dodat!", "Paznja!");
                    }
                }
                else {
                    if (DTOManager.izmeniUlaz(idUlaza, rbrTextBox.Text, kameraComboBox.SelectedItem.ToString(), vremeOtvaranjaPicker.Value, vremeZatvaranjaPicker.Value)) {
                        MessageBox.Show("Uspesno ste izmenili ulaz!", "Obavestenje");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Doslo je do greske! Ulaz nije izmenjen!", "Paznja!");
                    }
                }
            }
        }
    }
}
