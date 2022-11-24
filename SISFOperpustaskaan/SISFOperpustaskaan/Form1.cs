using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISFOperpustaskaan
{
    public partial class MenuUtama : Form
    {
        public MenuUtama()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            lblSelected1.Visible = true;
            lblSelected2.Visible = false;
            lblSelected3.Visible = false;
            lblSelected4.Visible = false;
            lblSelected5.Visible = false;
            lblSelected6.Visible = false;

            pnlDataMaster.Visible = true;
            pnlTransaksi.Visible = false;
            pnlLap.Visible = false;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblSelected1.Visible = false;
            lblSelected2.Visible = false;
            lblSelected3.Visible = true;
            lblSelected4.Visible = false;
            lblSelected5.Visible = false;
            lblSelected6.Visible = false;

            pnlDataMaster.Visible = false;
            pnlTransaksi.Visible = false;
            pnlLap.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblSelected1.Visible = false;
            lblSelected2.Visible = true;
            lblSelected3.Visible = false;
            lblSelected4.Visible = false;
            lblSelected5.Visible = false;
            lblSelected6.Visible = false;

            pnlDataMaster.Visible = false;
            pnlTransaksi.Visible = true;
            pnlLap.Visible = false;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLainnya_Click(object sender, EventArgs e)
        {
            lblSelected1.Visible = false;
            lblSelected2.Visible = false;
            lblSelected3.Visible = false;
            lblSelected4.Visible = true;
            lblSelected5.Visible = false;
            lblSelected6.Visible = false;
        }

        private void btnTentangAplikasi_Click(object sender, EventArgs e)
        {
            lblSelected1.Visible = false;
            lblSelected2.Visible = false;
            lblSelected3.Visible = false;
            lblSelected4.Visible = false;
            lblSelected5.Visible = true;
            lblSelected6.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            lblSelected1.Visible = false;
            lblSelected2.Visible = false;
            lblSelected3.Visible = false;
            lblSelected4.Visible = false;
            lblSelected5.Visible = false;
            lblSelected6.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e) 
        {
          
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
    }
}
