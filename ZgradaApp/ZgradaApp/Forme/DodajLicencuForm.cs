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
    public partial class DodajLicencuForm : Form {

        int idOsobe, idLicence;
        public DodajLicencuForm(int idOsobe, int idLicence, string broj, string datum, string institucija) {
            this.idOsobe = idOsobe;
            this.idLicence = idLicence;
            InitializeComponent();

            if (idLicence != -1) {
                label1.Text = "Izmena licence";
                tbBrojLic.Text = broj;
                tbNazivInstitucije.Text = institucija;
                dateTimePicker1.Value = DateTime.Parse(datum);
            }
            else {
                label1.Text = "Dodavanje licence";
            }
            label1.Left = (this.Width - label1.Width) / 2;

        }

        private void btnUpisi_Click(object sender, EventArgs e) {

            if (tbBrojLic.Text.Length == 0) {
                MessageBox.Show("Morate uneti broj licence!", "Obavestenje");
                return;
            }

            if (tbNazivInstitucije.Text.Length == 0) {
                MessageBox.Show("Morate uneti naziv institucije!", "Obavestenje");
                return;
            }

            string poruka;
            if (idLicence == -1)
                poruka = "Da li zelite da dodate novu licencu?";
            else
                poruka = "Da li zelite da izmenite licencu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK) {
                if (idLicence == -1) {
                    if (DTOManager.dodajLicencu(idOsobe, Int32.Parse(tbBrojLic.Text), tbNazivInstitucije.Text, dateTimePicker1.Value)) {
                        MessageBox.Show("Uspesno ste dodali novu licencu!", "Obavestenje");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Doslo je do greske! Zaposleni nije dodat!", "Paznja!");
                    }
                }
                else {
                    if (DTOManager.izmeniLicencu(idLicence, Int32.Parse(tbBrojLic.Text), tbNazivInstitucije.Text, dateTimePicker1.Value)) {
                        MessageBox.Show("Uspesno ste izmenili zaposlenog!", "Obavestenje");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Doslo je do greske! Zaposleni nije izmenjen!", "Paznja!");
                    }
                }
            }
        }

        private void tbBrojLic_TextChanged(object sender, EventArgs e) {
            if (!int.TryParse(tbBrojLic.Text, out int r)) {
                tbBrojLic.Text = "";
            }
        }
    }
}
