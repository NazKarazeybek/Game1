﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Game1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer SoundPlayer1 = new SoundPlayer(Properties.Resources.coundowncard);
            SoundPlayer SoundPlayer2 = new SoundPlayer(Properties.Resources.begincard);
            gamestarts.Visible = false;
            loadingscreen.Visible = false;
            countdown1.Visible = false;
            countdown2_.Visible = false;
            countdown3.Visible = false;
            beginscreen.Visible = false;
            dot1.Visible = false;
            dot2.Visible = false;
            dot3.Visible = false;
            Begin.Visible = false;
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            loadingscreen.Visible = true;
            dot1.Parent = loadingscreen;
            dot2.Parent = loadingscreen;
            dot3.Parent = loadingscreen;
            countdown2_.Parent = loadingscreen;    
            countdown3.Parent = loadingscreen;
            countdown1.Parent = loadingscreen;
            gamestarts.Parent = loadingscreen;
            gamestarts.Visible = true;
            Start_Button.Visible = false;

            dot1.Visible = true;

            SoundPlayer player1 = new SoundPlayer(Properties.Resources.coundowncard);

            player1.Play();

            Refresh();
            Thread.Sleep(400);

            dot2.Visible = true;

            Refresh();
            Thread.Sleep(400);

            dot3.Visible = true;

            Refresh();
            Thread.Sleep(300);

            countdown3.Visible = true;

            Refresh();
            Thread.Sleep(400);

            countdown3.Visible=false;
            dot1.Visible = false;
            dot2.Visible=false;
            dot3.Visible=false;

            Refresh();
            Thread.Sleep(400);
           
            dot1.Visible=true;

            SoundPlayer player2 = new SoundPlayer(Properties.Resources.coundowncard);

            player2.Play();

            Refresh();
            Thread.Sleep(400);

            dot2.Visible = true;

            Refresh();
            Thread.Sleep(400);

            dot3.Visible=true;

            Refresh();
            Thread.Sleep(300);

            countdown2_.Visible = true;

            Refresh();
            Thread.Sleep(400);

            countdown2_.Visible = false;
            dot1.Visible = false;
            dot2.Visible = false;
            dot3.Visible = false;

            Refresh();
            Thread.Sleep(400);

            dot1.Visible = true;

            SoundPlayer player3 = new SoundPlayer(Properties.Resources.coundowncard);

            player3.Play();

            Refresh();
            Thread.Sleep(400);

            dot2.Visible = true;

            Refresh();
            Thread.Sleep(400);

            dot3.Visible = true;

            Refresh();
            Thread.Sleep(300);

            countdown1.Visible = true;

            Refresh();
            Thread.Sleep(200);

            dot1.Visible = false;
            dot2.Visible = false;
            dot3.Visible = false;
            gamestarts.Visible = false;
            countdown1.Visible = false;
            countdown2_.Visible = false;
            countdown3.Visible = false;
            beginscreen.Visible = true;
            Begin.Parent = beginscreen;
            Begin.Visible = true;

            Refresh();
            Thread.Sleep(150);

            SoundPlayer player4 = new SoundPlayer(Properties.Resources.begincard);

            player4.Play();

            Refresh();
            Thread.Sleep(800);

            Begin.Visible = false;








        }

        private void countdown3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gamestarts_Click(object sender, EventArgs e)
        {

        }

        private void countdown1_Click(object sender, EventArgs e)
        {

        }

        private void countdown2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dot2_Click(object sender, EventArgs e)
        {

        }

        private void dot3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void beginscreen_Click(object sender, EventArgs e)
        {

        }

        private void Begin_Click(object sender, EventArgs e)
        {

        }
    }
}
