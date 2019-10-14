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
    public partial class Startwindow : Form
    {
        //boolean zum zweck des Bildwechsels beim klicken
        int counter = 0;
        bool x;

        
        int[,] array = new int[3, 3];
        bool playerwon = false;
        bool fixngbugs = true;
        bool esistdran = false;


        public Startwindow()
        {
            InitializeComponent();
            player1namae.Text = startmenu.name;
            player2name.Text = startmenu.name2;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Hier wird das Bild zu einem haken oder einem x geändert, sobald auf das Feld geklickt wird.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Das Feld "TICK1", dort soll das Bild geändert werden, je nachdem welcher Boolean ein x oder ein haken.
            changeimage(Tick1, 0, 0);

            /* "StetchImage" sorgt  dafür, 
            dass das Bild das ganze Feld befüllt. */
            Tick1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        /// <summary>
        /// Hier wird bei klicken auf eines der Felder eine veränderte Image erzeugt, welche bewirkt, dass ein x oder ein tick bild erscheint.
        /// </summary>
        /// <param name="px"></param>

        private void changeimage(PictureBox px, int zahl1, int zahl2)
        {


            if (counter >= 8 && fixngbugs == true)
            {
                loser.Visible = true;



            }
            else
            {
                counter++;

                if (x)
                {

                    //Bild wird hereingeladen

                    px.Image = Image.FromFile(@"C:\Users\DennisS\source\repos\TicTacToe\TicTacToe\Resources\x.png");
                    array[zahl1, zahl2] = 1;
                    //boolean wird wieder auf falsch gesetzt, damit es in else geht und dort mit dem haken weitermacht
                    x = false;
                    esistdran = true;

                }
                else
                {

                    px.Image = Image.FromFile(@"C:\Users\DennisS\source\repos\TicTacToe\TicTacToe\Resources\tick.png");
                    //boolean wird auf true gesetzt, damit es wieder in if geht, und dort wieder mit einem x bild weiterzumachen.
                    x = true;
                    array[zahl1, zahl2] = 2;
                    esistdran = true;

                }
                if (array[0, 0] == array[0, 1] && array[0, 2] == array[0, 1] && array[0, 1] > 0)
                {
                    Spielerdran.Visible = false;
                    esistdrantext1.Visible = false;
                    esistdrantext2.Visible = false;
                    counter = 8;
                    playerwon = true;

                }
                if (array[1, 0] == array[1, 1] && array[1, 2] == array[1, 1] && array[1, 1] > 0)
                {
                    Spielerdran.Visible = false;
                    esistdrantext1.Visible = false;
                    esistdrantext2.Visible = false;
                    counter = 8;
                    playerwon = true;
                }
                if (array[2, 0] == array[2, 1] && array[2, 2] == array[2, 1] && array[2, 1] > 0)
                {
                    Spielerdran.Visible = false;
                    esistdrantext1.Visible = false;
                    esistdrantext2.Visible = false;
                    counter = 8;
                    playerwon = true;
                }
                if (array[0, 0] == array[1, 0] && array[2, 0] == array[1, 0] && array[1, 0] > 0)
                {
                    Spielerdran.Visible = false;
                    esistdrantext1.Visible = false;
                    esistdrantext2.Visible = false;
                    playerwon = true;
                    counter = 8;
                }
                if (array[0, 1] == array[1, 1] && array[2, 1] == array[1, 1] && array[1, 1] > 0)
                {
                    Spielerdran.Visible = false;
                    esistdrantext1.Visible = false;
                    esistdrantext2.Visible = false;
                    playerwon = true;
                    counter = 8;
                }
                if (array[0, 2] == array[1, 2] && array[2, 2] == array[1, 2] && array[1, 2] > 0)
                {
                    Spielerdran.Visible = false;
                    esistdrantext1.Visible = false;
                    esistdrantext2.Visible = false;
                    playerwon = true;
                    counter = 8;
                }
                if (array[0, 2] == array[1, 1] && array[2, 0] == array[1, 1] && array[1, 1] > 0)
                {
                    Spielerdran.Visible = false;
                    esistdrantext1.Visible = false;
                    esistdrantext2.Visible = false;
                    playerwon = true;
                    counter = 8;
                }
                if (array[0, 0] == array[1, 1] && array[2, 2] == array[1, 1] && array[1, 1] > 0)
                {
                    Spielerdran.Visible = false;
                    esistdrantext1.Visible = false;
                    esistdrantext2.Visible = false;
                    playerwon = true;
                    counter = 8;
                }

                //Das sorgt dafür, dass wenn das Bild einmal geklickt wurde, das Bild sich nicht nocheinmal ändern kann und so bleibt.
                px.Enabled = false;


                if (x && esistdran == true && playerwon == false)
                {
                    esistdrantext1.Visible = true;
                    esistdrantext2.Visible = true;
                    Spielerdran.Text = startmenu.name2;
                }
                if (x == false && esistdran == true)
                {
                    esistdrantext1.Visible = true;
                    esistdrantext2.Visible = true;
                    Spielerdran.Text = startmenu.name;
                }






                if (playerwon == true)

                {
                    if (x == false)
                    {

                        winnername.Visible = true;
                        winnername.Text = startmenu.name2;
                        fixngbugs = false;
                        esistdran = false; gewinnermessage.Visible = true;
                    }
                    if (x == true)
                    {
                        esistdran = false;
                        winnername.Visible = true;
                        winnername.Text = startmenu.name;
                        gewinnermessage.Visible = true; fixngbugs = false;
                    }




                }



            }
        }


        private void Tick2_Click(object sender, EventArgs e)
        {




            changeimage(Tick2, 0, 1);
            Tick2.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void Tick3_Click(object sender, EventArgs e)
        {

            changeimage(Tick3, 0, 2);
            Tick3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Tick4_Click(object sender, EventArgs e)
        {
            changeimage(Tick4, 1, 0);
            Tick4.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Tick5_Click(object sender, EventArgs e)
        {
            changeimage(Tick5, 1, 1);
            Tick5.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Tick6_Click(object sender, EventArgs e)
        {
            changeimage(Tick6, 1, 2);
            Tick6.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Tick7_Click(object sender, EventArgs e)
        {
            changeimage(Tick7, 2, 0);
            Tick7.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Tick8_Click(object sender, EventArgs e)
        {
            changeimage(Tick8, 2, 1);
            Tick8.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Tick9_Click(object sender, EventArgs e)
        {
            changeimage(Tick9, 2, 2);
            Tick9.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
