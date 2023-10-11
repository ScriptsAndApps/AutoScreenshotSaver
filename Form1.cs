using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace projectimg
{
    public partial class Form1 : Form
    {
		Random rnd = new Random();
        int bussy = 0;
	   	long Timestamp;
		string subPath = "screenshots";
		string savepath = "";
		bool allowshowdisplay  = false;
		bool canclose = false;
		
		[DllImport("user32.dll")]
		static extern ushort GetAsyncKeyState(int vKey);
		public static bool IsKeyPushedDown(System.Windows.Forms.Keys vKey) {
			return 0 != (GetAsyncKeyState((int)vKey) & 0x8000);
		}
		
        public Form1()
        {
            InitializeComponent();
			this.Visible = false;
			if(subPath == "screenshots"){
				subPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(
					System.Reflection.Assembly.GetExecutingAssembly().Location
				), "screenshots");
			}
			
		}

		protected override void SetVisibleCore(bool value)
		{            
			base.SetVisibleCore(allowshowdisplay ? value : allowshowdisplay);
		}
		
		private void notifyIcon1_DoubleClick(object Sender, EventArgs e) 
	    {
				openfolder();
		}
		

		private void Form1_Closing(object sender, CancelEventArgs e)
		{
				if(!canclose)
				{
					e.Cancel = true;
				}else{
					Application.Exit();
				}
				this.Hide();
				this.menuItem1.Text = "O&pen settings";
		}
		
		private void menuItem1_Click(object Sender, EventArgs e) {
			 allowshowdisplay  =true;
			if(!this.Visible){
			    appshow();
				this.menuItem1.Text = "H&ide settings";
				
			}else{
				this.Hide();
				this.menuItem1.Text = "O&pen settings";
			}
		}
		
		private void menuItem2_Click(object Sender, EventArgs e) {
			openfolder();
		}
		
		private void menuItem3_Click(object Sender, EventArgs e) {
			appclose();
		}
		
	
		
		private void appshow(){
			allowshowdisplay  =true;
			this.Show();
			this.TopMost = true;
			this.Activate();
			this.TopMost = false;
		}
		
		private void appclose(){
			canclose = true;
			this.Close();
			Application.Exit();
		}
		
		private void openfolder(){
				//MessageBox.Show( subPath);
			try{
				System.Diagnostics.Process.Start("explorer.exe", subPath);
			}catch(Exception eed){}
		}
		
		private void timer2_Tick(object sender, EventArgs e)
        {
			bussy=0;
			timer2.Stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
			
			
          if(IsKeyPushedDown(System.Windows.Forms.Keys.Snapshot)){
			   if (bussy==0){
			    Timestamp =  new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
				bussy=1;
				timer2.Start();
				
				System.Windows.Forms.IDataObject data = Clipboard.GetDataObject();

				if (data.GetDataPresent(DataFormats.Bitmap))
				{
					bool exists = System.IO.Directory.Exists(subPath);
					if(!exists){
						System.IO.Directory.CreateDirectory(subPath);
					}
					
					Bitmap bitmap = (data.GetData(DataFormats.Bitmap,true) as Bitmap);
					savepath = subPath+"/"+Timestamp+rnd.Next(100,10000)+"_screenshot.png";
					try{
						bitmap.Save(savepath,System.Drawing.Imaging.ImageFormat.Png);
						//bitmap.Save(subPath+"/"+Timestamp+"image.jpg",System.Drawing.Imaging.ImageFormat.Jpeg);
					}
					catch(Exception ee){}
					try{
						pictureBox1.ImageLocation = savepath;
						pictureBox1.Invalidate();
					}catch(Exception ese){}
				}
				   
			   }
		  }
        } 
      

    }
}
