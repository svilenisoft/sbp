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
    public partial class DodajNivoForm : Form {

        int idZgrade, idNivoa, brNivoa;
        public DodajNivoForm(int idZgrade) {
            this.idZgrade = idZgrade;
            InitializeComponent();
            label1.Text = "Dodavanje nivoa";
            idNivoa = -1;
            tipComboBox.Enabled = true;
        }

        public DodajNivoForm(int idZgrade, int idNivoa, int brNivoa, string tipNivoa) {
            this.idZgrade = idZgrade;
            this.idNivoa = idNivoa;
            this.brNivoa = brNivoa;
            InitializeComponent();
            label1.Text = "Izmena nivoa";
            brNivoaTextBox.Text = brNivoa.ToString();
            switch (tipNivoa) {
                case "Stambeni nivo":
                    tipComboBox.SelectedIndex = 0;
                    break;
                case "Poslovni nivo":
                    tipComboBox.SelectedIndex = 1;
                    break;
                case "Garazni nivo":
                    tipComboBox.SelectedIndex = 2;
                    break;
            }
            tipComboBox.Enabled = false;

        }

        private void DodajNivoForm_Load(object sender, EventArgs e)
        {

        }

        private void brNivoaTextBox_TextChanged(object sender, EventArgs e) {
            if (brNivoaTextBox.Text.Equals("-"))
                return;
            if (!int.TryParse(brNivoaTextBox.Text, out int r)) {
                brNivoaTextBox.Text = "";
            }
        }


        private void upisBtn_Click(object sender, EventArgs e) {

            if (brNivoaTextBox.Text.Trim().Length == 0) {
                MessageBox.Show("Morate uneti broj nivoa!");
                return;
            }

            if (tipComboBox.SelectedIndex == -1) {
                MessageBox.Show("Morate odabrati tip nivoa!");
                return;
            }

            string poruka;
            if (idNivoa == -1)
                poruka = "Da li zelite da dodate novi nivo?";
            else
                poruka = "Da li zelite da izmenite nivo?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK) {

                if (idNivoa == -1) {
                    if (DTOManager.dodajNivo(idZgrade, brNivoaTextBox.Text, tipComboBox.SelectedItem.ToString())) {
                        MessageBox.Show("Uspesno ste dodali novi nivo!");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Doslo je do greske! Nivo nije upisan!");
                }
                else {
                    if (DTOManager.izmeniNivo(idNivoa, brNivoaTextBox.Text)) {
                        MessageBox.Show("Uspesno ste izmenili nivo!", "Uspeh");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Doslo je do greske! Nivo nije izmenjen!", "Greska");
                }

            }

        }
    }
}
