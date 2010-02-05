namespace HCWii
{
    partial class Overlay
    {

        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overlay));
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tmSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.trayMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tray
            // 
            this.tray.ContextMenuStrip = this.trayMenu;
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Tag = "";
            this.tray.Text = "HCWii";
            this.tray.Visible = true;
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmNew,
            this.tmSave,
            this.tmOpen,
            this.tmSeparator,
            this.tmExit});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(101, 98);
            // 
            // tmNew
            // 
            this.tmNew.Image = global::HCWii.Properties.Resources._new;
            this.tmNew.Name = "tmNew";
            this.tmNew.Size = new System.Drawing.Size(100, 22);
            this.tmNew.Text = "New";
            // 
            // tmSave
            // 
            this.tmSave.Image = global::HCWii.Properties.Resources.save;
            this.tmSave.Name = "tmSave";
            this.tmSave.Size = new System.Drawing.Size(100, 22);
            this.tmSave.Text = "Save";
            this.tmSave.Click += new System.EventHandler(this.tmSave_Click);
            // 
            // tmOpen
            // 
            this.tmOpen.Image = global::HCWii.Properties.Resources.open;
            this.tmOpen.Name = "tmOpen";
            this.tmOpen.Size = new System.Drawing.Size(100, 22);
            this.tmOpen.Text = "Open";
            this.tmOpen.Click += new System.EventHandler(this.tmOpen_Click);
            // 
            // tmSeparator
            // 
            this.tmSeparator.Name = "tmSeparator";
            this.tmSeparator.Size = new System.Drawing.Size(97, 6);
            // 
            // tmExit
            // 
            this.tmExit.Image = global::HCWii.Properties.Resources.exit;
            this.tmExit.Name = "tmExit";
            this.tmExit.Size = new System.Drawing.Size(100, 22);
            this.tmExit.Text = "Exit";
            this.tmExit.Click += new System.EventHandler(this.tmExit_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "bmp";
            this.saveFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg";
            this.saveFileDialog.InitialDirectory = "%CSIDL_MYPICTURES%";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All valid files (*.bmp;*.jpg)" +
                "|*.bmp;*.jpg";
            this.openFileDialog.InitialDirectory = "%CSIDL_MYPICTURES%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Lime;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 213);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(476, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(472, 335);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 32);
            this.button4.TabIndex = 9;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(119)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(646, 471);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Overlay";
            this.ShowInTaskbar = false;
            this.Text = "HCWii";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(119)))), ((int)(((byte)(128)))));
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Overlay_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Overlay_KeyDown);
            this.trayMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem tmSave;
        private System.Windows.Forms.ToolStripMenuItem tmOpen;
        private System.Windows.Forms.ToolStripSeparator tmSeparator;
        private System.Windows.Forms.ToolStripMenuItem tmExit;
        private System.Windows.Forms.ToolStripMenuItem tmNew;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox pictureBox1;

        private int width, height;
        private Toolbox_ t;
        private Toolbox tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;


    }
}

