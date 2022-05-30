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
    public partial class DodavanjeObnavljanjaForm : Form {

        int idObnavljanja, idLicence;
        public DodavanjeObnavljanjaForm(int idlic, int idob, string datum) {
            this.idLicence = idlic;
            this.idObnavljanja = idob;
            InitializeComponent();

            if (idob != -1) {
                label1.Text = "Izmena obnavljanja";
                dateTimePicker1.Value = DateTime.Parse(datum);
            }
            else {
                label1.Text = "Dodavanje obnavljanja";
            }
            label1.Left = (this.Width - label1.Width) / 2;
        }

        private void button1_Click(object sender, EventArgs e) {
            string poruka;
            if (idObnavljanja == -1)
                poruka = "Da li zelite da dodate novo obnavljanje?";
            else
                poruka = "Da li zelite da izmenite obnavljanje?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK) {
                if (idObnavljanja == -1) {
                    if (DTOManager.dodajObnavljanje(idLicence, dateTimePicker1.Value)) {
                        MessageBox.Show("Uspesno ste dodali novo obnavljanje", "Obavestenje");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Doslo je do greske! Obnavljanje se nije dodalo!", "Obavestenje");
                    }
                }
                else {
                    if (DTOManager.izmeniObnavljanje(idObnavljanja, dateTimePicker1.Value)) {
                        MessageBox.Show("Uspesno ste izmenili obnavljanje", "Obavestenje");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Doslo je do greske! Obnavljanje se nije izmenilo!", "Obavestenje");

                    }
                }
            }
        }
    }
}
