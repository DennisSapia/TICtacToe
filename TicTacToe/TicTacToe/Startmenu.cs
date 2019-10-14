using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class startmenu : Form
    {
        public static string name, name2;
        public startmenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!= "" && textBox2.Text!="")
            {   
                name = textBox1.Text;
                name2 = textBox2.Text;
                Cheatmode ob2 = new Cheatmode();
                ob2.Show();
                this.Hide();
                
            }
            else
            {
                Errorusername.Visible = true;
            }

        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                name = textBox1.Text;
                name2 = textBox2.Text;
                this.Hide();
                Startwindow ob = new Startwindow();
                ob.Show();

            }
            else
            {
                Errorusername.Visible = true;
            }
        }
    }
}
