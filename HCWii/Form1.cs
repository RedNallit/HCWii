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
    public partial class Overlay : Form
    {
        private Model model;

        public Overlay()
        {
            width = Screen.PrimaryScreen.Bounds.Width;
            height = Screen.PrimaryScreen.Bounds.Height;

            InitializeComponent();

            //pictureBox1.Left = width;
            //pictureBox1.Top = height;
            model = new Model(this);
            pictureBox1.Paint += new PaintEventHandler(reDraw);
            t = new Toolbox_();
            tb = new Toolbox(model);
            //tb.Visible = true;
            tb.Opacity = 1;
        }

        private void tmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.Left = width / 2 - t.Width / 2;
            t.Top = 0;
            t.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.Hide();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            tb.Left = width - tb.Width;
            tb.Top = height / 2 - tb.Height / 2;
            tb.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tb.Hide();
            
        }

        private void tmOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            if(openFileDialog.FileName != "")
                ;// bmp = Tools.openFile(openFileDialog.FileName);           
        }

        private void tmSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            Tools.saveFile(saveFileDialog.FileName, pictureBox1.Image);            
        }

        private Point downCoords;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            model.maybeDraw(e.Location);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        public void reDraw(object sender, EventArgs e)
        {
            pictureBox1.Image = model.Backend;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            model.drawSupportLine(e.Location);
        }

        private void Overlay_KeyPress(object sender, KeyPressEventArgs e)
        { 
            System.Console.Out.WriteLine(e.KeyChar);
        }

        private void Overlay_KeyDown(object sender, KeyEventArgs e)
        {
            System.Console.Out.WriteLine(e.KeyValue);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        
        {
            if (msg.WParam.ToInt32() == 0x27) {
                System.Console.Out.WriteLine("RIGHT");
                tb.Show();
            }
            else if (msg.WParam.ToInt32() == 0x26) {
                System.Console.Out.WriteLine("LEFT");
                tb.Hide();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        }     
    }

