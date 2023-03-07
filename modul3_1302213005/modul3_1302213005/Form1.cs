using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302213005
{
    

    public partial class Form1 : Form
    {
        int nomor1 = -1;
        string angka1;
        int nomor2 = -1;
        string angka2;
        bool stop = false;


        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            stop = true;
            label1.Text += " + ";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            nomor1 = -1;
            angka1 = null;
            angka2 = null;
            nomor2= -1;
            stop = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int jumlah;
            nomor1 = Int32.Parse(angka1);
            nomor2 = Int32.Parse(angka2);
            jumlah = nomor1 + nomor2;


            label1.Text = jumlah.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (stop == false)
            {

                angka1 += "0";
                label1.Text += "0";
            }
            else
            {
                angka2 += "0";
                label1.Text += "0";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (stop == false)
            {
                
                angka1 += "1";
                label1.Text += "1";
            }
            else
            {
                angka2 += "1";
                label1.Text += "1";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (stop == false)
            {

                angka1 += "2";
                label1.Text += "2";
            }
            else
            {
                angka2 += "2";
                label1.Text += "2";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (stop == false)
            {

                angka1 += "3";
                label1.Text += "3";
            }
            else
            {
                angka2 += "3";
                label1.Text += "3";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (stop == false)
            {

                angka1 += "4";
                label1.Text += "4";
            }
            else
            {
                angka2 += "4";
                label1.Text += "4";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (stop == false)
            {

                angka1 += "5";
                label1.Text += "5";
            }
            else
            {
                angka2 += "5";
                label1.Text += "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (stop == false)
            {

                angka1 += "6";
                label1.Text += "6";
            }
            else
            {
                angka2 += "6";
                label1.Text += "6";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (stop == false)
            {

                angka1 += "7";
                label1.Text += "7";
            }
            else
            {
                angka2 += "7";
                label1.Text += "7";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (stop == false)
            {

                angka1 += "8";
                label1.Text += "8";
            }
            else
            {
                angka2 += "8";
                label1.Text += "8";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (stop == false)
            {

                angka1 += "9";
                label1.Text += "9";
            }
            else
            {
                angka2 += "9";
                label1.Text += "9";
            }
        }
    }
}
