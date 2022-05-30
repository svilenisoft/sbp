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
    public partial class DodajStanaraForm : Form {
        int idStana, idStanara;
        string naziv;
        public DodajStanaraForm(int idStana, int idStanara, string naziv) {
            this.idStana = idStana;
            this.idStanara = idStanara;
            this.naziv = naziv;
            InitializeComponent();
        }

        private void DodajStanaraForm_Load(object sender, EventArgs e) {
            if (naziv == null) {
                label1.Text = "Dodavanje stanara";
            }
            else {
                label1.Text = "Izmena stanara";
                imeTextBox.Text = naziv;
            }

            label1.Left = (this.Width - label1.Width) / 2;
        }

        private void upisiBtn_Click(object sender, EventArgs e) {

            if (imeTextBox.Text.Length == 0) {
                MessageBox.Show("Morate uneti ime stanara!", "Obavestenje");
                return;
            }

            string poruka;
            if (naziv == null)
                poruka = "Da li zelite da dodate stanara?";
            else
                poruka = "Da li zelite da izmenite stanara?";

            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK) {
                if (naziv == null) {
                    if (DTOManager.dodajStanara(idStana, imeTextBox.Text.Trim().ToString())) {
                        MessageBox.Show("Uspesno ste dodali stanara!", "Obavestenje");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Doslo je do greske! Stanar nije dodat!");
                    }
                }
                else {
                    if (DTOManager.izmeniStanara(idStanara, imeTextBox.Text.Trim().ToString())) {
                        MessageBox.Show("Uspesno ste izmenili stanara mesto!", "Obavestenje");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Doslo je do greske! Stanar nije izmenjen!");
                    }
                }
            }

        }
    }
}
