using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otobusbileti
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                secilenkoltulbl.Text = "1 Numaralı Koltuk";
                lblbilettutar.Text = "2000 TL";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                secilenkoltulbl.Text = "2 Numaralı Koltuk";
                lblbilettutar.Text = "1500 TL";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                secilenkoltulbl.Text = "3 Numaralı Koltuk";
                lblbilettutar.Text = "1500 TL";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                secilenkoltulbl.Text = "4 Numaralı Koltuk";
                lblbilettutar.Text = "2000 TL";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                secilenkoltulbl.Text = "5 Numaralı Koltuk";
                lblbilettutar.Text = "1500 TL";
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                secilenkoltulbl.Text = "6 Numaralı Koltuk";
                lblbilettutar.Text = "1500 TL";
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                secilenkoltulbl.Text = "7 Numaralı Koltuk";
                lblbilettutar.Text = "2000 TL";
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                secilenkoltulbl.Text = "8 Numaralı Koltuk";
                lblbilettutar.Text = "1500 TL";
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                secilenkoltulbl.Text = "9 Numaralı Koltuk";
                lblbilettutar.Text = "1500 TL";
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                secilenkoltulbl.Text = "10 Numaralı Koltuk";
                lblbilettutar.Text = "2000 TL";
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked == true)
            {
                secilenkoltulbl.Text = "11 Numaralı Koltuk";
                lblbilettutar.Text = "1500 TL";
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                secilenkoltulbl.Text = "12 Numaralı Koltuk";
                lblbilettutar.Text = "1500 TL";
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                secilenkoltulbl.Text = "13 Numaralı Koltuk";
                lblbilettutar.Text = "2000 TL";
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked == true)
            {
                secilenkoltulbl.Text = "14 Numaralı Koltuk";
                lblbilettutar.Text = "1500 TL";
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked == true)
            {
                secilenkoltulbl.Text = "15 Numaralı Koltuk";
                lblbilettutar.Text = "1500 TL";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        Form3 form3 = new Form3();
        form3.Show();
          
        }
    }
}
