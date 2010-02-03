using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace PainterFrame
{
    public class Model {
        private Image backend;
        private Bitmap drawBitmap;
        private Bitmap realBitmap;

        private Graphics graphics;
        private Graphics tempGraphic;

        private Pen pen, supportPen;
        private Color color;

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        private PainterFrame frame;
        private States state;

        private Point? initial;



        public Pen SupportPen
        {
            get { return supportPen; }
            set { supportPen = value; }
        }

        public Pen Pen
        {
            get { return pen; }
            set { 
                pen = value;
                supportPen = value;    
            }
        }
        private enum States
        {
            Drawing,
            Displaying,
        };

        private States State
        {
            get { return state; }
            set { 
                state = value;

                if (value == States.Displaying){
                    backend = realBitmap;
                }

                else if (value == States.Drawing) {
                    backend = drawBitmap;
                }
                    }
        }

        public Image Backend
        {
            get { return backend; }
            set { backend = value; }
        }


        public Model(PainterFrame frame) {
            realBitmap = new Bitmap(frame.Width, frame.Height);
            graphics = Graphics.FromImage(realBitmap);
            this.frame = frame;
            State = States.Displaying;
            drawBitmap = (Bitmap)realBitmap.Clone();
            Color = Color.HotPink;
            initPens();
        }

        private void initPens() {
            CustomLineCap arrowCap = new AdjustableArrowCap(5, 5, true);
            pen = Pens.largeSolidArrow(Color.HotPink);
            supportPen = Pens.largeDashedArrow(Color.HotPink);
        }

        private void drawLine(Point p1, Point p2){
            graphics.DrawLine(pen, p1, p2);
        }

        public void drawSupportLine(Point p) {
            if (initial.HasValue)
            {
                tempGraphic = Graphics.FromImage(drawBitmap);
                tempGraphic.Clear(Color.Empty);
                State = States.Drawing;
                tempGraphic.DrawImage(realBitmap, 0, 0);
                tempGraphic.DrawLine(supportPen, initial.Value, p);
                
            }
        }

        /*
         * If two points have been clicked, a line will be drawn. If only one has been clicked,
         * this point will be remembered, but now shown.
         */
        public void maybeDraw(Point p) {
            
            if (initial.HasValue) // This is the second click
            {
                State = States.Displaying;
                drawLine(initial.Value, p);
                initial = null;
            }
            else
            {
                initial = p;
            }
        }


        public void initButtons(Button[] buttons, Pen[] pens){
            for (int i = 0; i < pens.Length && i<buttons.Length; i++ )
            {
                Button b = buttons[i];
                b.Image = new Bitmap(b.Width, b.Height);
                Graphics g = Graphics.FromImage(b.Image);
                g.DrawLine(pens[i], 15, b.Height / 2, b.Width - 15, b.Height / 2);
            }
        }
    }
}
