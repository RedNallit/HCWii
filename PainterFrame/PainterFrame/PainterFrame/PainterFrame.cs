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
        
        
        
        private Model model;


        public PainterFrame()
        {
            InitializeComponent();
            model = new Model(this);
            pictureBox.Paint += new PaintEventHandler(repaint);
            Color c = Color.HotPink;
            model.initButtons(new Button[] { button1, button2, button3, button4, button5, button6, button7, button8 },
                new Pen[] { Pens.largeDashed(c), Pens.largeDashedArrow(c), Pens.largeSolid(c), Pens.largeSolidArrow(c) });
        }

        public void repaint(object sender, PaintEventArgs e) {
                pictureBox.Image = model.Backend;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            model.maybeDraw(e.Location);
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            model.drawSupportLine(e.Location);
        }
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