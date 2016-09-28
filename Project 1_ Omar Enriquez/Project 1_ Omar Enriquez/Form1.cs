using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphicsObj;

            graphicsObj = this.CreateGraphics();

            Pen myPen = new Pen(System.Drawing.Color.Black, 1);
            Pen myPenYellow = new Pen(System.Drawing.Color.Yellow, 2);
            Pen myPenGray = new Pen(System.Drawing.Color.LightGray, 1);

            Brush myBrush = new SolidBrush(Color.LightGray);

            Brush myBrushYellow = new SolidBrush(Color.Yellow);

            // Draw grid to make it easier to position lines
            for (int i = 0; i < this.Height / 10; i++)
            {
                for (int j = 0; j < this.Width / 10; j++)
                {
                    graphicsObj.DrawRectangle(myPen, j * 10, i * 10, 1, 1);
                }
            }

            myPen.Width = 3;

            graphicsObj.DrawPolygon(myPenYellow, new Point[] { new Point(0, 0), new Point(0, 50), new Point (30, 40), new Point(40, 30), new Point (50,0) });
            graphicsObj.FillPolygon(myBrushYellow , new Point[] { new Point(0, 0), new Point(0, 50), new Point(30, 40), new Point(40, 30), new Point(50, 0) });

            //This code draws the rays of sun as lines with the yellow pen
            graphicsObj.DrawLine(myPenYellow, new Point(10, 60), new Point(20, 80) );
            graphicsObj.DrawLine(myPenYellow, new Point(30, 50), new Point(60, 80));
            graphicsObj.DrawLine(myPenYellow, new Point(50, 30), new Point(70, 40));
            graphicsObj.DrawLine(myPenYellow, new Point(60, 10), new Point(110, 10));

            //This code draws the tail flippers
            graphicsObj.DrawPolygon(myPenGray, new Point[] { new Point(130, 270), new Point(120, 250), new Point(100, 240), new Point(90, 260), new Point(100, 270), new Point (120, 280), new Point(110,310), new Point (120,330), new Point (140,310), new Point (140, 280), new Point (130,280) });
            graphicsObj.FillPolygon(myBrush, new Point[] { new Point(130, 270), new Point(120, 250), new Point(100, 240), new Point(90, 260), new Point(100, 270), new Point(120, 280), new Point(110, 310), new Point(120, 330), new Point(140, 310), new Point(140, 280), new Point(130, 280) });

            //This code draws a polygon of the outline of the body.
            graphicsObj.DrawPolygon(myPenGray, new Point[] { new Point(140, 280), new Point(160, 270), new Point(180, 260), new Point(210, 230), new Point(230, 200), new Point(240, 180), new Point(240, 170), new Point(230, 180), new Point(220, 160), new Point (230, 140), new Point(240, 140),
                new Point(240, 130), new Point(220, 90), new Point(210, 80), new Point (200, 70), new Point (180, 60), new Point (170, 60), new Point (140, 70), new Point (120, 90), new Point (110, 100), new Point (100, 120), new Point (100, 140),  new Point (80, 160), new Point (80, 170),
                new Point (90, 170), new Point (110, 160), new Point (130, 160), new Point (150, 150), new Point (165, 145), new Point (180, 150), new Point (190, 170), new Point (190, 200), new Point (180, 220), new Point (170, 240), new Point (130, 270), new Point (130, 280) });
            graphicsObj.FillPolygon(myBrush, new Point[] {new Point(140, 280), new Point(160, 270), new Point(180, 260), new Point(210, 230), new Point(230, 200), new Point(240, 180), new Point(240, 170), new Point(230, 180), new Point(220, 160), new Point (230, 140), new Point(240, 140),
                new Point(240, 130), new Point(220, 90), new Point(210, 80), new Point (200, 70), new Point (180, 60), new Point (170, 60), new Point (140, 70), new Point (120, 90), new Point (110, 100), new Point (100, 120), new Point (100, 140),  new Point (80, 160), new Point (80, 170),
                new Point (90, 170), new Point (110, 160), new Point (130, 160), new Point (150, 150), new Point (165, 145), new Point (180, 150), new Point (190, 170), new Point (190, 200), new Point (180, 220), new Point (170, 240), new Point (130, 270), new Point (130, 280) });
            
            // Add Text
            //Font myFont = new Font("Georgia", 18.0f);
            //myBrush = new SolidBrush(Color.Red);
            //graphicsObj.DrawString("David the Dolphin", myFont, myBrush, new Point(100, 310));
            //graphicsObj.DrawString("by Omar Enriquez", myFont, myBrush, new Point(100, 350));

            myPen.Dispose();
            myBrush.Dispose();
            graphicsObj.Dispose();

        }
    }
}
