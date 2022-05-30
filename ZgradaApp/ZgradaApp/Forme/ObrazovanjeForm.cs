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
    public partial class ObrazovanjeForm : Form {

        int idZaposlenog;
        public ObrazovanjeForm(int id, string ime, string imer, string prezime) {
            idZaposlenog = id;
            InitializeComponent();
            label1.Text = ime + " (" + imer + ") " + prezime;
        }

        private void ObrazovanjeForm_Load(object sender, EventArgs e) {
            fillObrazovanjeList();
        }

        private void fillObrazovanjeList() {
            List<ObrazovanjePregled> obrazovanja = DTOManager.getObrazovanjaZaposlenog(idZaposlenog);
            obrazovanjeListView.Items.Clear();
            foreach (ObrazovanjePregled o in obrazovanja)
                obrazovanjeListView.Items.Add(new ListViewItem(new string[] { o.id + "", o.ustanova, o.zvanje, o.datum }));
            obrazovanjeListView.Refresh();
        }

        private void btnDodaj_Click(object sender, EventArgs e) {
            new DodajObrazovanjeForm(idZaposlenog, -1, null, null, null).ShowDialog();
            fillObrazovanjeList();
        }

        private void btnIzmeni_Click(object sender, EventArgs e) {
            if (obrazovanjeListView.SelectedItems.Count == 0) {
                MessageBox.Show("Izaberite obrazovanje koje zelite da menjate!", "Obavestenje");
                return;
            }

            int idObrazovanja = Int32.Parse(obrazovanjeListView.SelectedItems[0].SubItems[0].Text);
            string ustanova = obrazovanjeListView.SelectedItems[0].SubItems[1].Text,
                zvanje = obrazovanjeListView.SelectedItems[0].SubItems[2].Text,
                datum = obrazovanjeListView.SelectedItems[0].SubItems[3].Text;
            new DodajObrazovanjeForm(idZaposlenog, idObrazovanja, ustanova, zvanje, datum).ShowDialog();
            fillObrazovanjeList();
        }

        private void btnObrisi_Click(object sender, EventArgs e) {
            if (obrazovanjeListView.SelectedItems.Count == 0) {
                MessageBox.Show("Izaberite obrazovanje koje zelite da menjate!", "Obavestenje");
                return;
            }

            int idObrazovanja = Int32.Parse(obrazovanjeListView.SelectedItems[0].SubItems[0].Text);
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Da li zelite da obrisete obrazovanje?", "Paznja!", buttons);

            if (result == DialogResult.OK)
                if (DTOManager.obrisiObrazovanje(idObrazovanja)) {
                    MessageBox.Show("Uspesno ste obrisali obrazovanje!", "Obavestenje");
                    fillObrazovanjeList();
                }
                else {
                    MessageBox.Show("Obrazovanje nije obrisano, pokusajte ponovo!", "Paznja!");
                }
        }
    }
}
