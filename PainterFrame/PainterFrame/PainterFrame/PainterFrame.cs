using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PainterFrame
{
    public partial class PainterFrame : Form
    {
        private Point? initial;
        private Bitmap tempBitmap;
        private Graphics tempGraphic;
        private Model model;
        public PainterFrame()
        {
            InitializeComponent();
            model = new Model(this);
            tempBitmap = (Bitmap)model.Backend.Clone();
            pictureBox.Paint += new PaintEventHandler(repaint);
        }



        public void repaint(object sender, PaintEventArgs e) {
                pictureBox.Image = model.Backend;
        }

        private void repaintTemp() {
            pictureBox.Image = tempBitmap;
            tempBitmap = (Bitmap)model.Backend.Clone();
        }


        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {          
            if (initial != null)
            {
                model.drawLine(initial.Value, e.Location);
                System.Console.WriteLine("Initial: " + initial);
                initial = null;
            }
            else {
                initial = e.Location;
                System.Console.WriteLine("Initial: " + initial);
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            tempGraphic = Graphics.FromImage(tempBitmap);
            if (initial.HasValue)
            {
                //tempGraphic.Clear(Color.Gray);
                tempGraphic.DrawLine(new Pen(Color.Red), initial.Value, e.Location);
            }
            repaintTemp();
        }

    }
}