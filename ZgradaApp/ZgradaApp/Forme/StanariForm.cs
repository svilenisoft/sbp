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
    public partial class StanariForm : Form {

        int idStana;

        public StanariForm(int idStana) {
            this.idStana = idStana;
            InitializeComponent();
        }

        private void StanariForm_Load(object sender, EventArgs e) {
            fillStanariList();
        }

        private void fillStanariList() {
            stanariListView.Items.Clear();
            List<OsobaPregled> stanari = DTOManager.getStanariStana(idStana);
            foreach (OsobaPregled osoba in stanari) {
                stanariListView.Items.Add(new ListViewItem(new string[] { osoba.id + "", osoba.naziv }));
            }
            stanariListView.Refresh();
        }

        private void btnDodajStanara_Click(object sender, EventArgs e) {
            new DodajStanaraForm(idStana, 0, null).ShowDialog();
            fillStanariList();
        }

        private void btnIzmeniStanara_Click(object sender, EventArgs e) {
            if (stanariListView.SelectedItems.Count == 0) {
                MessageBox.Show("Morate izabrati stanara kog zelite da izmenite!", "Obavestenje");
                return;
            }
            int idStanara = Int32.Parse(stanariListView.SelectedItems[0].SubItems[0].Text);
            string naziv = stanariListView.SelectedItems[0].SubItems[1].Text;
            new DodajStanaraForm(idStana, idStanara, naziv).ShowDialog();
            fillStanariList();
        }

        private void brnObrisiStanara_Click(object sender, EventArgs e) {
            if (stanariListView.SelectedItems.Count == 0) {
                MessageBox.Show("Morate izabrati stanara kog zelite da obrisete!", "Obavestenje");
                return;
            }

            int idOStanara = Int32.Parse(stanariListView.SelectedItems[0].SubItems[0].Text);
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Da li zelite da obrisete stanara?", "Paznja!", buttons);

            if (result == DialogResult.OK) {
                if (DTOManager.obrisiStanara(idOStanara)) {
                    MessageBox.Show("Uspesno ste obrisali stanara!", "Obavestenje");
                    fillStanariList();
                }
                else {
                    MessageBox.Show("Doslo je do greske! Stanar nije obrisan!", "Paznja!");
                }
            }
        }
    }
}
