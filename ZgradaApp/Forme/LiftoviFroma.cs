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
    public partial class LiftoviFroma : Form
    {
        private List<LiftPregled> liftovi;
        private int idZgrade;
        public LiftoviFroma(int idZgrade,string adresa)
        {
            this.idZgrade = idZgrade;
            InitializeComponent();

            zgradaLabel.Text = "Zgrada na adresi : " + adresa;

            fillLiftoviList();
        }
        private void fillLiftoviList()
        {
            listaLiftoviView.Items.Clear();
            liftovi = DTOManager.getSviLiftoviZgrade(idZgrade);
            foreach (LiftPregled z in liftovi)
            {
                ListViewItem item = new ListViewItem(new string[] { z.serBr + "", z.nazivProizvodjaca + "", z.datumServisa + "" ,z.datumKvara+"", z.brDanaKvara +"",
                    z.tip + "", z.nosivost+ "", z.maxBrOsoba +"",z.id + "" });
              //  MessageBox.Show(item.Text);
                listaLiftoviView.Items.Add(item);

            }

            listaLiftoviView.Refresh();
        }
      

        private void btnDodajLift_Click(object sender, EventArgs e)
        {
            DodajLiftForm forma = new DodajLiftForm(idZgrade);
            forma.ShowDialog();
            fillLiftoviList();

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listaLiftoviView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zgradu koju zelite da izmenite!");
                return;
            }
            //todo
            fillLiftoviList();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaLiftoviView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite lift koji zelite da obrisete!");
                return;
            }

            int idLifta= Int32.Parse(listaLiftoviView.SelectedItems[0].SubItems[8].Text);
            MessageBox.Show(listaLiftoviView.SelectedItems[0].SubItems[8].Text);
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Da li zelite da obrisete lift?", "Paznja!", buttons);

            if (result == DialogResult.OK)
            {
                if (DTOManager.obrisiNivo(idLifta))
                {
                    MessageBox.Show("Uspesno ste obrisali lift!");
                    fillLiftoviList();
                }
                else
                {
                    MessageBox.Show("Doslo je do greske! lift nije obrisan!", "Paznja!");

                }

            }
            else
            {
                MessageBox.Show("Zgrada nije obrisana pokusajte ponovo!");
            }
        }
    }
}
