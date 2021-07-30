/*Lee J Noel

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A12LeeJNoel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ScrambleBTN_Click(object sender, EventArgs e)
        {
            string Word1, Word2, Word3, Word4;
                Word1 = WordBox1.Text;  // Word entered in TextBox 1
                Word2 = WordBox2.Text;  // Word entered in TextBox 2
                Word3 = WordBox3.Text;  // Word entered in TextBox 3
                Word4 = WordBox4.Text;  // Word entered in TextBox 4

            WordBox1.Text = Word4;  //Swpas Word from textbox 1 with word from text box 4
            WordBox2.Text = Word3;  //Swpas Word from textbox 1 with word from text box 4
            WordBox3.Text = Word2;  //Swpas Word from textbox 1 with word from text box 4
            WordBox4.Text = Word1;  //Swpas Word from textbox 1 with word from text box 4
        }
    }
}
