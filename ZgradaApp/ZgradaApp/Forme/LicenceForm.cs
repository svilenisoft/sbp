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
    public partial class LicenceForm : Form {

        int idZaposlenog;
        public LicenceForm(int i, string naziv) {
            idZaposlenog = i;
            InitializeComponent();
            label1.Text = naziv;
        }

        private void btnDodaj_Click(object sender, EventArgs e) {
            new DodajLicencuForm(idZaposlenog, -1, null, null, null).ShowDialog();
            fillLicenceList();
        }

        private void btnIzmeni_Click(object sender, EventArgs e) {
            if (licenceListView.SelectedItems.Count == 0) {
                MessageBox.Show("Izaberite licencu koju zelite da obrisete!", "Obavestenje");
                return;
            }

            int idLicence = Int32.Parse(licenceListView.SelectedItems[0].SubItems[0].Text);
            string broj = licenceListView.SelectedItems[0].SubItems[2].Text,
                datum = licenceListView.SelectedItems[0].SubItems[3].Text,
                insti = licenceListView.SelectedItems[0].SubItems[1].Text;
            new DodajLicencuForm(idZaposlenog, idLicence, broj, datum, insti).ShowDialog();
            fillLicenceList();
        }

        private void btnObrisi_Click(object sender, EventArgs e) {
            if (licenceListView.SelectedItems.Count == 0) {
                MessageBox.Show("Izaberite licencu koju zelite da obrisete!", "Obavestenje");
                return;
            }

            int idLicence = Int32.Parse(licenceListView.SelectedItems[0].SubItems[0].Text);
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Da li zelite da obrisete licencu?", "Paznja!", buttons);

            if (result == DialogResult.OK)
                if (DTOManager.obrisiLicencu(idLicence)) {
                    MessageBox.Show("Uspesno ste obrisali licencu!", "Obavestenje");
                    fillLicenceList();
                }
                else {
                    MessageBox.Show("Licenca nije obrisana pokusajte ponovo!", "Paznja!");
                }
        }

        private void btnObnavljanja_Click(object sender, EventArgs e) {
            if (licenceListView.SelectedItems.Count == 0) {
                MessageBox.Show("Izaberite licencu cija obnavljanja zelite da vidite!", "Obavestenje");
                return;
            }

            int idLicence = Int32.Parse(licenceListView.SelectedItems[0].SubItems[0].Text);
            new ObnavljanjaFOrm(idLicence).ShowDialog();
            
        }


        private void fillLicenceList() {
            licenceListView.Items.Clear();
            List<LicencaPregled> licence = DTOManager.getLicenceUpravnika(idZaposlenog);
            foreach (LicencaPregled l in licence)
                licenceListView.Items.Add(new ListViewItem(new string[] { l.id + "", l.naziv, l.broj + "", l.datum }));
            licenceListView.Refresh();
        }

        private void LicenceForm_Load(object sender, EventArgs e) {
            fillLicenceList();
        }
    }
}
