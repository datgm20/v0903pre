using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0903pre
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();
        int vx = rand.Next(-20, 21);
        int vy = rand.Next(-20, 21);
        string kao = "(・皿・)";
        int score = 100;

        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }

            Point mp = MousePosition;
            mp = PointToClient(mp);
            if (    (mp.X >= label1.Left )
                &&  (mp.X < label1.Right)
                &&  (mp.Y >= label1.Top)
                && (mp.Y < label1.Bottom))
            {
                timer1.Enabled = false;
                button1.Visible = true;
            }

            string t = label1.Text;
            label1.Text = kao;
            kao = t;

            score--;
            label2.Text = "Score " + score;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score = 100;
            timer1.Enabled = true;
            button1.Visible = false;

            vx = rand.Next(-20, 21);
            vy = rand.Next(-20, 21);
            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);
        }
    }
}
