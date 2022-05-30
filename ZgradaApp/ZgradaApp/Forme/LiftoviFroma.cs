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
    public partial class LiftoviFroma : Form {
        private List<LiftPregled> liftovi;
        private int idZgrade;
        public LiftoviFroma(int idZgrade, string adresa) {
            this.idZgrade = idZgrade;
            InitializeComponent();

            zgradaLabel.Text = "Zgrada na adresi : " + adresa;

            fillLiftoviList();
        }
        private void fillLiftoviList() {
            listaLiftoviView.Items.Clear();
            liftovi = DTOManager.getSviLiftoviZgrade(idZgrade);
            foreach (LiftPregled z in liftovi) {
                ListViewItem item;
                if (z.datumKvara.Year != 0001)
                    item = new ListViewItem(new string[] { z.serBr + "", z.nazivProizvodjaca + "", z.datumServisa + "" ,z.datumKvara+"", z.brDanaKvara +"",
                    z.tip + "", z.nosivost+ "", z.maxBrOsoba +"",z.id + "" });
                else
                    item = new ListViewItem(new string[] { z.serBr + "", z.nazivProizvodjaca + "", z.datumServisa + "" , "", z.brDanaKvara +"",
                    z.tip + "", z.nosivost+ "", z.maxBrOsoba +"",z.id + "" });
                listaLiftoviView.Items.Add(item);

            }

            listaLiftoviView.Refresh();
        }


        private void btnDodajLift_Click(object sender, EventArgs e) {
            DodajLiftForm forma = new DodajLiftForm(idZgrade);
            forma.ShowDialog();
            fillLiftoviList();

        }

        private void btnIzmeni_Click(object sender, EventArgs e) {
            if (listaLiftoviView.SelectedItems.Count == 0) {
                MessageBox.Show("Izaberite zgradu koju zelite da izmenite!");
                return;
            }
            int idLifta = Int32.Parse(listaLiftoviView.SelectedItems[0].SubItems[8].Text);
            int serBr = Int32.Parse(listaLiftoviView.SelectedItems[0].SubItems[0].Text);
            string prozivodjac = listaLiftoviView.SelectedItems[0].SubItems[1].Text;
            string datumServisa = listaLiftoviView.SelectedItems[0].SubItems[2].Text;
            string datumKvara = listaLiftoviView.SelectedItems[0].SubItems[3].Text;
            int brojdanaKvara = Int32.Parse(listaLiftoviView.SelectedItems[0].SubItems[4].Text);
            int nosivost = Int32.Parse(listaLiftoviView.SelectedItems[0].SubItems[6].Text);
            int maxBrOsba = Int32.Parse(listaLiftoviView.SelectedItems[0].SubItems[7].Text);

            string tipLifta = listaLiftoviView.SelectedItems[0].SubItems[5].Text;
            DodajLiftForm forma = new DodajLiftForm(idZgrade, idLifta, serBr, prozivodjac, datumServisa, datumKvara, brojdanaKvara, nosivost, maxBrOsba, tipLifta);
            forma.ShowDialog();
            fillLiftoviList();
        }

        private void btnObrisi_Click(object sender, EventArgs e) {
            if (listaLiftoviView.SelectedItems.Count == 0) {
                MessageBox.Show("Izaberite lift koji zelite da obrisete!");
                return;
            }

            int idLifta = Int32.Parse(listaLiftoviView.SelectedItems[0].SubItems[8].Text);
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Da li zelite da obrisete lift?", "Paznja!", buttons);

            if (result == DialogResult.OK) {
                if (DTOManager.obrisiLift(idLifta)) {
                    MessageBox.Show("Uspesno ste obrisali lift!");
                    fillLiftoviList();
                }
                else {
                    MessageBox.Show("Doslo je do greske! lift nije obrisan!", "Paznja!");

                }

            }
            else {
                MessageBox.Show("Zgrada nije obrisana pokusajte ponovo!");
            }
        }


    }
}
