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
    public partial class IzborVlasnikaForma : Form {

        IDodajObjForm dodajObjForm;
        public IzborVlasnikaForma(IDodajObjForm iDodajObjForm) {
            dodajObjForm = iDodajObjForm;
            InitializeComponent();
        }

        private void IzborVlasnikaForma_Load(object sender, EventArgs e) {
            fillIzborList();
        }

        private void fillIzborList() {
            osobeList.Items.Clear();
            List<VlasnikPregled> osobe = DTOManager.getSveOsobe();
            foreach (VlasnikPregled o in osobe) {
                osobeList.Items.Add(new ListViewItem(new string[] { o.id + "", o.ime, o.imer, o.prezime, o.brtel, o.adresa, o.tip, o.jmbg }));
            }
            osobeList.Refresh();
        }


        private void okBtn_Click(object sender, EventArgs e) {
            if (osobeList.SelectedItems.Count == 0) {
                MessageBox.Show("Morate izabrati vlasnika!", "Obavestenje");
                return;
            }
            
            int idOsobe = Int32.Parse(osobeList.SelectedItems[0].SubItems[0].Text);
            string ime = osobeList.SelectedItems[0].SubItems[1].Text,
                imer = osobeList.SelectedItems[0].SubItems[2].Text,
                prezime = osobeList.SelectedItems[0].SubItems[3].Text,
                telefon = osobeList.SelectedItems[0].SubItems[4].Text,
                adresa = osobeList.SelectedItems[0].SubItems[5].Text,
                tip = osobeList.SelectedItems[0].SubItems[6].Text,
                jmbg = osobeList.SelectedItems[0].SubItems[7].Text;

            if (ime.Length == 0 || imer.Length == 0 || prezime.Length == 0 || telefon.Length == 0 || adresa.Length == 0 || tip.Length == 0 || jmbg.Length == 0) {
                MessageBox.Show("Morate izabrati osobu koja ima sve atribute!", "Obavestenje");
                return;
            }

            dodajObjForm.setUpravnik(idOsobe, ime, imer, prezime);
            this.Close();
        }

        private void izmeniBtn_Click(object sender, EventArgs e) {
            if (osobeList.SelectedItems.Count == 0) {
                MessageBox.Show("Morate izabrati osobu koju zelite da menjate!", "Obavestenje");
                return;
            }

            int idOsobe = Int32.Parse(osobeList.SelectedItems[0].SubItems[0].Text);
            string ime = osobeList.SelectedItems[0].SubItems[1].Text,
                imer = osobeList.SelectedItems[0].SubItems[2].Text,
                prezime = osobeList.SelectedItems[0].SubItems[3].Text,
                telefon = osobeList.SelectedItems[0].SubItems[4].Text,
                adresa = osobeList.SelectedItems[0].SubItems[5].Text,
                tip = osobeList.SelectedItems[0].SubItems[6].Text;
            long jmbg = long.Parse(osobeList.SelectedItems[0].SubItems[7].Text);
            new DodajVlasnikaForm(idOsobe, jmbg, ime, imer, prezime, telefon, adresa, tip).ShowDialog();
            fillIzborList();
        }



        private void dodajBtn_Click(object sender, EventArgs e) {
            new DodajVlasnikaForm(-1, 0, null, null, null, null, null, null).ShowDialog();
            fillIzborList();

        }
    }
}
