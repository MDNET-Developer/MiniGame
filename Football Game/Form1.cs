using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer3.Enabled = true;
            timer5.Enabled = true;
        }

        Random rnd = new Random();

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { //1-ci oyuncu
            int x = label5.Location.X;
            int y = label5.Location.Y;

            if (e.KeyCode == Keys.W)
            {
                y = y - 20;
                label5.Location = new Point(x, y);
            }

            if (e.KeyCode == Keys.S)
            {
                y = y + 20;
                label5.Location = new Point(x, y);
            }
            //2-ci oyuncu
            int u = label6.Location.X;
            int z = label6.Location.Y;

            if (e.KeyCode == Keys.Up)
            {
                z = z - 20;
                label6.Location = new Point(u, z);
            }

            if (e.KeyCode == Keys.Down)
            {
                z = z + 20;
                label6.Location = new Point(u, z);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int top1 = rnd.Next(25, 55);
            pictureBox1.Left = pictureBox1.Left + top1;

            if (label6.Bottom >= pictureBox1.Top && label6.Top <= pictureBox1.Bottom && label6.Right >= pictureBox1.Left && label6.Left <= pictureBox1.Right)
            {
                timer1.Enabled = false; timer2.Enabled = true;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int top1 = rnd.Next(25, 55);
            pictureBox1.Left = pictureBox1.Left + top1;

            if (label5.Bottom >= pictureBox1.Top && label5.Top <= pictureBox1.Bottom && label5.Right >= pictureBox1.Left && label5.Left <= pictureBox1.Right)
            {
                timer1.Enabled = true; timer2.Enabled = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int top1 = rnd.Next(25, 55);
            pictureBox1.Left = pictureBox1.Left + top1;

            if (label1.Top > pictureBox1.Bottom)
            {
                timer3.Enabled = false; timer4.Enabled = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {

            int top1 = rnd.Next(25, 55);
            pictureBox1.Left = pictureBox1.Left + top1;

            if (label2.Bottom < pictureBox1.Top)
            {
                timer3.Enabled = true; timer4.Enabled = false;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {

        }
    }
}
