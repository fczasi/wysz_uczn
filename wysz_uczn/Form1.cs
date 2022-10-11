using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wysz_uczn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Image[] pics =
                {
                    wysz_uczn.Properties.Resources._1,//mxyxw
                    wysz_uczn.Properties.Resources._2,//b5nnm
                    wysz_uczn.Properties.Resources._3,//74853
                    wysz_uczn.Properties.Resources._4,//cg5dd
                    wysz_uczn.Properties.Resources._5,//x3deb
                    wysz_uczn.Properties.Resources._6,//befhd
                    wysz_uczn.Properties.Resources._7//c7gb3
                };
            int correctImgWithCode = 0;

            var rand = new Random();
            var los = rand.Next(pics.Length);
            pictureBox1.Image = pics[los];
            correctImgWithCode = los;

        }
    }
}
