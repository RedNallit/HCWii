using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Drawing.Imaging;

namespace PainterFrame
{
    public class Model {
        Image backend;
        Graphics graphics;
        Pen pen;
        PainterFrame frame;


        public Image Backend
        {
            get { return backend; }
            set { backend = value; }
        }


        public Model(PainterFrame frame) {
            backend = new Bitmap(frame.Width, frame.Height);
            graphics = Graphics.FromImage(backend);
            pen = new Pen(Color.Red);
            this.frame = frame;
        }

        public void drawLine(Point p1, Point p2){
            graphics.DrawLine(pen, p1, p2);
        }
    }
}
