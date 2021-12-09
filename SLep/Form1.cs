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
        Point cellocation = new Point(0, 0);
        Point Hantlocation;
        Point p;
        Point d;
        private bool n = false;
        Random rnd = new Random();
        bool poz = false;
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

             if (d.X >= cellocation.X && d.Y >= cellocation.Y)
             {
                 click++;
                 label1.Text = Convert.ToString(click);
                 poz = true;
                 if (poz)
                 {
                     pictureBox1.Location = cellocation;
                     cellocation.X = rnd.Next(panel1.Width - 50);
                     pictureBox1.Location = cellocation;
                     cellocation.Y = rnd.Next(panel1.Height - 50);
                 }
             
        }

    }



        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            Hantlocation = PointToClient(MousePosition);
            p = new Point(Hantlocation.X - pictureBox2.Location.X, Hantlocation.Y - pictureBox2.Location.Y);
            n = true;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            n = false;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (n)
            {
                Hantlocation = PointToClient(MousePosition);
                d = new Point(Hantlocation.X - p.X, Hantlocation.Y - p.Y);
                pictureBox2.Location = d;
            }
        }
        
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point a = new Point(e.X, e.Y);
            pictureBox2.Location = a;
        }
    }
}
