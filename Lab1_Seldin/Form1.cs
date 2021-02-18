using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Seldin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void START_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                textBox1.Text = Module1.InsertLastLetterToTheBeginning(textBox1.Text);
            }
            else
            {
                MessageBox.Show(" TextBox is empty! ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                textBox1.Text = Module1.DeleteDuplicateLetters(textBox1.Text);
            }
            else
            {
                MessageBox.Show(" TextBox is empty! ");
            }
        }
    }
}
