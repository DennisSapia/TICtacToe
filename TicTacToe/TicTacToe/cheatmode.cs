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
    public partial class Cheatmode : Form
    {
        bool gewinner = false;
        int counter = 0;
        bool x;
        

        int[,] array = new int[3, 3];

        public Cheatmode()
        {
            InitializeComponent();
            playername1.Text = startmenu.name2;
            playername2.Text = startmenu.name;
        }

        private void changepicture(PictureBox picbox)
        {
           



            if (counter >= 6)
            {
                

            }
            else
            {



                if (x)
                {
                    //Bild wird hereingeladen
                    picbox.Image = Image.FromFile(@"C:\Users\DennisS\source\repos\TicTacToe\TicTacToe\Resources\Anonymous-Mask-PNG-Image.png");
                    //boolean wird wieder auf falsch gesetzt, damit es in else geht und dort mit dem haken weitermacht
                    x = false;
                }
                else
                {

                    picbox.Image = Image.FromFile(@"C:\Users\DennisS\source\repos\TicTacToe\TicTacToe\Resources\x.png");
                    //boolean wird auf true gesetzt, damit es wieder in if geht, und dort wieder mit einem x bild weiterzumachen.
                    x = true;



                }
                if (array[0, 0] == array[0, 1] && array[0, 2] == array[0, 1] && array[0, 1] > 0)
                {
                    gewinner = true;
                    counter = 15;


                }
                if (array[1, 0] == array[1, 1] && array[1, 2] == array[1, 1] && array[1, 1] > 0)
                {
                    gewinner = true;
                    counter = 15;

                }
                if (array[2, 0] == array[2, 1] && array[2, 2] == array[2, 1] && array[2, 1] > 0)
                {
                    gewinner = true;
                    counter = 15;

                }
                if (array[0, 0] == array[1, 0] && array[2, 0] == array[1, 0] && array[1, 0] > 0)
                {

                    gewinner = true;
                    counter = 15;
                }
                if (array[0, 1] == array[1, 1] && array[2, 1] == array[1, 1] && array[1, 1] > 0)
                {

                    gewinner = true;
                    counter = 15;
                }
                if (array[0, 2] == array[1, 2] && array[2, 2] == array[1, 2] && array[1, 2] > 0)
                {

                    gewinner = true;
                    counter = 15;
                }
                if (array[0, 2] == array[1, 1] && array[2, 0] == array[1, 1] && array[1, 1] > 0)
                {

                    gewinner = true;
                    counter = 15;
                }
                if (array[0, 0] == array[1, 1] && array[2, 2] == array[1, 1] && array[1, 1] > 0)
                {
                    gewinner = true;
                    counter = 15;
                }

                counter++;
                if (counter >= 6)
                {

                    Test.Visible = true;
                }

                if ( gewinner == true)
                {
                    Gewinnernachricht.Visible = true;
                }

                //Das sorgt dafür, dass wenn das Bild einmal geklickt wurde, das Bild sich nicht nocheinmal ändern kann und so bleibt.
                picbox.Enabled = false;

            }



        }
        private void feld1_Click(object sender, EventArgs e)
        {
            changepicture(feld1);
            feld1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void feld2_Click(object sender, EventArgs e)
        {
            changepicture(feld2);
            feld2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Feld3_Click(object sender, EventArgs e)
        {
            changepicture(Feld3);
            Feld3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Feld4_Click(object sender, EventArgs e)
        {
            changepicture(Feld4);
            Feld4.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Feld5_Click(object sender, EventArgs e)
        {
            changepicture(Feld5);
            Feld5.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Feld6_Click(object sender, EventArgs e)
        {
            changepicture(Feld6);
            Feld6.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Feld7_Click(object sender, EventArgs e)
        {
            changepicture(Feld7);
            Feld7.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Feld8_Click(object sender, EventArgs e)
        {
            changepicture(Feld8);
            Feld8.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Feld9_Click(object sender, EventArgs e)
        {
            changepicture(Feld9);
            Feld9.SizeMode = PictureBoxSizeMode.StretchImage;
        }

    }
}


