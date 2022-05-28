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
    public partial class NivoiForm : Form {

        private List<NivoPregled> nivoi;
        private int idZgrade;
        public NivoiForm(int idZgrade, string adresa) {
            this.idZgrade = idZgrade;
            InitializeComponent();

            zgradaLabel.Text = "Zgrada na adresi : " + adresa;

            fillNivoiList();
        }

        private void fillNivoiList() {
            nivoiListView.Items.Clear();
            nivoi = DTOManager.getSviNivoiZgrade(idZgrade);
            foreach (NivoPregled z in nivoi) {
                ListViewItem item = new ListViewItem(new string[] { z.id + "", z.brNivoa + "", z.tipNivoa, z.brObjekata + "" });
                nivoiListView.Items.Add(item);

            }

            nivoiListView.Refresh();
        }

        private void btnDodaj_Click(object sender, EventArgs e) {
            DodajNivoForm forma = new DodajNivoForm(idZgrade);
            forma.ShowDialog();
            fillNivoiList();
        }

        private void btnIzmeni_Click(object sender, EventArgs e) {
            if (nivoiListView.SelectedItems.Count == 0) {
                MessageBox.Show("Izaberite zgradu koju zelite da izmenite!");
                return;
            }
            int idNivoa = Int32.Parse(nivoiListView.SelectedItems[0].SubItems[0].Text);
            int brNivoa = Int32.Parse(nivoiListView.SelectedItems[0].SubItems[1].Text);
            string tipNivoa = nivoiListView.SelectedItems[0].SubItems[2].Text;
            DodajNivoForm forma = new DodajNivoForm(idZgrade, idNivoa, brNivoa, tipNivoa);
            forma.ShowDialog();
            fillNivoiList();
        }

        private void btnObrisi_Click(object sender, EventArgs e) {
            if (nivoiListView.SelectedItems.Count == 0) {
                MessageBox.Show("Izaberite nivo koji zelite da obrisete!");
                return;
            }

            int idNivoa = Int32.Parse(nivoiListView.SelectedItems[0].SubItems[0].Text);
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Da li zelite da obrisete nivo?", "Paznja!", buttons);

            if (result == DialogResult.OK) {
                if (DTOManager.obrisiNivo(idNivoa)) {
                    MessageBox.Show("Uspesno ste obrisali nivo!");
                    fillNivoiList();
                }
                else {
                    MessageBox.Show("Doslo je do greske! Nivo nije obrisan!", "Paznja!");

                }

            }
            else {
                MessageBox.Show("Zgrada nije obrisana pokusajte ponovo!");
            }
        }

        private void nivoiListView_DoubleClick(object sender, EventArgs e) {
            int idNivoa = Int32.Parse(nivoiListView.SelectedItems[0].SubItems[0].Text);
            string tip = nivoiListView.SelectedItems[0].SubItems[2].Text;
            int rbr = Int32.Parse(nivoiListView.SelectedItems[0].SubItems[1].Text);
            ObjektiForma forma = new ObjektiForma(idNivoa, tip, rbr);
            forma.ShowDialog();

        }
    }
}
