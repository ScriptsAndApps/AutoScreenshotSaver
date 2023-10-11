namespace projectimg
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
	        this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
			
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
		    this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
				this.menuItem1,
				this.menuItem2,
				this.menuItem3,
				});

			this.menuItem1.Index = 0; 
			this.menuItem1.Text ="O&pen settings";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);

			this.menuItem2.Index = 1;
			this.menuItem2.Text = "O&poen folder";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);

			this.menuItem3.Index = 2;
			this.menuItem3.Text = "E&xit";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);

			this.notifyIcon1.Icon = this.Icon;

			this.notifyIcon1.ContextMenu = this.contextMenu1;

			// The Text property sets the text that will be displayed,
			// in a tooltip, when the mouse hovers over the systray icon.
			this.notifyIcon1.Text = "Form1 (NotifyIcon example)";
			this.notifyIcon1.Visible = true;

			// Handle the DoubleClick event to activate the form.
			this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
		
				
            // 
            // pictureBox1
            // 
            //this.pictureBox1.ImageLocation = "bg.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            //this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            //this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            //this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            //this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);

            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.timer2.Enabled = true;
            this.timer2.Interval = 100;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // locatint
            
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 500);
		
		
		
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutoScreenshotSaver";
            this.Text = "Auto Screenshot Saver Settings";
			
           // this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		   
           // this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            //this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
           // this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
           // this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
           // this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
          //  this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
          //  this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
         //   this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
          //  this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
			

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenu contextMenu1;
	    private System.Windows.Forms.MenuItem menuItem1;
	    private System.Windows.Forms.MenuItem menuItem2;
	    private System.Windows.Forms.MenuItem menuItem3;
	    private System.Windows.Forms.MenuItem menuItem4;
        private System.ComponentModel.IContainer components2;
    }
}

