using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonProses_Click(object sender, EventArgs e)
        {            
                                 
            if (textBoxNama.Text == "DELETE")
            {
                label1.Text = "[EMPTY]";
            }            
            else if (textBoxNama.Text == "SHOWN")
            {
                label1.Visible = true;               
            }
            else if (textBoxNama.Text == "HIDE")
            {
                label1.Visible = false;
            }
            else if (textBoxNama.Text == "BLUE")
            {
                label1.ForeColor = Color.Blue;
            }
            else if (textBoxNama.Text == "RED")
            {
                label1.ForeColor = Color.Red;
            }
            else if (textBoxNama.Text == "GREEN")
            {
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.Text = textBoxNama.Text;
            }
            textBoxNama.Text = "";
        }

        private void textBoxNama_KeyDown(object sender, KeyEventArgs e)
        {
            //if (textBoxNama.Text != "DELETE" || "SHOWN")
            //if (e.KeyCode == Keys.Enter)
            //{
            //    buttonProses_Click(sender, e);
            //    textBoxNama.Text = " ";
            //}
        }
    }
}
