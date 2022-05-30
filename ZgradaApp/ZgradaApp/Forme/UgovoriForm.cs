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
    public partial class UgovoriForm : Form {

        int idZgrade;

        public UgovoriForm(int idZgrade, string zgrd) {
            this.idZgrade = idZgrade;
            InitializeComponent();
            label1.Text = zgrd;
        }



        private void UgovoriForm_Load(object sender, EventArgs e) {
            fillUgovoriList();
        }

        private void btnDodajUgovor_Click(object sender, EventArgs e) {
            new DodajUgovorForm(idZgrade).ShowDialog();
            fillUgovoriList();
        }

        private void btnIzmeniUgovor_Click(object sender, EventArgs e) {
            if (ugovoriListView.SelectedItems.Count == 0) {
                MessageBox.Show("Izaberite ugovor koji zelite da menjate!", "Obavestenje");
                return;
            }

            int idUgovora = Int32.Parse(ugovoriListView.SelectedItems[0].SubItems[0].Text);
            string sifraUgovora = ugovoriListView.SelectedItems[0].SubItems[1].Text,
                vazenje = ugovoriListView.SelectedItems[0].SubItems[2].Text,
                datum = ugovoriListView.SelectedItems[0].SubItems[3].Text;
            new DodajUgovorForm(idZgrade, idUgovora, sifraUgovora, vazenje, datum).ShowDialog();
            fillUgovoriList();
        }

        private void btnObrisiUgovor_Click(object sender, EventArgs e) {
            if (ugovoriListView.SelectedItems.Count == 0) {
                MessageBox.Show("Izaberite ugovor koji zelite da obrisete!", "Obavestenje");
                return;
            }

            int idUgovora = Int32.Parse(ugovoriListView.SelectedItems[0].SubItems[0].Text);
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Da li zelite da obrisete ugovor?", "Paznja!", buttons);

            if (result == DialogResult.OK)
                if (DTOManager.obrisiUgovor(idUgovora)) {
                    MessageBox.Show("Uspesno ste obrisali ugovor!", "Obavestenje");
                    fillUgovoriList();
                }
                else {
                    MessageBox.Show("Ugovor nije obrisan pokusajte ponovo!", "Paznja!");
                }
        }

        private void fillUgovoriList() {
            List<UgovorPregled> ugovori = DTOManager.getUgovoriSaZgradom(idZgrade);
            ugovoriListView.Items.Clear();
            foreach (UgovorPregled u in ugovori) {
                ugovoriListView.Items.Add(new ListViewItem(new string[] { u.id + "", u.sifra + "", u.vazenje + "", u.datum, u.datumKraja }));
            }
            ugovoriListView.Refresh();
        }


    }
}
