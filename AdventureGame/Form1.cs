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
using System.Media;
using System.Threading;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        int page = 1;
        Random randGen = new Random();
        int randomValue;
        Font TextFont = new Font("Rubber Biscuit", 28);
        Font ChoiceFont = new Font("Rubber Biscuit", 20);
        Font TextFont2 = new Font("Rubber Biscuit", 16);
        SoundPlayer player = new SoundPlayer(Properties.Resources.mouseclick);
        SoundPlayer combatplayer = new SoundPlayer(Properties.Resources.music02);


        System.Windows.Media.MediaPlayer nightMusic = new System.Windows.Media.MediaPlayer();

        public Form1()
        {
            InitializeComponent();

            nightMusic.Open(new Uri(Application.StartupPath + "/Resources/04.wav"));
            nightMusic.MediaEnded += new EventHandler(nightMusic_MediaEnded);
            nightMusic.Play();

            outputText.Visible = false;
        }

        private void nightMusic_MediaEnded(object sender, EventArgs e)
        {
            nightMusic.Stop();
            nightMusic.Play();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void inputButton1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            { 
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 7;
            }
            else if (page == 4)
            {
                page = 1;
            }
            else if (page == 6)
            {
                page = 20;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10) //add randgen
            {
                page = 48;
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 10;
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 15)
            {
                page = 14;
            }
            else if (page == 16)
            {
                page = 14;
            }
            else if (page == 17)
            {
                page = 13;
            }
            else if (page == 18)
            {
                page = 99;
            }
            else if (page == 19)
            {
                page = 18;
            }
            else if (page == 20)
            {
                page = 22;
            }
            else if (page == 21)
            {
                page = 24;
            }
            else if (page == 22)
            {
                page = 32;
            }
            else if (page == 23)
            {
                page = 99;
            }
            else if (page == 24)
            {
                page = 26;
            }
            else if (page == 25)
            {
                page = 28;
            }
            else if (page == 26)
            {
                page = 22;
            }
            else if (page == 27)
            {
                page = 30;
            }
            else if (page == 28)
            {
                page = 29;
            }
            else if (page == 29)
            {
                page = 30;
            }
            else if (page == 30)
            {
                page = 26;
            }
            else if (page == 32)
            {
                page = 99;
            }
            else if (page == 33)
            {
                page = 99;
            }
            else if (page == 34) //add randgen
            {
                page = 36;
            }
            else if (page == 35)
            {
                page = 34;
            }
            else if (page == 36)
            {
                page = 99;
            }
            else if (page == 39)
            {
                page = 99;
            }
            else if (page == 40)
            {
                page = 99;
            }
            else if (page == 41)
            {
                page = 99;
            }
            else if (page == 45)
            {
                page = 10;
            }
            else if (page == 47)
            {
                page = 99;
            }
            else if (page == 48)
            {
                page = 20;
            }
            else if (page == 99)
            {
                page = 2;
            }

            switch (page)
            {
                case 2:
                    player.Play();
                    BackgroundImage = (Properties.Resources.street1edit);
                    titleLabel.Visible = false;
                    outputText.Visible = true;
                    outputText.Text = "One night, you wake up in the middle of the road with no idea where you are.";
                    inputButton1.Visible = false;
                    inputButton2.Visible = false;
                    Refresh();
                    Thread.Sleep(5000);

                    inputButton1.Visible = true;
                    inputButton2.Visible = true;
                    outputText.Visible = false;
                    titleLabel.Visible = true;
                    titleLabel.Font = TextFont;
                    inputButton1.Font = ChoiceFont;
                    inputButton2.Font = ChoiceFont;
                    titleLabel.Text = "How will you get home";
                    inputButton1.Text = "Building";
                    inputButton2.Text = "Alley";
                    break;
                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 7:
                    player.Play();
                    BackgroundImage = (Properties.Resources.alley1edit);
                    titleLabel.Visible = false;
                    outputText.Visible = true;
                    outputText.Text = "You turn around and start to head back to the begining.";
                    inputButton1.Visible = false;
                    inputButton2.Visible = false;
                    Refresh();
                    Thread.Sleep(5000);

                    nightMusic.Stop();
                    combatplayer.Play();
                    BackgroundImage = (Properties.Resources.alleymonsteredit);
                    outputText.Text = "On your way back, you're cut off by an ominous figure.";
                    Refresh();
                    Thread.Sleep(2500);
                    inputButton1.Visible = true;
                    inputButton2.Visible = true;
                    outputText.Visible = false;
                    titleLabel.Visible = true;
                    titleLabel.Font = TextFont;
                    inputButton1.Font = ChoiceFont;
                    inputButton2.Font = ChoiceFont;
                    titleLabel.Text = "What will you do";
                    inputButton1.Text = "Nothing";
                    inputButton2.Text = "Run";
                    break;

                case 8:
                    player.Play();
                    BackgroundImage = (Properties.Resources.bluescreen1edit);
                    titleLabel.Visible = false;
                    outputText.Visible = true;
                    outputText.Text = "You freeze out of fear and the figure approaches you. You are unable to fight back.";
                    inputButton1.Visible = false;
                    inputButton2.Visible = false;
                    combatplayer.Stop();
                    Refresh();
                    Thread.Sleep(5000);

                    nightMusic.Play();
                    inputButton1.Visible = true;
                    inputButton2.Visible = true;
                    outputText.Visible = false;
                    titleLabel.Visible = true;;
                    titleLabel.Font = TextFont;
                    inputButton1.Font = ChoiceFont;
                    inputButton2.Font = ChoiceFont;
                    titleLabel.Text = "Play Again";
                    inputButton1.Text = "Yes";
                    inputButton2.Text = "No";
                    break;

                case 9:
                    break;

                case 10:
                    break;

                case 11:
                    break;

                case 12:
                    break;

                case 13:
                    break;

                case 14:
                    break;

                case 15:
                    break;

                case 16:
                    break;

                case 17:
                    break;

                case 18:
                    break;

                case 19:
                    break;

                case 20:
                    break;

                case 21:
                    break;

                case 22:
                    break;

                case 23:
                    break;

                case 24:
                    break;

                case 25:
                    break;

                case 26:
                    break;

                case 27:
                    break;

                case 28:
                    break;

                case 29:
                    break;

                case 30:
                    break;

                case 31:
                    break;

                case 32:
                    break;

                case 33:
                    break;

                case 34:
                    break;

                case 35:
                    break;

                case 36:
                    break;

                case 37:
                    break;

                case 38:
                    break;

                case 39:
                    break;

                case 40:
                    break;

                case 41:
                    break;

                case 42:
                    break;

                case 43:
                    break;

                case 44:
                    break;

                case 45:
                    break;

                case 46:
                    break;

                case 47:
                    break;

                case 48:
                    break;

                case 99:
                    break;
            }
        }

        private void inputButton2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 99;
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                randomValue = randGen.Next(1, 11);
                if (randomValue == 1)
                {
                    page = 6;
                }
                else
                {
                    page = 11;
                }
            }
            else if (page == 4)
            {
                page = 1;
            }
            else if (page == 6)
            {
                page = 20;
            }
            else if (page == 7)
            {
                page = 9;
            }
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10) //add randgen
            {
                page = 47;
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 15;
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 15)
            {
                page = 17;
            }
            else if (page == 16)
            {
                page = 14;
            }
            else if (page == 17)
            {
                page = 13;
            }
            else if (page == 18)
            {
                page = 99;
            }
            else if (page == 19)
            {
                page = 20;
            }
            else if (page == 20)
            {
                page = 21;
            }
            else if (page == 21)
            {
                page = 23;
            }
            else if (page == 22)
            {
                page = 35;
            }
            else if (page == 23)
            {
                page = 99;
            }
            else if (page == 24)
            {
                page = 25;
            }
            else if (page == 25)
            {
                page = 28;
            }
            else if (page == 26)
            {
                page = 22;
            }
            else if (page == 27)
            {
                page = 29;
            }
            else if (page == 28)
            {
                page = 29;
            }
            else if (page == 29)
            {
                page = 33;
            }
            else if (page == 30)
            {
                page = 26;
            }
            else if (page == 32)
            {
                page = 99;
            }
            else if (page == 33)
            {
                page = 99;
            }
            else if (page == 34) //add randgen
            {
                page = 41;
            }
            else if (page == 35)
            {
                page = 37;
            }
            else if (page == 36)
            {
                page = 99;
            }
            else if (page == 39)
            {
                page = 99;
            }
            else if (page == 40)
            {
                page = 99;
            }
            else if (page == 41)
            {
                page = 99;
            }
            else if (page == 45)
            {
                page = 13;
            }
            else if (page == 47)
            {
                page = 99;
            }
            else if (page == 48)
            {
                page = 47;
            }
            else if (page == 99)
            {
                inputButton1.Visible = false;
                inputButton2.Visible = false;
                titleLabel.Font = TextFont;
                titleLabel.Text = "Another time then";
                Refresh();
                Thread.Sleep(2000);
                Application.Exit();
            }

            switch (page)
            {
                case 2:
                    break;

                case 3:
                    player.Play();
                    BackgroundImage = (Properties.Resources.alley1edit);
                    titleLabel.Visible = false;
                    outputText.Visible = true;
                    outputText.Text = "As you walk through the alley, fog begins to appear";
                    inputButton1.Visible = false;
                    inputButton2.Visible = false;
                    Refresh();
                    Thread.Sleep(5000);

                    BackgroundImage = Properties.Resources.fenceedit;
                    inputButton1.Visible = true;
                    inputButton2.Visible = true;
                    outputText.Visible = false;
                    titleLabel.Visible = true;
                    titleLabel.Font = TextFont2;
                    titleLabel.Text = "You come across a tall fence";
                    inputButton1.Text = "Turn Around";
                    inputButton2.Text = "Climb";
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    player.Play();
                    BackgroundImage = (Properties.Resources.fenceedit);
                    titleLabel.Visible = false;
                    outputText.Visible = true;
                    outputText.Text = "You make it safely over the fence, somehow.";
                    inputButton1.Visible = false;
                    inputButton2.Visible = false;
                    Refresh();
                    Thread.Sleep(5000);
                    break;

                case 7:
                    break;

                case 8:
                    break;

                case 9:
                    break;

                case 10:
                    break;

                case 11:
                    player.Play();
                    BackgroundImage = (Properties.Resources.bluescreen1edit);
                    titleLabel.Visible = false;
                    outputText.Visible = true;
                    outputText.Text = "You try to climb the fence, but fall down in the process. You break your neck";
                    inputButton1.Visible = false;
                    inputButton2.Visible = false;
                    Refresh();
                    Thread.Sleep(2500);

                    inputButton1.Visible = true;
                    inputButton2.Visible = true;
                    outputText.Visible = false;
                    titleLabel.Visible = true;
                    titleLabel.Text = "Play Again";
                    inputButton1.Text = "Yes";
                    inputButton2.Text = "No";
                    break;

                case 12:
                    break;

                case 13:
                    break;

                case 14:
                    break;

                case 15:
                    break;

                case 16:
                    break;

                case 17:
                    break;

                case 18:
                    break;

                case 19:
                    break;

                case 20:
                    player.Play();
                    BackgroundImage = (Properties.Resources.street2edit);
                    titleLabel.Visible = false;
                    outputText.Visible = true;
                    outputText.Text = "You find yourself on an old road";
                    inputButton1.Visible = false;
                    inputButton2.Visible = false;

                    inputButton1.Visible = true;
                    inputButton2.Visible = true;
                    outputText.Visible = false;
                    titleLabel.Visible = true;
                    titleLabel.Font = TextFont2;
                    titleLabel.Text = "Whcich Way";
                    inputButton1.Text = "South";
                    inputButton2.Text = "North";
                    break;

                case 21:
                    break;

                case 22:
                    break;

                case 23:
                    break;

                case 24:
                    break;

                case 25:
                    break;

                case 26:
                    break;

                case 27:
                    break;

                case 28:
                    break;

                case 29:
                    break;

                case 30:
                    break;

                case 31:
                    break;

                case 32:
                    break;

                case 33:
                    break;

                case 34:
                    break;

                case 35:
                    break;

                case 36:
                    break;

                case 37:
                    break;

                case 38:
                    break;

                case 39:
                    break;

                case 40:
                    break;

                case 41:
                    break;

                case 42:
                    break;

                case 43:
                    break;

                case 44:
                    break;

                case 45:
                    break;

                case 46:
                    break;

                case 47:
                    break;

                case 48:
                    break;

                case 99:
                    break;
            }
        }


        private void inputButton1_MouseHover(object sender, EventArgs e)
        {
            ButtonTimerLeft.Enabled = true;
        }

        private void inputButton1_MouseLeave(object sender, EventArgs e)
        {
            inputButton1.BackColor = Color.Black;
            inputButton1.ForeColor = Color.White;
            inputButton1.TextAlign = ContentAlignment.MiddleCenter;
            ButtonTimerLeft.Enabled = false;
         
        }

        private void inputButton2_MouseHover(object sender, EventArgs e)
        {
            ButtonTimerRight.Enabled = true;
            
        }

        private void inputButton2_MouseLeave(object sender, EventArgs e)
        {
            inputButton2.BackColor = Color.Black;
            inputButton2.ForeColor = Color.White;
            inputButton2.TextAlign = ContentAlignment.MiddleCenter;
            ButtonTimerRight.Enabled = false;
        }

        private void ButtonTimerLeft_Tick(object sender, EventArgs e)
        {
            inputButton1.BackColor = Color.White;
            inputButton1.ForeColor = Color.Black;
            randomValue = randGen.Next(1, 8);
            switch (randomValue)
            {

                case 1:
                    inputButton1.TextAlign = ContentAlignment.TopLeft;
                    break;
                case 2:
                    inputButton1.TextAlign = ContentAlignment.BottomRight;
                    break;
                case 3:
                    inputButton1.TextAlign = ContentAlignment.TopRight;
                    break;
                case 4:
                    inputButton1.TextAlign = ContentAlignment.BottomLeft;
                    break;
                case 5:
                    inputButton1.TextAlign = ContentAlignment.MiddleLeft;
                    break;
                case 6:
                    inputButton1.TextAlign = ContentAlignment.MiddleRight;
                    break;
                case 7:
                    inputButton1.TextAlign = ContentAlignment.MiddleCenter;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            inputButton2.BackColor = Color.White;
            inputButton2.ForeColor = Color.Black;
            randomValue = randGen.Next(1, 8);
            switch (randomValue)
            {

                case 1:
                    inputButton2.TextAlign = ContentAlignment.TopLeft;
                    break;
                case 2:
                    inputButton2.TextAlign = ContentAlignment.BottomRight;
                    break;
                case 3:
                    inputButton2.TextAlign = ContentAlignment.TopRight;
                    break;
                case 4:
                    inputButton2.TextAlign = ContentAlignment.BottomLeft;
                    break;
                case 5:
                    inputButton2.TextAlign = ContentAlignment.MiddleLeft;
                    break;
                case 6:
                    inputButton2.TextAlign = ContentAlignment.MiddleRight;
                    break;
                case 7:
                    inputButton2.TextAlign = ContentAlignment.MiddleCenter;
                    break;
            }
        }
    }


    }
