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
    public partial class ZaposleniForma : Form {
        public ZaposleniForma() {
            InitializeComponent();

        }

        private void ZaposleniForma_Load(object sender, EventArgs e) {
            btnObrazovanje.Enabled = false;
            btnLicence.Enabled = false;

            fillZaposleniList();
        }
        private void fillZaposleniList() {
            List<ZaposleniPregled> zaposleni = DTOManager.getZaposleni();
            listView1.Items.Clear();
            foreach (ZaposleniPregled u in zaposleni) {
                if (u.upravnik)
                    listView1.Items.Add(new ListViewItem(new string[] { u.id + "", u.jmbg + "", u.brlk + "", u.ime, u.prezime, u.mestoIzdavanja, u.adresa, u.datumRodj, "DA", u.imeR }));
                else
                    listView1.Items.Add(new ListViewItem(new string[] { u.id + "", u.jmbg + "", u.brlk + "", u.ime, u.prezime, u.mestoIzdavanja, u.adresa, u.datumRodj, "NE", u.imeR }));
            }
            listView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e) {
            new DodajZaposlenog().ShowDialog();
            fillZaposleniList();
        }

        private void button2_Click(object sender, EventArgs e) {
            if (listView1.SelectedItems.Count == 0) {
                MessageBox.Show("Izaberite zaposlenog koji zelite da menjate!", "Obavestenje");
                return;
            }

            int idZaposlenog = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string jmbg = listView1.SelectedItems[0].SubItems[1].Text,
                brlk = listView1.SelectedItems[0].SubItems[2].Text,
                ime = listView1.SelectedItems[0].SubItems[3].Text,
                prezime = listView1.SelectedItems[0].SubItems[4].Text,
                mestoIzadavanja = listView1.SelectedItems[0].SubItems[5].Text,
                adresa = listView1.SelectedItems[0].SubItems[6].Text,
                datum = listView1.SelectedItems[0].SubItems[7].Text,
                imer = listView1.SelectedItems[0].SubItems[9].Text;
            bool upravnik = listView1.SelectedItems[0].SubItems[8].Text.Equals("DA");
            new DodajZaposlenog(idZaposlenog, jmbg, brlk, ime, imer, prezime, mestoIzadavanja, adresa, datum, upravnik).ShowDialog();
            fillZaposleniList();

        }

        private void button3_Click(object sender, EventArgs e) {
            if (listView1.SelectedItems.Count == 0) {
                MessageBox.Show("Izaberite zaposlenog koji zelite da obrisete!", "Obavestenje");
                return;
            }

            int idZaposlenog = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Da li zelite da obrisete zaposlenog?", "Paznja!", buttons);

            if (result == DialogResult.OK)
                if (DTOManager.obrisiZaposlenog(idZaposlenog)) {
                    MessageBox.Show("Uspesno ste obrisali zaposlenog!", "Obavestenje");
                    fillZaposleniList();
                }
                else {
                    MessageBox.Show("Zaposleni nije obrisan pokusajte ponovo!", "Paznja!");
                }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            if (listView1.SelectedItems.Count == 0) {
                return;
            }
            bool upravnik = listView1.SelectedItems[0].SubItems[8].Text.Equals("DA");
            if (upravnik) {
                btnObrazovanje.Enabled = true;
                btnLicence.Enabled = true;
            }
            else {
                btnObrazovanje.Enabled = false;
                btnLicence.Enabled = false;
            }
        }

        private void btnObrazovanje_Click(object sender, EventArgs e) {
            int idZaposlenog = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string ime = listView1.SelectedItems[0].SubItems[3].Text,
                prezime = listView1.SelectedItems[0].SubItems[4].Text,
                imer = listView1.SelectedItems[0].SubItems[9].Text;

            new ObrazovanjeForm(idZaposlenog, ime, imer, prezime).ShowDialog();
        }

        private void btnLicence_Click(object sender, EventArgs e) {
            int idZaposlenog = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string ime = listView1.SelectedItems[0].SubItems[3].Text,
                prezime = listView1.SelectedItems[0].SubItems[4].Text,
                imer = listView1.SelectedItems[0].SubItems[9].Text;

            new LicenceForm(idZaposlenog, ime + " (" + imer + ") " + prezime).ShowDialog();
        }
    }
}
