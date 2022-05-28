﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZgradaApp.Forme;

namespace ZgradaApp
{
    public partial class ZgradeForm : Form
    {
        List<ZgradaPregled> zgrade;
        public ZgradeForm()
        {
            InitializeComponent();
        }

        private void ZgradeForm_Load(object sender, EventArgs e)
        {
            fillZgradeList();
        }
        private void fillZgradeList()
        {
            zgradeListView.Items.Clear();
            zgrade = DTOManager.getSveZgrade();
            foreach (ZgradaPregled z in zgrade)
            {
                ListViewItem item = new ListViewItem(new string[] { z.id + "", z.imeUpravnika, z.adresa });
                zgradeListView.Items.Add(item);

            }

            zgradeListView.Refresh();
        }

        private void btnDodajZgradu_Click(object sender, EventArgs e)
        {
            DodajZgraduForm formaDodaj = new DodajZgraduForm();
            formaDodaj.ShowDialog();
            fillZgradeList();
        }

        private void btnIzmeniZgradu_Click(object sender, EventArgs e)
        {
            int index = zgradeListView.FocusedItem.Index;
            if ( index == 0)
            {
                MessageBox.Show("Izaberite zgradu koju zelite da izmenite!");
                return;
            }

            DodajZgraduForm formaDodaj = new DodajZgraduForm(zgrade[index].id, zgrade[index].idUpravnika, zgrade[index].adresa);
            formaDodaj.ShowDialog();
            fillZgradeList();

        }
        private void btnObrisiZgradu_Click(object sender, EventArgs e)
        {
            if (zgradeListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zgradu koju zelite da obrisete!");
                return;
            }

            int idZgrade = Int32.Parse(zgradeListView.SelectedItems[0].SubItems[0].Text);
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Da li zelite da obrisete zgradu?", "Paznja!", buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiZgradu(idZgrade);
                MessageBox.Show("Uspesno ste obrisali zgradu!");
                fillZgradeList();
            }
            else
            {
                MessageBox.Show("Zgrada nije obrisana pokusajte ponovo!");
            }
        }
        private void btnNivoi_Click(object sender, EventArgs e)
        {
            if (zgradeListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zgradu cije nivoe zelite da vidite!");
                return;
            }

            int idZgrade = Int32.Parse(zgradeListView.SelectedItems[0].SubItems[0].Text);
            NivoiForm forma = new NivoiForm(idZgrade, zgradeListView.SelectedItems[0].SubItems[2].Text);
            forma.ShowDialog();
        }


    }
}