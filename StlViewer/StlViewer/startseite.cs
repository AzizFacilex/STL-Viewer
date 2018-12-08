using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StlReader;
namespace StlViewer
{
    public partial class startseite : UserControl
    {
        OpenFileDialog FD = new OpenFileDialog();
        public startseite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FD.ShowDialog() == DialogResult.OK)
            {
                FileName.Text = FD.FileName;
                Safefilename.Text = FD.SafeFileName;
            }
        }

        private void Bestaetigen_Click(object sender, EventArgs e)
        {
            Linelist Lin = new Linelist();
            Surfacelist lists = new Surfacelist();
            string path = FileName.Text;
            Pointlist L = new Pointlist();
            Linelist List_line = new Linelist();
            Normal_Vectors vect = new Normal_Vectors();
            if (vect.IS_ASCII(path))
            {
                MessageBox.Show("the ASCII File is Oppening");
                vect.ASCII_Reader(vect, L, Lin, lists, path);
            }
            else
            {
                MessageBox.Show("The Binary File is Oppening ");
                double h = vect.Bin_Reader(vect, L, Lin, lists, path);

            }

            //List_line = L.Line_construction();
            //  if (List_line.IstVollständig() == null)
            //{ MessageBox.Show("all components are complete"); }
            //else MessageBox.Show("there is a mistake in there");
            this.Hide();
            Objekt Obj = new Objekt(L, vect, comboBox1);
            Obj.ShowDialog();
        }

        private void FileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void startseite_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
