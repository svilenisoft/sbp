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
    public partial class UlaziForm : Form {

        int idZgrade;
        public UlaziForm(int idZgrade, string zgrd) {
            this.idZgrade = idZgrade;
            InitializeComponent();

            label1.Text = zgrd;
        }

        private void UlaziForm_Load(object sender, EventArgs e) {
            fillUlaziList();
        }

        public void fillUlaziList() {
            ulaziListView.Items.Clear();
            List<UlazPregled> ulazi = DTOManager.getSviUlaziZgrade(idZgrade);
            foreach (UlazPregled u in ulazi) {
                ulaziListView.Items.Add(new ListViewItem(new string[] { u.id + "", u.broj + "", u.vOtvaranja, u.vZatvaranja, u.podPrismotrom }));
            }
            ulaziListView.Refresh();
        }

        private void dodajUlazBtn_Click(object sender, EventArgs e) {
            DodajUlazForm forma = new DodajUlazForm(idZgrade);
            forma.ShowDialog();
            fillUlaziList();
        }

        private void izmeniUlazBtn_Click(object sender, EventArgs e) {

            if (ulaziListView.SelectedItems.Count == 0) {
                MessageBox.Show("Izaberite ulaz koji zelite da menjate", "Obavestenje");
                return;
            }

            int idUlaza = Int32.Parse(ulaziListView.SelectedItems[0].SubItems[0].Text);
            string rbr = ulaziListView.SelectedItems[0].SubItems[1].Text;
            bool kamera = ulaziListView.SelectedItems[0].SubItems[4].Text.Equals("Ima kameru");
            string vo = ulaziListView.SelectedItems[0].SubItems[2].Text, vz = ulaziListView.SelectedItems[0].SubItems[3].Text;
            DodajUlazForm forma = new DodajUlazForm(idZgrade, idUlaza, rbr, kamera, vo, vz);
            forma.ShowDialog();
            fillUlaziList();
        }

        private void obrisiUlazBtn_Click(object sender, EventArgs e) {

            if (ulaziListView.SelectedItems.Count == 0) {
                MessageBox.Show("Izaberite ulaz koji zelite da obrisete", "Obavestenje");
                return;
            }
            int idUlaza = Int32.Parse(ulaziListView.SelectedItems[0].SubItems[0].Text);
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Da li zelite da obrisete ulaz?", "Paznja!", buttons);

            if (result == DialogResult.OK)
                if (DTOManager.obrisiUlaz(idUlaza)) {
                    MessageBox.Show("Uspesno ste obrisali ulaz!");
                    fillUlaziList();
                }
                else {
                    MessageBox.Show("Zgrada nije obrisana pokusajte ponovo!");
                }
        }
    }
}
