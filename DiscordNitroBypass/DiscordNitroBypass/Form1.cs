﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DiscordNitroBypass
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        Random random = new Random();
        private void button2_Click(object sender, EventArgs e)
        {
            Random rng = new Random();

            char tbRandomNumber = (char)rng.Next(65, 90);
            char tbRandomNumber2 = (char)rng.Next(65, 90);
            char tbRandomNumber3 = (char)rng.Next(65, 90);
            char tbRandomNumber4 = (char)rng.Next(65, 90);
            char tbRandomNumber5 = (char)rng.Next(65, 90);
            textBox1.Text = "https://discord.com/billing/promotions/xbox-game-pass/redeem/" + (tbRandomNumber.ToString()) + (Convert.ToString(random.Next(1000, 9999))) + (tbRandomNumber2.ToString()) + (tbRandomNumber3.ToString()) + (Convert.ToString(random.Next(1000, 9999))) + (tbRandomNumber4.ToString()) + (Convert.ToString(random.Next(1000, 9999))) + (tbRandomNumber5.ToString()); 
        }

    }
}
