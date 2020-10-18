using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISMancalaV1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            

            InitializeComponent();

            int [,] iSpot = new int[2, 6];
            for(int i=0; i<6; i++)
            {
                iSpot[1, i] = 4;
                iSpot[0, i] = 4;
            }
            Board board = new Board(iSpot, 0, 0, true);
            board.restartBoard();

            int cnt = 1;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    var pb = new PictureBox();
                    pb.Name = "pictureBox" + cnt;
                    pb.Tag = "" + j + "" + i;
                    int x = 130 + (130 * i);
                    int y = 40 + (130 * j);
                    pb.Location = new Point(x, y);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.BorderStyle = BorderStyle.FixedSingle;
                    pb.Image = global::ISMancalaV1.Properties.Resources.fourball;
                    pb.Click += new EventHandler(pictureBox_Click);
                    this.Controls.Add(pb);
                    cnt++;

                }
            }

            for(int i=0;i<2;i++)
            {
                var pb = new PictureBox();
                pb.Name = "pictureBox" +11+""+ i;
                pb.Tag = "turn" + i;
                int x = 445;
                int y = 330 + 60 * i;
                pb.Location = new Point(x, y);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.BorderStyle = BorderStyle.None;
                if(i==0)
                {
                    pb.Image = global::ISMancalaV1.Properties.Resources.Playerturn;
                }
                else
                {
                    pb.Image = global::ISMancalaV1.Properties.Resources.green;
                }
                this.Controls.Add(pb);

            }
            for(int i=0; i<2;i++)
            {
                for(int j=0;j<2;j++)
                {

                    var pb = new PictureBox();
                    pb.Name = "pictureBox" + i + "" + j;
                    pb.Tag = "points" + i + "" + j;
                    int x = 20 +870 * i;
                    int y = 70 + 70 * j;
                    pb.Location = new Point(x, y);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.BorderStyle = BorderStyle.None;
                    pb.Image = global::ISMancalaV1.Properties.Resources.blank;
                    this.Controls.Add(pb);
                    

                }
            }
                
     
            
            void pictureBox_Click(object sender, EventArgs e)
            {
                PictureBox pb = (PictureBox)sender;
                int y = int.Parse("" + pb.Tag.ToString()[0]);
                int x = int.Parse("" + pb.Tag.ToString()[1]);
                if(board.turn==true&&y==1 || board.turn==false&&y==0)
                {
                    board.Movement(x, y);
                }
             
                

                if (board.playerPoints > 24)
                {
                    MessageBox.Show("The 1st player has won");
                    board.restartBoard();
                }
                if (board.pcPoints > 24)
                {
                    MessageBox.Show("The 2nd player has won");
                    board.restartBoard();
                }



                foreach (Control c in this.Controls)
                {
                    if (c.GetType().Name == "PictureBox")
                    {
                        
                       if(c.Tag.Equals("turn1"))
                        {
                            PictureBox turn = (PictureBox)c;
                            if(board.turn==true)
                            {
                                turn.Image = global::ISMancalaV1.Properties.Resources.green;
                            }
                            else
                            {
                                turn.Image = global::ISMancalaV1.Properties.Resources.red;
                            }
                        }

                        if (c.Tag.Equals("00"))
                        {
                            
                            PictureBox picBox = (PictureBox)c;
                            if(board.itemsInSpot[0,0]==0)
                            {
                                picBox.Image = null;
                            }
                            if (board.itemsInSpot[0, 0] == 1)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.oneBall;
                            }
                            if (board.itemsInSpot[0, 0] == 2)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.twoBall;
                            }
                            if (board.itemsInSpot[0, 0] == 3)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.threeball;
                            }
                            if (board.itemsInSpot[0, 0] == 4)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.fourball;
                            }
                            if (board.itemsInSpot[0, 0] == 5)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.fiveball;
                            }
                            if (board.itemsInSpot[0, 0] == 6)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.six;
                            }
                            if (board.itemsInSpot[0, 0] == 7)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.seven;
                            }
                            if (board.itemsInSpot[0, 0] == 8)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.eight;
                            }
                            if (board.itemsInSpot[0, 0] == 9)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.nine;
                            }
                            if (board.itemsInSpot[0, 0] == 10)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.ten;
                            }
                            if (board.itemsInSpot[0, 0] == 11)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.eleven;
                            }
                            if (board.itemsInSpot[0, 0] == 12)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.twelve;
                            }
                            if (board.itemsInSpot[0, 0] == 13)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.thirteen;
                            }
                            if (board.itemsInSpot[0, 0] == 14)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.fourteen;
                            }
                            if (board.itemsInSpot[0, 0] == 15)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.fifteen;
                            }
                            if (board.itemsInSpot[0, 0] == 16)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.sixteen;
                            }
                            if (board.itemsInSpot[0, 0] == 17)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.seventeen;
                            }
                            if (board.itemsInSpot[0, 0] == 18)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.eighteen;
                            }
                            if (board.itemsInSpot[0, 0] == 19)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.nineteen;
                            }
                            if (board.itemsInSpot[0, 0] == 20)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.twenty;
                            }
                            if (board.itemsInSpot[0, 0] == 21)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.twentyone;
                            }
                            if (board.itemsInSpot[0, 0] == 22)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.twentytwo;
                            }
                            if (board.itemsInSpot[0, 0] == 23)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.twentythree;
                            }
                            if (board.itemsInSpot[0, 0] == 24)
                            {
                                picBox.Image = global::ISMancalaV1.Properties.Resources.twentyfour;
                            }
                        }
                        if (c.Tag.Equals("01"))
                        {
                            PictureBox picBox1 = (PictureBox)c;
                            if (board.itemsInSpot[0, 1] == 0)
                            {
                                picBox1.Image = null;
                            }
                            if (board.itemsInSpot[0, 1] == 1)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.oneBall;
                            }
                            if (board.itemsInSpot[0, 1] == 2)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.twoBall;
                            }
                            if (board.itemsInSpot[0, 1] == 3)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.threeball;
                            }
                            if (board.itemsInSpot[0, 1] == 4)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.fourball;
                            }
                            if (board.itemsInSpot[0, 1] == 5)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.fiveball;
                            }
                            if (board.itemsInSpot[0, 1] == 6)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.six;
                            }
                            if (board.itemsInSpot[0, 1] == 7)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.seven;
                            }
                            if (board.itemsInSpot[0, 1] == 8)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.eight;
                            }
                            if (board.itemsInSpot[0, 1] == 9)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.nine;
                            }
                            if (board.itemsInSpot[0, 1] == 10)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.ten;
                            }
                            if (board.itemsInSpot[0, 1] == 11)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.eleven;
                            }
                            if (board.itemsInSpot[0, 1] == 12)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.twelve;
                            }
                            if (board.itemsInSpot[0, 1] == 13)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.thirteen;
                            }
                            if (board.itemsInSpot[0, 1] == 14)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.fourteen;
                            }
                            if (board.itemsInSpot[0, 1] == 15)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.fifteen;
                            }
                            if (board.itemsInSpot[0, 1] == 16)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.sixteen;
                            }
                            if (board.itemsInSpot[0, 1] == 17)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.seventeen;
                            }
                            if (board.itemsInSpot[0, 1] == 18)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.eighteen;
                            }
                            if (board.itemsInSpot[0, 1] == 19)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.nineteen;
                            }
                            if (board.itemsInSpot[0, 1] == 20)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.twenty;
                            }
                            if (board.itemsInSpot[0, 1] == 21)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.twentyone;
                            }
                            if (board.itemsInSpot[0, 1] == 22)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.twentytwo;
                            }
                            if (board.itemsInSpot[0, 1] == 23)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.twentythree;
                            }
                            if (board.itemsInSpot[0, 1] == 24)
                            {
                                picBox1.Image = global::ISMancalaV1.Properties.Resources.twentyfour;
                            }
                        }
                        if (c.Tag.Equals("02"))
                        {
                            PictureBox picBox3 = (PictureBox)c;
                            if (board.itemsInSpot[0, 2] == 0)
                            {
                                picBox3.Image = null;
                            }
                            if (board.itemsInSpot[0, 2] == 1)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.oneBall;
                            }
                            if (board.itemsInSpot[0, 2] == 2)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.twoBall;
                            }
                            if (board.itemsInSpot[0, 2] == 3)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.threeball;
                            }
                            if (board.itemsInSpot[0, 2] == 4)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.fourball;
                            }
                            if (board.itemsInSpot[0, 2] == 5)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.fiveball;
                            }
                            if (board.itemsInSpot[0, 2] == 6)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.six;
                            }
                            if (board.itemsInSpot[0, 2] == 7)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.seven;
                            }
                            if (board.itemsInSpot[0, 2] == 8)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.eight;
                            }
                            if (board.itemsInSpot[0, 2] == 9)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.nine;
                            }
                            if (board.itemsInSpot[0, 2] == 10)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.ten;
                            }
                            if (board.itemsInSpot[0, 2] == 11)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.eleven;
                            }
                            if (board.itemsInSpot[0, 2] == 12)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.twelve;
                            }
                            if (board.itemsInSpot[0, 2] == 13)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.thirteen;
                            }
                            if (board.itemsInSpot[0, 2] == 14)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.fourteen;
                            }
                            if (board.itemsInSpot[0, 2] == 15)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.fifteen;
                            }
                            if (board.itemsInSpot[0, 2] == 16)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.sixteen;
                            }
                            if (board.itemsInSpot[0, 2] == 17)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.seventeen;
                            }
                            if (board.itemsInSpot[0, 2] == 18)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.eighteen;
                            }
                            if (board.itemsInSpot[0, 2] == 19)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.nineteen;
                            }
                            if (board.itemsInSpot[0, 2] == 20)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.twenty;
                            }
                            if (board.itemsInSpot[0, 2] == 21)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.twentyone;
                            }
                            if (board.itemsInSpot[0, 2] == 22)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.twentytwo;
                            }
                            if (board.itemsInSpot[0, 2] == 23)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.twentythree;
                            }
                            if (board.itemsInSpot[0, 2] == 24)
                            {
                                picBox3.Image = global::ISMancalaV1.Properties.Resources.twentyfour;
                            }
                        }
                        if (c.Tag.Equals("03"))
                        {
                            PictureBox picBox4 = (PictureBox)c;
                            if (board.itemsInSpot[0, 3] == 0)
                            {
                                picBox4.Image = null;
                            }
                            if (board.itemsInSpot[0, 3] == 1)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.oneBall;
                            }
                            if (board.itemsInSpot[0, 3] == 2)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.twoBall;
                            }
                            if (board.itemsInSpot[0, 3] == 3)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.threeball;
                            }
                            if (board.itemsInSpot[0, 3] == 4)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.fourball;
                            }
                            if (board.itemsInSpot[0, 3] == 5)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.fiveball;
                            }
                            if (board.itemsInSpot[0, 3] == 6)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.six;
                            }
                            if (board.itemsInSpot[0, 3] == 7)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.seven;
                            }
                            if (board.itemsInSpot[0, 3] == 8)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.eight;
                            }
                            if (board.itemsInSpot[0, 3] == 9)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.nine;
                            }
                            if (board.itemsInSpot[0, 3] == 10)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.ten;
                            }
                            if (board.itemsInSpot[0, 3] == 11)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.eleven;
                            }
                            if (board.itemsInSpot[0, 3] == 12)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.twelve;
                            }
                            if (board.itemsInSpot[0, 3] == 13)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.thirteen;
                            }
                            if (board.itemsInSpot[0, 3] == 14)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.fourteen;
                            }
                            if (board.itemsInSpot[0, 3] == 15)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.fifteen;
                            }
                            if (board.itemsInSpot[0, 3] == 16)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.sixteen;
                            }
                            if (board.itemsInSpot[0, 3] == 17)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.seventeen;
                            }
                            if (board.itemsInSpot[0, 3] == 18)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.eighteen;
                            }
                            if (board.itemsInSpot[0, 3] == 19)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.nineteen;
                            }
                            if (board.itemsInSpot[0, 3] == 20)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.twenty;
                            }
                            if (board.itemsInSpot[0, 3] == 21)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.twentyone;
                            }
                            if (board.itemsInSpot[0, 3] == 22)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.twentytwo;
                            }
                            if (board.itemsInSpot[0, 3] == 23)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.twentythree;
                            }
                            if (board.itemsInSpot[0, 3] == 24)
                            {
                                picBox4.Image = global::ISMancalaV1.Properties.Resources.twentyfour;
                            }
                        }

                        if (c.Tag.Equals("04"))
                        {
                            PictureBox picBox5 = (PictureBox)c;
                            if (board.itemsInSpot[0, 4] == 0)
                            {
                                picBox5.Image = null;
                            }
                            if (board.itemsInSpot[0, 4] == 1)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.oneBall;
                            }
                            if (board.itemsInSpot[0, 4] == 2)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.twoBall;
                            }
                            if (board.itemsInSpot[0, 4] == 3)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.threeball;
                            }
                            if (board.itemsInSpot[0, 4] == 4)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.fourball;
                            }
                            if (board.itemsInSpot[0, 4] == 5)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.fiveball;
                            }
                            if (board.itemsInSpot[0, 4] == 6)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.six;
                            }
                            if (board.itemsInSpot[0, 4] == 7)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.seven;
                            }
                            if (board.itemsInSpot[0, 4] == 8)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.eight;
                            }
                            if (board.itemsInSpot[0, 4] == 9)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.nine;
                            }
                            if (board.itemsInSpot[0, 4] == 10)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.ten;
                            }
                            if (board.itemsInSpot[0, 4] == 11)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.eleven;
                            }
                            if (board.itemsInSpot[0, 4] == 12)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.twelve;
                            }
                            if (board.itemsInSpot[0, 4] == 13)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.thirteen;
                            }
                            if (board.itemsInSpot[0, 4] == 14)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.fourteen;
                            }
                            if (board.itemsInSpot[0, 4] == 15)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.fifteen;
                            }
                            if (board.itemsInSpot[0, 4] == 16)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.sixteen;
                            }
                            if (board.itemsInSpot[0, 4] == 17)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.seventeen;
                            }
                            if (board.itemsInSpot[0, 4] == 18)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.eighteen;
                            }
                            if (board.itemsInSpot[0, 4] == 19)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.nineteen;
                            }
                            if (board.itemsInSpot[0, 4] == 20)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.twenty;
                            }
                            if (board.itemsInSpot[0, 4] == 21)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.twentyone;
                            }
                            if (board.itemsInSpot[0, 4] == 22)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.twentytwo;
                            }
                            if (board.itemsInSpot[0, 4] == 23)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.twentythree;
                            }
                            if (board.itemsInSpot[0, 4] == 24)
                            {
                                picBox5.Image = global::ISMancalaV1.Properties.Resources.twentyfour;
                            }
                        }

                        if (c.Tag.Equals("05"))
                        {
                            PictureBox picBox6 = (PictureBox)c;
                            if (board.itemsInSpot[0, 5] == 0)
                            {
                                picBox6.Image = null;
                            }
                            if (board.itemsInSpot[0, 5] == 1)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.oneBall;
                            }
                            if (board.itemsInSpot[0, 5] == 2)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.twoBall;
                            }
                            if (board.itemsInSpot[0, 5] == 3)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.threeball;
                            }
                            if (board.itemsInSpot[0, 5] == 4)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.fourball;
                            }
                            if (board.itemsInSpot[0, 5] == 5)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.fiveball;
                            }
                            if (board.itemsInSpot[0, 5] == 6)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.six;
                            }
                            if (board.itemsInSpot[0, 5] == 7)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.seven;
                            }
                            if (board.itemsInSpot[0, 5] == 8)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.eight;
                            }
                            if (board.itemsInSpot[0, 5] == 9)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.nine;
                            }
                            if (board.itemsInSpot[0, 5] == 10)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.ten;
                            }
                            if (board.itemsInSpot[0, 5] == 11)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.eleven;
                            }
                            if (board.itemsInSpot[0, 5] == 12)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.twelve;
                            }
                            if (board.itemsInSpot[0, 5] == 13)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.thirteen;
                            }
                            if (board.itemsInSpot[0, 5] == 14)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.fourteen;
                            }
                            if (board.itemsInSpot[0, 5] == 15)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.fifteen;
                            }
                            if (board.itemsInSpot[0, 5] == 16)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.sixteen;
                            }
                            if (board.itemsInSpot[0, 5] == 17)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.seventeen;
                            }
                            if (board.itemsInSpot[0, 5] == 18)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.eighteen;
                            }
                            if (board.itemsInSpot[0, 5] == 19)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.nineteen;
                            }
                            if (board.itemsInSpot[0, 5] == 20)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.twenty;
                            }
                            if (board.itemsInSpot[0, 5] == 21)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.twentyone;
                            }
                            if (board.itemsInSpot[0, 5] == 22)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.twentytwo;
                            }
                            if (board.itemsInSpot[0, 5] == 23)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.twentythree;
                            }
                            if (board.itemsInSpot[0, 5] == 24)
                            {
                                picBox6.Image = global::ISMancalaV1.Properties.Resources.twentyfour;
                            }
                        }

                        if (c.Tag.Equals("10"))
                        {
                            PictureBox picBox7 = (PictureBox)c;
                            if (board.itemsInSpot[1, 0] == 0)
                            {
                                picBox7.Image = null;
                            }
                            if (board.itemsInSpot[1, 0] == 1)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.oneBall;
                            }
                            if (board.itemsInSpot[1, 0] == 2)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.twoBall;
                            }
                            if (board.itemsInSpot[1, 0] == 3)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.threeball;
                            }
                            if (board.itemsInSpot[1, 0] == 4)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.fourball;
                            }
                            if (board.itemsInSpot[1, 0] == 5)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.fiveball;
                            }
                            if (board.itemsInSpot[1, 0] == 6)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.six;
                            }
                            if (board.itemsInSpot[1, 0] == 7)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.seven;
                            }
                            if (board.itemsInSpot[1, 0] == 8)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.eight;
                            }
                            if (board.itemsInSpot[1, 0] == 9)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.nine;
                            }
                            if (board.itemsInSpot[1, 0] == 10)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.ten;
                            }
                            if (board.itemsInSpot[1, 0] == 11)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.eleven;
                            }
                            if (board.itemsInSpot[1, 0] == 12)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.twelve;
                            }
                            if (board.itemsInSpot[1, 0] == 13)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.thirteen;
                            }
                            if (board.itemsInSpot[1, 0] == 14)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.fourteen;
                            }
                            if (board.itemsInSpot[1, 0] == 15)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.fifteen;
                            }
                            if (board.itemsInSpot[1, 0] == 16)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.sixteen;
                            }
                            if (board.itemsInSpot[1, 0] == 17)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.seventeen;
                            }
                            if (board.itemsInSpot[1, 0] == 18)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.eighteen;
                            }
                            if (board.itemsInSpot[1, 0] == 19)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.nineteen;
                            }
                            if (board.itemsInSpot[1, 0] == 20)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.twenty;
                            }
                            if (board.itemsInSpot[1, 0] == 21)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.twentyone;
                            }
                            if (board.itemsInSpot[1, 0] == 22)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.twentytwo;
                            }
                            if (board.itemsInSpot[1, 0] == 23)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.twentythree;
                            }
                            if (board.itemsInSpot[1, 0] == 24)
                            {
                                picBox7.Image = global::ISMancalaV1.Properties.Resources.twentyfour;
                            }
                        }
                        if (c.Tag.Equals("11"))
                        {
                            PictureBox picBox8 = (PictureBox)c;
                            if (board.itemsInSpot[1, 1] == 0)
                            {
                                picBox8.Image = null;
                            }
                            if (board.itemsInSpot[1, 1] == 1)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.oneBall;
                            }
                            if (board.itemsInSpot[1, 1] == 2)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.twoBall;
                            }
                            if (board.itemsInSpot[1, 1] == 3)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.threeball;
                            }
                            if (board.itemsInSpot[1, 1] == 4)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.fourball;
                            }
                            if (board.itemsInSpot[1, 1] == 5)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.fiveball;
                            }
                            if (board.itemsInSpot[1, 1] == 6)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.six;
                            }
                            if (board.itemsInSpot[1, 1] == 7)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.seven;
                            }
                            if (board.itemsInSpot[1, 1] == 8)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.eight;
                            }
                            if (board.itemsInSpot[1, 1] == 9)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.nine;
                            }
                            if (board.itemsInSpot[1, 1] == 10)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.ten;
                            }
                            if (board.itemsInSpot[1, 1] == 11)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.eleven;
                            }
                            if (board.itemsInSpot[1, 1] == 12)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.twelve;
                            }
                            if (board.itemsInSpot[1, 1] == 13)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.thirteen;
                            }
                            if (board.itemsInSpot[1, 1] == 14)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.fourteen;
                            }
                            if (board.itemsInSpot[1, 1] == 15)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.fifteen;
                            }
                            if (board.itemsInSpot[1, 1] == 16)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.sixteen;
                            }
                            if (board.itemsInSpot[1, 1] == 17)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.seventeen;
                            }
                            if (board.itemsInSpot[1, 1] == 18)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.eighteen;
                            }
                            if (board.itemsInSpot[1, 1] == 19)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.nineteen;
                            }
                            if (board.itemsInSpot[1, 1] == 20)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.twenty;
                            }
                            if (board.itemsInSpot[1, 1] == 21)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.twentyone;
                            }
                            if (board.itemsInSpot[1, 1] == 22)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.twentytwo;
                            }
                            if (board.itemsInSpot[1, 1] == 23)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.twentythree;
                            }
                            if (board.itemsInSpot[1, 1] == 24)
                            {
                                picBox8.Image = global::ISMancalaV1.Properties.Resources.twentyfour;
                            }
                        }
                        if (c.Tag.Equals("12"))
                        {
                            PictureBox picBox9 = (PictureBox)c;
                            if (board.itemsInSpot[1, 2] == 0)
                            {
                                picBox9.Image = null;
                            }
                            if (board.itemsInSpot[1, 2] == 1)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.oneBall;
                            }
                            if (board.itemsInSpot[1, 2] == 2)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.twoBall;
                            }
                            if (board.itemsInSpot[1, 2] == 3)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.threeball;
                            }
                            if (board.itemsInSpot[1, 2] == 4)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.fourball;
                            }
                            if (board.itemsInSpot[1, 2] == 5)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.fiveball;
                            }
                            if (board.itemsInSpot[1, 2] == 6)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.six;
                            }
                            if (board.itemsInSpot[1, 2] == 7)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.seven;
                            }
                            if (board.itemsInSpot[1, 2] == 8)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.eight;
                            }
                            if (board.itemsInSpot[1, 2] == 9)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.nine;
                            }
                            if (board.itemsInSpot[1, 2] == 10)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.ten;
                            }
                            if (board.itemsInSpot[1, 2] == 11)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.eleven;
                            }
                            if (board.itemsInSpot[1, 2] == 12)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.twelve;
                            }
                            if (board.itemsInSpot[1, 2] == 13)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.thirteen;
                            }
                            if (board.itemsInSpot[1, 2] == 14)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.fourteen;
                            }
                            if (board.itemsInSpot[1, 2] == 15)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.fifteen;
                            }
                            if (board.itemsInSpot[1, 2] == 16)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.sixteen;
                            }
                            if (board.itemsInSpot[1, 2] == 17)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.seventeen;
                            }
                            if (board.itemsInSpot[1, 2] == 18)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.eighteen;
                            }
                            if (board.itemsInSpot[1, 2] == 19)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.nineteen;
                            }
                            if (board.itemsInSpot[1, 2] == 20)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.twenty;
                            }
                            if (board.itemsInSpot[1, 2] == 21)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.twentyone;
                            }
                            if (board.itemsInSpot[1, 2] == 22)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.twentytwo;
                            }
                            if (board.itemsInSpot[1, 2] == 23)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.twentythree;
                            }
                            if (board.itemsInSpot[1, 2] == 24)
                            {
                                picBox9.Image = global::ISMancalaV1.Properties.Resources.twentyfour;
                            }
                        }
                        if (c.Tag.Equals("13"))
                        {
                            PictureBox picBox10 = (PictureBox)c;
                            if (board.itemsInSpot[1, 3] == 0)
                            {
                                picBox10.Image = null;
                            }
                            if (board.itemsInSpot[1, 3] == 1)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.oneBall;
                            }
                            if (board.itemsInSpot[1, 3] == 2)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.twoBall;
                            }
                            if (board.itemsInSpot[1, 3] == 3)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.threeball;
                            }
                            if (board.itemsInSpot[1, 3] == 4)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.fourball;
                            }
                            if (board.itemsInSpot[1, 3] == 5)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.fiveball;
                            }
                            if (board.itemsInSpot[1, 3] == 6)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.six;
                            }
                            if (board.itemsInSpot[1, 3] == 7)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.seven;
                            }
                            if (board.itemsInSpot[1, 3] == 8)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.eight;
                            }
                            if (board.itemsInSpot[1, 3] == 9)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.nine;
                            }
                            if (board.itemsInSpot[1, 3] == 10)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.ten;
                            }
                            if (board.itemsInSpot[1, 3] == 11)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.eleven;
                            }
                            if (board.itemsInSpot[1, 3] == 12)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.twelve;
                            }
                            if (board.itemsInSpot[1, 3] == 13)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.thirteen;
                            }
                            if (board.itemsInSpot[1, 3] == 14)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.fourteen;
                            }
                            if (board.itemsInSpot[1, 3] == 15)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.fifteen;
                            }
                            if (board.itemsInSpot[1, 3] == 16)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.sixteen;
                            }
                            if (board.itemsInSpot[1, 3] == 17)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.seventeen;
                            }
                            if (board.itemsInSpot[1, 3] == 18)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.eighteen;
                            }
                            if (board.itemsInSpot[1, 3] == 19)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.nineteen;
                            }
                            if (board.itemsInSpot[1, 3] == 20)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.twenty;
                            }
                            if (board.itemsInSpot[1, 3] == 21)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.twentyone;
                            }
                            if (board.itemsInSpot[1, 3] == 22)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.twentytwo;
                            }
                            if (board.itemsInSpot[1, 3] == 23)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.twentythree;
                            }
                            if (board.itemsInSpot[1, 3] == 24)
                            {
                                picBox10.Image = global::ISMancalaV1.Properties.Resources.twentyfour;
                            }
                        }

                        if (c.Tag.Equals("14"))
                        {
                            PictureBox picBox11 = (PictureBox)c;
                            if (board.itemsInSpot[1, 4] == 0)
                            {
                                picBox11.Image = null;
                            }
                            if (board.itemsInSpot[1, 4] == 1)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.oneBall;
                            }
                            if (board.itemsInSpot[1, 4] == 2)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.twoBall;
                            }
                            if (board.itemsInSpot[1, 4] == 3)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.threeball;
                            }
                            if (board.itemsInSpot[1, 4] == 4)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.fourball;
                            }
                            if (board.itemsInSpot[1, 4] == 5)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.fiveball;
                            }
                            if (board.itemsInSpot[1, 4] == 6)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.six;
                            }
                            if (board.itemsInSpot[1, 4] == 7)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.seven;
                            }
                            if (board.itemsInSpot[1, 4] == 8)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.eight;
                            }
                            if (board.itemsInSpot[1, 4] == 9)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.nine;
                            }
                            if (board.itemsInSpot[1, 4] == 10)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.ten;
                            }
                            if (board.itemsInSpot[1, 4] == 11)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.eleven;
                            }
                            if (board.itemsInSpot[1, 4] == 12)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.twelve;
                            }
                            if (board.itemsInSpot[1, 4] == 13)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.thirteen;
                            }
                            if (board.itemsInSpot[1, 4] == 14)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.fourteen;
                            }
                            if (board.itemsInSpot[1, 4] == 15)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.fifteen;
                            }
                            if (board.itemsInSpot[1, 4] == 16)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.sixteen;
                            }
                            if (board.itemsInSpot[1, 4] == 17)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.seventeen;
                            }
                            if (board.itemsInSpot[1, 4] == 18)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.eighteen;
                            }
                            if (board.itemsInSpot[1, 4] == 19)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.nineteen;
                            }
                            if (board.itemsInSpot[1, 4] == 20)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.twenty;
                            }
                            if (board.itemsInSpot[1, 4] == 21)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.twentyone;
                            }
                            if (board.itemsInSpot[1, 4] == 22)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.twentytwo;
                            }
                            if (board.itemsInSpot[1, 4] == 23)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.twentythree;
                            }
                            if (board.itemsInSpot[1, 4] == 24)
                            {
                                picBox11.Image = global::ISMancalaV1.Properties.Resources.twentyfour;
                            }
                        }

                        if (c.Tag.Equals("15"))
                        {
                            PictureBox picBox12 = (PictureBox)c;
                            if (board.itemsInSpot[1, 5] == 0)
                            {
                                picBox12.Image = null;
                            }
                            if (board.itemsInSpot[1, 5] == 1)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.oneBall;
                            }
                            if (board.itemsInSpot[1, 5] == 2)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.twoBall;
                            }
                            if (board.itemsInSpot[1, 5] == 3)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.threeball;
                            }
                            if (board.itemsInSpot[1, 5] == 4)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.fourball;
                            }
                            if (board.itemsInSpot[1, 5] == 5)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.fiveball;
                            }
                            if (board.itemsInSpot[1, 5] == 6)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.six;
                            }
                            if (board.itemsInSpot[1, 5] == 7)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.seven;
                            }
                            if (board.itemsInSpot[1, 5] == 8)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.eight;
                            }
                            if (board.itemsInSpot[1, 5] == 9)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.nine;
                            }
                            if (board.itemsInSpot[1, 5] == 10)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.ten;
                            }
                            if (board.itemsInSpot[1, 5] == 11)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.eleven;
                            }
                            if (board.itemsInSpot[1, 5] == 12)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.twelve;
                            }
                            if (board.itemsInSpot[1, 5] == 13)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.thirteen;
                            }
                            if (board.itemsInSpot[1, 5] == 14)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.fourteen;
                            }
                            if (board.itemsInSpot[1, 5] == 15)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.fifteen;
                            }
                            if (board.itemsInSpot[1, 5] == 16)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.sixteen;
                            }
                            if (board.itemsInSpot[1, 5] == 17)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.seventeen;
                            }
                            if (board.itemsInSpot[1, 5] == 18)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.eighteen;
                            }
                            if (board.itemsInSpot[1, 5] == 19)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.nineteen;
                            }
                            if (board.itemsInSpot[1, 5] == 20)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.twenty;
                            }
                            if (board.itemsInSpot[1, 5] == 21)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.twentyone;
                            }
                            if (board.itemsInSpot[1, 5] == 22)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.twentytwo;
                            }
                            if (board.itemsInSpot[1, 5] == 23)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.twentythree;
                            }
                            if (board.itemsInSpot[1, 5] == 24)
                            {
                                picBox12.Image = global::ISMancalaV1.Properties.Resources.twentyfour;
                            }
                        }
                        if(c.Tag.Equals("points00"))
                        {
                            PictureBox points00 = (PictureBox)c;
                            if (board.playerPoints == 0)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.blank;
                            }
                            if (board.playerPoints == 1)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.oneBall;
                            }
                            if (board.playerPoints == 2)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.twoBall;
                            }
                            if (board.playerPoints == 3)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.threeball;
                            }
                            if (board.playerPoints == 4)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.fourball;
                            }
                            if (board.playerPoints == 5)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.fiveball;
                            }
                            if (board.playerPoints == 6)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.six;
                            }
                            if (board.playerPoints == 7)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.seven;
                            }
                            if (board.playerPoints == 8)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.eight;
                            }
                            if (board.playerPoints == 9)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.nine;
                            }
                            if (board.playerPoints == 10)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.ten;
                            }
                            if (board.playerPoints == 11)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.eleven;
                            }
                            if (board.playerPoints == 12)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.twelve;
                            }
                            if (board.playerPoints == 13)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.thirteen;
                            }
                            if (board.playerPoints == 14)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.fourteen;
                            }
                            if (board.playerPoints == 15)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.fifteen;
                            }
                            if (board.playerPoints == 16)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.sixteen;
                            }
                            if (board.playerPoints == 17)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.seventeen;
                            }
                            if (board.playerPoints == 18)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.eighteen;
                            }
                            if (board.playerPoints == 19)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.nineteen;
                            }
                            if (board.playerPoints == 20)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.twenty;
                            }
                            if (board.playerPoints == 21)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.twentyone;
                            }
                            if (board.playerPoints == 22)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.twentytwo;
                            }
                            if (board.playerPoints == 23)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.twentythree;
                            }
                            if (board.playerPoints == 24)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.twentyfour;
                            }
                            if (board.playerPoints == 24)
                            {
                                points00.Image = global::ISMancalaV1.Properties.Resources.twentyfour;
                            }

                        }
                        if (c.Tag.Equals("points01"))
                        {
                            PictureBox points01 = (PictureBox)c;

                            if (board.playerPoints == 25)
                            {
                                points01.Image = global::ISMancalaV1.Properties.Resources.oneBall;
                            }
                            if (board.playerPoints == 26)
                            {
                                points01.Image = global::ISMancalaV1.Properties.Resources.twoBall;
                            }
                            if (board.playerPoints == 27)
                            {
                                points01.Image = global::ISMancalaV1.Properties.Resources.threeball;
                            }
                            if (board.playerPoints == 28)
                            {
                                points01.Image = global::ISMancalaV1.Properties.Resources.fourball;
                            }
                            if (board.playerPoints == 29)
                            {
                                points01.Image = global::ISMancalaV1.Properties.Resources.fiveball;
                            }
                            if (board.playerPoints == 30)
                            {
                                points01.Image = global::ISMancalaV1.Properties.Resources.six;
                            }
                            if (board.playerPoints == 31)
                            {
                                points01.Image = global::ISMancalaV1.Properties.Resources.seven;
                            }
                            if (board.playerPoints == 32)
                            {
                                points01.Image = global::ISMancalaV1.Properties.Resources.eight;
                            }
                            if (board.playerPoints == 33)
                            {
                                points01.Image = global::ISMancalaV1.Properties.Resources.nine;
                            }
                            if (board.playerPoints == 34)
                            {
                                points01.Image = global::ISMancalaV1.Properties.Resources.ten;
                            }
                            if (board.playerPoints == 35)
                            {
                                points01.Image = global::ISMancalaV1.Properties.Resources.eleven;
                            }
                            if (board.playerPoints == 36)
                            {
                                points01.Image = global::ISMancalaV1.Properties.Resources.twelve;
                            }
                            if (board.playerPoints == 37)
                            {
                                points01.Image = global::ISMancalaV1.Properties.Resources.thirteen;
                            }
                            if (board.playerPoints == 38)
                            {
                                points01.Image = global::ISMancalaV1.Properties.Resources.fourteen;
                            }
                            if (board.playerPoints == 39)
                            {
                                points01.Image = global::ISMancalaV1.Properties.Resources.fifteen;
                            }
                            if (board.playerPoints == 40)
                            {
                                points01.Image = global::ISMancalaV1.Properties.Resources.sixteen;
                            }

                        }

                        if(c.Tag.Equals("points10"))
                        {
                            PictureBox points10 = (PictureBox)c;
                            if (board.pcPoints == 0)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.blank;
                            }
                            if (board.pcPoints == 1)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.oneBall;
                            }
                            if (board.pcPoints == 2)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.twoBall;
                            }
                            if (board.pcPoints == 3)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.threeball;
                            }
                            if (board.pcPoints == 4)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.fourball;
                            }
                            if (board.pcPoints == 5)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.fiveball;
                            }
                            if (board.pcPoints == 6)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.six;
                            }
                            if (board.pcPoints == 7)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.seven;
                            }
                            if (board.pcPoints == 8)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.eight;
                            }
                            if (board.pcPoints == 9)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.nine;
                            }
                            if (board.pcPoints == 10)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.ten;
                            }
                            if (board.pcPoints == 11)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.eleven;
                            }
                            if (board.pcPoints == 12)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.twelve;
                            }
                            if (board.pcPoints == 13)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.thirteen;
                            }
                            if (board.pcPoints == 14)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.fourteen;
                            }
                            if (board.pcPoints == 15)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.fifteen;
                            }
                            if (board.pcPoints == 16)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.sixteen;
                            }
                            if (board.pcPoints == 17)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.seventeen;
                            }
                            if (board.pcPoints == 18)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.eighteen;
                            }
                            if (board.pcPoints == 19)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.nineteen;
                            }
                            if (board.pcPoints == 20)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.twenty;
                            }
                            if (board.pcPoints == 21)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.twentyone;
                            }
                            if (board.pcPoints == 22)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.twentytwo;
                            }
                            if (board.pcPoints == 23)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.twentythree;
                            }
                            if (board.pcPoints == 24)
                            {
                                points10.Image = global::ISMancalaV1.Properties.Resources.twentyfour;
                            }
                            
                        }
                        if(c.Tag.Equals("points11"))
                        {
                            PictureBox points11 = (PictureBox)c;
                            if (board.pcPoints == 25)
                            {
                                points11.Image = global::ISMancalaV1.Properties.Resources.oneBall;
                            }
                            if (board.pcPoints == 26)
                            {
                                points11.Image = global::ISMancalaV1.Properties.Resources.twoBall;
                            }
                            if (board.pcPoints == 27)
                            {
                                points11.Image = global::ISMancalaV1.Properties.Resources.threeball;
                            }
                            if (board.pcPoints == 28)
                            {
                                points11.Image = global::ISMancalaV1.Properties.Resources.fourball;
                            }
                            if (board.pcPoints == 29)
                            {
                                points11.Image = global::ISMancalaV1.Properties.Resources.fiveball;
                            }
                            if (board.pcPoints == 30)
                            {
                                points11.Image = global::ISMancalaV1.Properties.Resources.six;
                            }
                            if (board.pcPoints == 31)
                            {
                                points11.Image = global::ISMancalaV1.Properties.Resources.seven;
                            }
                            if (board.pcPoints == 32)
                            {
                                points11.Image = global::ISMancalaV1.Properties.Resources.eight;
                            }
                            if (board.pcPoints == 33)
                            {
                                points11.Image = global::ISMancalaV1.Properties.Resources.nine;
                            }
                        
                            if (board.pcPoints == 34)
                            {
                            points11.Image = global::ISMancalaV1.Properties.Resources.ten;
                            }
                            if (board.pcPoints == 35)
                            {
                                points11.Image = global::ISMancalaV1.Properties.Resources.eleven;
                            }
                            if (board.pcPoints == 36)
                            {
                                points11.Image = global::ISMancalaV1.Properties.Resources.twelve;
                            }
                            if (board.pcPoints == 37)
                            {
                                points11.Image = global::ISMancalaV1.Properties.Resources.thirteen;
                            }
                            if (board.pcPoints == 38)
                            {
                                points11.Image = global::ISMancalaV1.Properties.Resources.fourteen;
                            }
                            if (board.pcPoints == 39)
                            {
                                points11.Image = global::ISMancalaV1.Properties.Resources.fifteen;
                            }
                            if (board.pcPoints == 40)
                            {
                                points11.Image = global::ISMancalaV1.Properties.Resources.sixteen;
                            }
                        }
                            
                    }
                }

                




            }
        }
    }
}
