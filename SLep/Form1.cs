using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLep
{
    public partial class Form1 : Form
    {
        int click = 0;
        Point templocation = new Point(0, 0);
        Random rnd = new Random();
        bool mouse = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

 

       private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            click++;
            label1.Text = Convert.ToString(click);
            mouse = true;
            if (mouse)
            {
                pictureBox1.Location = templocation;
                templocation.X = rnd.Next(panel1.Width - 50);
                pictureBox1.Location = templocation;
                templocation.Y = rnd.Next(panel1.Height - 50);
            }
       }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
