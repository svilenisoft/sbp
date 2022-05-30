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

    public partial class DodajObjekatForm : Form, IDodajObjForm {

        string tip, data;
        int idNivoa, idObjekta, rbr, idVlasnika;

        public DodajObjekatForm(int idNivoa, string tip) {
            this.idNivoa = idNivoa;
            idObjekta = -1;
            this.tip = tip;
            InitializeComponent();

        }
        public DodajObjekatForm(int idNivoa, string tip, int idObjekta, int rbr, string data) {
            this.idNivoa = idNivoa;
            this.tip = tip;
            this.idObjekta = idObjekta;
            this.rbr = rbr;
            this.data = data;
            InitializeComponent();
            brObjektaTxtBox.Text = rbr.ToString();
        }

        private void DodajObjekatForm_Load(object sender, EventArgs e) {
            switch (tip) {
                case "Stambeni nivo":
                    if (idObjekta == -1) {
                        label1.Text = "Dodavanje stana";
                    }
                    else
                        label1.Text = "Izmena stana";

                    label1.Left = (this.Width - label1.Width) / 2;
                    dodajStanPannel.Visible = true;
                    dodajLokalPannel.Visible = false;
                    dodajMestoPannel.Visible = false;
                    vlasnikLable.Text = data;
                    //fillVlasniciComboBox();
                    break;
                case "Poslovni nivo":
                    if (idObjekta == -1)
                        label1.Text = "Dodavanje poslovnog objekta";
                    else {
                        label1.Text = "Izmena poslovnog objekta";
                        brObjektaTxtBox.Text = rbr.ToString();
                        imeFirmeTxtBox.Text = data;
                    }
                    label1.Left = (this.Width - label1.Width) / 2;
                    dodajStanPannel.Visible = false;
                    dodajLokalPannel.Visible = true;
                    dodajMestoPannel.Visible = false;
                    break;
                case "Garazni nivo":
                    if (idObjekta == -1)
                        label1.Text = "Dodavanje garaznog mesta";
                    else {
                        label1.Text = "Izmena garaznog mesta";
                        brObjektaTxtBox.Text = rbr.ToString();
                        regBrTxtBox.Text = data;
                    }
                    label1.Left = (this.Width - label1.Width) / 2;
                    dodajStanPannel.Visible = false;
                    dodajLokalPannel.Visible = false;
                    dodajMestoPannel.Visible = true;
                    break;
            }
        }

        private void brObjektaTxtBox_TextChanged(object sender, EventArgs e) {
            if (brObjektaTxtBox.Text.Equals("-"))
                return;
            if (!int.TryParse(brObjektaTxtBox.Text, out int r)) {
                brObjektaTxtBox.Text = "";
            }
        }

        private void upisBtn_Click(object sender, EventArgs e) {
            switch (tip) {
                case "Stambeni nivo":
                    dodaj_IzmeniStan();
                    break;
                case "Poslovni nivo":
                    dodaj_izmeniPoslovniObjekat();
                    break;
                case "Garazni nivo":
                    dodaj_izmeniParkingMesto();
                    break;
            }
        }

        private void dodaj_izmeniPoslovniObjekat() {
            if (brObjektaTxtBox.Text.Length == 0) {
                MessageBox.Show("Morate uneti redi broj objekta!", "Paznja!");
                return;
            }
            if (imeFirmeTxtBox.Text.Trim().Length == 0) {
                MessageBox.Show("Morate uneti ime firme!", "Paznja!");
                return;
            }


            string poruka;
            if (idObjekta == -1)
                poruka = "Da li zelite da dodate poslovni objekat?";
            else
                poruka = "Da li zelite da izmenite poslovni objekat?";

            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK) {
                if (idObjekta == -1) {
                    if (DTOManager.dodajPoslovniObjekat(idNivoa, imeFirmeTxtBox.Text.Trim(), Int32.Parse(brObjektaTxtBox.Text))) {
                        MessageBox.Show("Uspesno ste dodali poslovni objekat!", "Obavestenje");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Doslo je do greske! Objekat nije dodat!");
                    }
                }
                else {
                    if (DTOManager.izmeniPoslovniObjekat(idObjekta, imeFirmeTxtBox.Text.Trim(), Int32.Parse(brObjektaTxtBox.Text))) {
                        MessageBox.Show("Uspesno ste izmenili poslovni objekat!", "Obavestenje");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Doslo je do greske! Objekat nije izmenjen!");
                    }
                }
            }
        }

        private void dodaj_izmeniParkingMesto() {
            if (brObjektaTxtBox.Text.Length == 0) {
                MessageBox.Show("Morate uneti redi broj objekta!", "Paznja!");
                return;
            }

            string poruka;
            if (idObjekta == -1)
                poruka = "Da li zelite da dodate parking mesto?";
            else
                poruka = "Da li zelite da izmenite parking mesto?";

            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK) {
                if (idObjekta == -1) {
                    if (DTOManager.dodajGaraznoMesto(idNivoa, regBrTxtBox.Text.Trim(), Int32.Parse(brObjektaTxtBox.Text))) {
                        MessageBox.Show("Uspesno ste dodali garazno mesto!", "Obavestenje");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Doslo je do greske! Objekat nije dodat!");
                    }
                }
                else {
                    if (DTOManager.izmeniGaraznoMesto(idObjekta, regBrTxtBox.Text.Trim(), Int32.Parse(brObjektaTxtBox.Text))) {
                        MessageBox.Show("Uspesno ste izmenili garazno mesto!", "Obavestenje");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Doslo je do greske! Objekat nije izmenjen!");
                    }
                }
            }
        }

        private void noviVlasnikBtn_Click(object sender, EventArgs e) {
            new IzborVlasnikaForma(this).ShowDialog();
        }

        public void setUpravnik(int idOsobe, string ime, string imer, string prezime) {
            idVlasnika = idOsobe;
            data = ime + " (" + imer + ") " + prezime;
            vlasnikLable.Text = data;
            this.Refresh();
        }


        private void dodaj_IzmeniStan() {
            if (idVlasnika == -1) {
                MessageBox.Show("Morate odabrati vlasnika!", "Paznja!");
                return;
            }
            string poruka;
            if (idObjekta == -1)
                poruka = "Da li zelite da dodate stan?";
            else
                poruka = "Da li zelite da izmenite stan?";

            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK) {
                if (idObjekta == -1) {
                    if (DTOManager.dodajStan(idNivoa, brObjektaTxtBox.Text.Trim(), idVlasnika)) {
                        MessageBox.Show("Uspesno ste dodali stan!", "Obavestenje");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Doslo je do greske! Stan nije dodat!");
                    }
                }
                else {
                    if (DTOManager.izmeniStan(idObjekta, brObjektaTxtBox.Text.Trim(), idVlasnika)) {
                        MessageBox.Show("Uspesno ste izmenili stan!", "Obavestenje");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Doslo je do greske! Stan nije izmenjen!");
                    }
                }
            }

        }
    }
}
