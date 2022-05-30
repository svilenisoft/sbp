using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZgradaApp.Entiteti;

namespace ZgradaApp.Forme {
    public partial class DodajZgraduForm : Form {
        List<UpravnikSimplePregled> upravnici;
        int idZgrade, idUpravnika;
        public DodajZgraduForm() {
            InitializeComponent();

            label1.Text = "Dodavanje zgrade";
            upravnici = DTOManager.getSviUpravnici();
            upravnikComboBox.Items.Clear();
            foreach (UpravnikSimplePregled u in upravnici) {
                upravnikComboBox.Items.Add(u.naziv);
            }
            idZgrade = -1;

        }

        public DodajZgraduForm(int idZgrade, int idUpravnika, string adresa) {

            InitializeComponent();

            label1.Text = "Menjanje zgrade";


            this.idZgrade = idZgrade;
            this.idUpravnika = idUpravnika;
            adresaTextBox.Text = adresa;

            upravnici = DTOManager.getSviUpravnici();
            upravnikComboBox.Items.Clear();
            int sIndex = 0;
            bool found = false;

            foreach (UpravnikSimplePregled u in upravnici) {
                upravnikComboBox.Items.Add(u.naziv);
                if (u.id == idUpravnika) found = true;
                if (!found) sIndex++;

            }
            upravnikComboBox.SelectedIndex = sIndex;
        }

        private void upisiBtn_Click(object sender, EventArgs e) {
            if (adresaTextBox.Text.Trim().Length == 0) {
                MessageBox.Show("Morate uneti adresu za zgradu!");
                return;
            }

            if (upravnikComboBox.SelectedIndex == -1) {
                MessageBox.Show("Morate izabrati upravnika za zgradu!");
                return;
            }

            string poruka;
            if (idZgrade == -1)
                poruka = "Da li zelite da dodate novu zgradu?";
            else
                poruka = "Da li zelite da izmenite zgradu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK) {
                if (idZgrade == -1) {
                    DTOManager.dodajZgradu(adresaTextBox.Text.Trim(), upravnici[upravnikComboBox.SelectedIndex].id);
                    MessageBox.Show("Uspesno ste dodali novu zgradu!");
                }
                else {
                    DTOManager.izmeniZgradu(adresaTextBox.Text.Trim(), upravnici[upravnikComboBox.SelectedIndex].id, idZgrade);
                    MessageBox.Show("Uspesno ste izmenili zgradu!");
                }
                this.Close();
            }

        }
    }
}
