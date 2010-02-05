using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HCWii
{
    public partial class Toolbox_ : Form
    {
        public Toolbox_()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

            colorDialog1.ShowDialog();
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
    }
}
