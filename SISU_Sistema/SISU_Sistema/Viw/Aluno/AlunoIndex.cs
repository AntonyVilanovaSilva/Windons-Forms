using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISU_Sistema.Viw.Aluno
{
    public partial class AlunoIndex : Form
    {
        public AlunoIndex()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listnome.Items.Add(txt.Text + "  |  " + Text.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Alunos.txt");

            foreach (ListViewItem item in listnome.Items)
            {
                sw.WriteLine(item.Text);
            }

            sw.Close(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //System.IO.FileNotFoundException
            StreamWriter sw = new StreamWriter("Alunos.txt");
            sw.Flush();
            sw.Close();
            listnome.Clear();


            try
            {
                StreamReader sr = new StreamReader("Alunos.txt");

                string linha = sr.ReadLine();
                while (linha != null)
                {
                    listnome.Items.Add(linha);
                    linha = sr.ReadLine();
                }
                sr.Close();
            }
            catch (System.IO.FileNotFoundException ex)
            {

                MessageBox.Show("Error");
            }
        } 
        
    }
}
