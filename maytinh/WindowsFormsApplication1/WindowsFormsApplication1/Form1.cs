using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private bool kiemtra;
        private string toan, gtcuoi;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void xoa_Click(object sender, EventArgs e)
        {
            kkq.Clear();
        }

        private void s0_Click(object sender, EventArgs e)
        {
            if (kiemtra) kkq.Clear();
            kkq.Text = kkq.Text + "0";
            kiemtra = false;
            
        }

        private void s1_Click(object sender, EventArgs e)
        {

            if (kiemtra) kkq.Clear();
            kkq.Text = kkq.Text + "1";
            kiemtra = false;
        }

        private void s2_Click(object sender, EventArgs e)
        {

            if (kiemtra) kkq.Clear();
            kkq.Text = kkq.Text + "2";
            kiemtra = false;
        }

        private void s3_Click(object sender, EventArgs e)
        {

            if (kiemtra) kkq.Clear();
            kkq.Text = kkq.Text + "3";
            kiemtra = false;
        }

        private void s4_Click(object sender, EventArgs e)
        {

            if (kiemtra) kkq.Clear();
            kkq.Text = kkq.Text + "4";
            kiemtra = false;
        }

        private void s5_Click(object sender, EventArgs e)
        {

            if (kiemtra) kkq.Clear();
            kkq.Text = kkq.Text + "5";
            kiemtra = false;
        }

        private void s6_Click(object sender, EventArgs e)
        {

            if (kiemtra) kkq.Clear();
            kkq.Text = kkq.Text + "6";
            kiemtra = false;
        }

        private void s7_Click(object sender, EventArgs e)
        {

            if (kiemtra) kkq.Clear();
            kkq.Text = kkq.Text + "7";
            kiemtra = false;
        }

        private void s8_Click(object sender, EventArgs e)
        {

            if (kiemtra) kkq.Clear();
            kkq.Text = kkq.Text + "8";
            kiemtra = false;
        }

        private void s9_Click(object sender, EventArgs e)
        {

            if (kiemtra) kkq.Clear();
            kkq.Text = kkq.Text + "9";
            kiemtra = false;
        }

        private void cong_Click(object sender, EventArgs e)
        {
            gtcuoi = kkq.Text;
            kiemtra = true;
            toan = "+";
        }

        private void tru_Click(object sender, EventArgs e)
        {
            gtcuoi = kkq.Text;
            kiemtra = true;
            toan = "-";
        }

        private void nhan_Click(object sender, EventArgs e)
        {
            gtcuoi = kkq.Text;
            kiemtra = true;
            toan = "*";
        }

        private void chia_Click(object sender, EventArgs e)
        {
            gtcuoi = kkq.Text;
            kiemtra = true;
            toan = "/";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(gtcuoi); 
            b = Convert.ToDouble(kkq.Text);


            if (toan == "+") kkq.Text = Convert.ToString(a + b);
            if (toan == "-") kkq.Text = Convert.ToString(a - b);
            if (toan == "*") kkq.Text = Convert.ToString(a * b);
            if (toan == "/") kkq.Text = Convert.ToString(a / b);
        }

        private void button39_Click(object sender, EventArgs e)
        {

        }
    }
}
