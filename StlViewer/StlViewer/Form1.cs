using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.Platform.Windows;
using StlReader;

namespace StlViewer
{
    public partial class Form1 : Form
    {
        OpenFileDialog FD = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
            Sidepanel.Height = button2.Height;
            Sidepanel.Top = button2.Top;
            startseite1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Sidepanel.Height = button2.Height;
            Sidepanel.Top = button2.Top;
            startseite1.BringToFront();
        }

        private void startseite1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button3.Height;
            Sidepanel.Top = button3.Top;
            entwicklerseite1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button4.Height;
            Sidepanel.Top = button4.Top;
            Environment.Exit(0);
        }

        private void startseite1_Load_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button5.Height;
            Sidepanel.Top = button5.Top;
            hilfe1.BringToFront();
        }
    }
}
