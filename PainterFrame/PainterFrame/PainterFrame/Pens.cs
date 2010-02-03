using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Drawing.Imaging;

namespace PainterFrame
{
    class Pens
    {
        static int LARGESIZEARROW = 4;
        static int SMALLZISEARROW = 1;
        static int LARGESIZELINE = 5;

        public static Pen largeSolidArrow(Color c) {
            Pen pen = largeDashedArrow(c);
            pen.DashStyle = DashStyle.Solid;
            return pen;
        }

        public static Pen largeDashedArrow(Color c) {
            CustomLineCap arrowCap = new AdjustableArrowCap(LARGESIZEARROW, LARGESIZEARROW, true);
            Pen pen = largeDashed(c);
            pen.CustomEndCap = arrowCap;
            return pen;
        }

        public static Pen largeDashed(Color c)
        {
            Pen pen = largeSolid(c);
            pen.DashStyle = DashStyle.Dash;
            return pen;

        }

        public static Pen largeSolid(Color c)
        {
            Pen pen = new Pen(c, LARGESIZELINE);
            return pen;
        }
    }
}
