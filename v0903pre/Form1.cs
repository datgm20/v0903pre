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

        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Left = rand.Next(ClientSize.Height - label1.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;
        }
    }
}
