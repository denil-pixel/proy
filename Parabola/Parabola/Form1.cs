using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parabola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void btnfig_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = 0;
            int c = 0;
            double x, y;
            int orig_x = pn1.Width / 2;
            int orig_y = pn1.Height / 2;

            //
            Bitmap pen = new Bitmap(1, 1);
            pen.SetPixel(0, 0, Color.Green);
            System.Drawing.Graphics g = pn1.CreateGraphics();

            //

            for (double i = 0; i <= 100; i += 0.01)
            {
                x = i;
                y = (a * (x * x)) + ((b * x) + c);
                g.DrawImageUnscaled(pen,orig_x+(int)x,orig_y-(int)y);
                g.DrawImageUnscaled(pen,orig_x- (int )x,orig_y -(int)y);
                if(y >=orig_y) {break;}



            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Drawing.Pen linepen;
            linepen = new System.Drawing.Pen(System.Drawing.Color.Green);
            System.Drawing.Graphics g = pn1.CreateGraphics();
            g.DrawLine(linepen,0, pn1.Height / 2, pn1.Width, pn1.Height / 2);
            g.DrawLine(linepen, pn1.Width / 2, 0, pn1.Width / 2, pn1.Height);

            timer1.Enabled = false;
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnme_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if(WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        
    }
}
