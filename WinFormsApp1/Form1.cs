using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

            string text = textBox1.Text;
            char[] array = text.ToCharArray();
            int s = 0;
            double pr;
            if (textBox1.Text != "" )
                {
                for (int i = 0; i < array.Length; i++)
                {
                    if (Char.IsLetter(array[i]))
                    {
                        ++s;
                    }

                }
                pr = ((double)s / array.Length);
                pr = pr * 100;

                MessageBox.Show($"{pr} % процентов"); 
            }
            else { MessageBox.Show($"Строка пуста!!!!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(textBox1.Text);
                streamWriter.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText("E:\\text.txt");

        }
    }
}
