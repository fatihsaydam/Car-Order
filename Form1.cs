using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _140714Win_ArabaSiparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            cmbMotorHacmi.Items.Add("1.2");
            cmbMotorHacmi.Items.Add("1.3");
            cmbMotorHacmi.Items.Add("1.4");
            cmbMotorHacmi.Items.Add("1.6");
            cmbMotorHacmi.Items.Add("1.8");
            cmbMotorHacmi.Items.Add("2.0");
            cmbMotorHacmi.Items.Add("3.0");
            cmbMotorHacmi.Items.Add("4.0");
            cmbMotorHacmi.Items.Add("5.2");

           
        }

        private void btnRenkSec_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnRenkSec.BackColor = colorDialog1.Color;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListViewItem satir = new ListViewItem();
            satir.Text = txtIsimSoyisim.Text;
            satir.SubItems.Add(cmbModel.Text);
            satir.UseItemStyleForSubItems = false;
            satir.SubItems.Add("");
            satir.SubItems[2].BackColor = btnRenkSec.BackColor;
            satir.SubItems.Add(cmbMotorTipi.Text);
            satir.SubItems.Add(cmbMotorHacmi.Text);
            listView1.Items.Add(satir);

            txtIsimSoyisim.Clear();
            cmbModel.SelectedIndex = cmbMotorHacmi.SelectedIndex = cmbMotorTipi.SelectedIndex = -1;
            btnRenkSec.BackColor = Color.Empty;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMotorTipi.Items.Clear();
            switch(cmbModel.SelectedIndex)
            {
                case 0: cmbMotorTipi.Items.Add("Cla 200");
                    cmbMotorTipi.Items.Add("A Series");
                    cmbMotorTipi.Items.Add("C 200"); break;
                case 1: cmbMotorTipi.Items.Add("Jetta");
                    cmbMotorTipi.Items.Add("Passat");
                    cmbMotorTipi.Items.Add("Cc");
                    cmbMotorTipi.Items.Add("Golf");
                    break;
                case 2:
                    cmbMotorTipi.Items.Add("5.20");
                    cmbMotorTipi.Items.Add("3.20");
                    cmbMotorTipi.Items.Add("1.16");
                    cmbMotorTipi.Items.Add("5.25");
                    break;
                case 3:
                    cmbMotorTipi.Items.Add("S60");
                    cmbMotorTipi.Items.Add("S40");
                    cmbMotorTipi.Items.Add("S80");
                    break;
                    
            }
        }
    }
}
