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
    public partial class DodajObrazovanjeForm : Form {

        int idOsobe, idObrazovanja;
        public DodajObrazovanjeForm(int idOsobe, int idObrazovanja, string ustanova, string zvanje, string datum) {
            this.idOsobe = idOsobe;
            this.idObrazovanja = idObrazovanja;
            InitializeComponent();

            if (idObrazovanja != -1) {
                tbImeUstanove.Text = ustanova;
                tbZvanje.Text = zvanje;
                datumSticanjaPicker.Value = DateTime.Parse(datum);
                label1.Text = "Izmena obrazovanja";
            }
            else {
                label1.Text = "Dodavanje obrazovanja";
            }

            label1.Left = (this.Width - label1.Left) / 2;
        }

        private void btnUpisi_Click(object sender, EventArgs e) {

            if (tbImeUstanove.Text.Length == 0) {
                MessageBox.Show("Morate uneti naziv ustanove!", "Paznja!");
                return;
            }

            if (tbZvanje.Text.Length == 0) {
                MessageBox.Show("Morate uneti steceno zvanje!", "Paznja!");
                return;
            }

            string poruka;
            if (idObrazovanja == -1)
                poruka = "Da li zelite da dodate obrazovanje?";
            else
                poruka = "Da li zelite da izmenite obrazovanje?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK) {
                if (idObrazovanja == -1) {
                    if (DTOManager.dodajObrazovanje(idOsobe, tbImeUstanove.Text, tbZvanje.Text, datumSticanjaPicker.Value)) {
                        MessageBox.Show("Uspesno ste dodali obrazovanje!", "Obavestenje");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Doslo je do greske! Obrazovanje nije dodato!", "Paznja!");
                    }
                }
                else {
                    if (DTOManager.izmeniObrazovanje(idObrazovanja, tbImeUstanove.Text, tbZvanje.Text, datumSticanjaPicker.Value)) {
                        MessageBox.Show("Uspesno ste izmenili obrazovanje!", "Obavestenje");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Doslo je do greske! Obrazovanje nije izmenjeno!", "Paznja!");
                    }
                }
            }
        }
    }
}
