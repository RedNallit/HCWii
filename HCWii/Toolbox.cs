using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HCWii
{
    public partial class Toolbox : Form
    {
        private Model model;
        public Toolbox(Model m)
        {
            InitializeComponent();
            model = m;
            Color c = Color.HotPink;
            m.initButtons(new Button[] { button1, button2, button3, button4},
                new Pen[] { Pens.largeDashed(c), Pens.largeDashedArrow(c), Pens.largeSolid(c), Pens.largeSolidArrow(c) });

        }

        public new void Show()
        {
            Visible = true;
            Checkinout = true;
            fadeTimer.Start();
        }

        public new void Hide()
        {
            Checkinout = false;
            fadeTimer.Start();
            Visible = false;

        }

        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            if (Checkinout == false)
            {
                Opacity -= (fadeTimer.Interval / 1000.0);
                if (this.Opacity > 0)
                    fadeTimer.Enabled = true;
                else
                {
                    fadeTimer.Enabled = false;
                    Visible = false;
                }
            }
            else
            {
                Opacity += (fadeTimer.Interval / 1000.0);
                fadeTimer.Enabled = (Opacity < 1.0);
                Checkinout = (Opacity < 1.0);
            }

        }
        private bool Checkinout;

        private void button1_Click(object sender, EventArgs e)
        {
            model.Pen = Pens.largeDashed(model.Color);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            model.Pen = Pens.largeDashedArrow(model.Color);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            model.Pen = Pens.largeSolid(model.Color);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            model.Pen = Pens.largeSolidArrow(model.Color);
        }
    }
}
