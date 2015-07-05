using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3Extra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs paintEvent)
        {
            Graphics gfx = paintEvent.Graphics;
            Pen myPen = new Pen(Color.Black);

            //Lineas verticales y horizontales
            /*for (int i = 20; i < 250; i= i +10)
            {
                gfx.DrawLine(myPen, 20, i, 270, i);
            }

            for (int x = 20; x < 280; x=x+10)
            {
                gfx.DrawLine(myPen, x, 20, x, 250);
            }*/

            //Rectangulos
            /*
            for (int i = 0; i < 250; i=i+50)
            {
                gfx.DrawRectangle(myPen, i, i, 50, 50);
            }*/

            int x1 = 0;
            int y1 = 0;
            for (int i = 0; i <= 250; i++)
            {
                Color brushColor = Color.FromArgb(i, 0, 0);
                SolidBrush myBrush = new SolidBrush(brushColor);
                gfx.FillRectangle(myBrush, x1, y1, 10, 10);
                x1 = x1 + 10;
                if ((x1%290)==0)
                {
                    y1 = y1 + 10;
                    x1 = 0;
                }
            }

            for (int i = 0; i <= 255; i++)
            {
                Color brushColor = Color.FromArgb(0, i, 0);
                SolidBrush myBrush = new SolidBrush(brushColor);
                gfx.FillRectangle(myBrush, x1, y1, 10, 10);
                x1 = x1 + 10;
                if ((x1%290)==0)
                {
                    y1 = y1 + 10;
                    x1 = 0;
                }
            }

            for (int i = 0; i <= 255; i++)
            {
                Color brushColor = Color.FromArgb(0, 0, i);
                SolidBrush myBrush = new SolidBrush(brushColor);
                gfx.FillRectangle(myBrush, x1, y1, 10, 10);
                x1 = x1 + 10;
                if ((x1 % 290) == 0)
                {
                    y1 = y1 + 10;
                    x1 = 0;
                }
            }
        }
    }
}
