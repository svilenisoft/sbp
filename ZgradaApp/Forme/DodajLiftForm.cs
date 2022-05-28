using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZgradaApp.Forme
{
    public partial class DodajLiftForm : Form
    {
        private int idZgrade, idLifta;
        public DodajLiftForm(int idZgrade)
        {
            this.idZgrade = idZgrade;
            InitializeComponent();
            lblNaslov.Text = "Dodavanje lifta";
            idLifta = -1;
            comboBox1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Morate uneti  serijski broj!");
                return;
            }
            if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Morate uneti naziv proizvodjaca!");
                return;
            }
            if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Morate uneti datum servisa!");
                return;
            }
            if (textBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("Morate uneti datum kvara!");
                return;
            }
            if (textBox5.Text.Trim().Length == 0)
            {
                MessageBox.Show("Morate uneti broj dana kvara!");
                return;
            }
            if (textBox6.Text.Trim().Length == 0)
            {
                MessageBox.Show("Morate uneti nosivost lifta!");
                return;
            }
            if (textBox7.Text.Trim().Length == 0)
            {
                MessageBox.Show("Morate uneti maximalan broj osoba u liftu!");
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Morate odabrati tip lifta!");
                return;
            }

            string poruka;
            if (idLifta == -1)
                poruka = "Da li zelite da dodate novi lift?";
            else
                poruka = "Da li zelite da izmenite lift?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {

                if (idLifta == -1)
                {
                    if (DTOManager.dodajLift(this.idZgrade, textBox1.Text, textBox5.Text, textBox6.Text, textBox7.Text, comboBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text))
                    {
                        MessageBox.Show("Uspesno ste dodali novi lifta!");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Doslo je do greske! lift nije upisan!");
                }
                else
                {
                    if (DTOManager.izmeniLift(idLifta, textBox3.Text,textBox4.Text,textBox5.Text))
                    {
                        MessageBox.Show("Uspesno ste izmenili lift!", "Uspeh");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Doslo je do greske! lift nije izmenjen!", "Greska");
                }

            }

        }
    

        public DodajLiftForm(int idZgrade, int idLifta, int serBr,string nazivProizvodjaca, string datumServisa,string datumKvara,int brojDanaKvara,int nosivost,int maxBrOsoba, string tipLifta)
        {
            this.idZgrade = idZgrade;
            this.idLifta = idLifta;
            InitializeComponent();
            lblNaslov.Text = "Izmena lifta";

           
            textBox1.Text = serBr.ToString();
            textBox2.Text = nazivProizvodjaca;
            textBox3.Text = datumServisa;
            textBox4.Text = datumKvara;
            textBox5.Text = brojDanaKvara.ToString();
            textBox6.Text = nosivost.ToString();
            textBox7.Text = maxBrOsoba.ToString();


            switch (tipLifta)
            {
                case "teretni":
                    comboBox1.SelectedIndex = 0;
                    break;
                case "putnicki":
                    comboBox1.SelectedIndex = 1;
                    break;
            }
            comboBox1.Enabled = false;

        }

    }
}
