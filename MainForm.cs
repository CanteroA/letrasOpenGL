using System;
using System.Windows.Forms;
using System.Drawing;
using OpenGL;

namespace ComputacionGraficaPrimitivas 
{

	class MainForm : System.Windows.Forms.Form
	{
		Primitivas glControl = new Primitivas(true);

		private Timer updateTimer = new Timer();	

		static Form _this = null;

        public static Form App
		{
			get
			{
				if(_this == null)
					_this = new MainForm();
				return _this;
			}
		}

		public MainForm()
		{
			InitializeComponent();
			glControl.Location = new Point(0,0);	
			glControl.Dock = DockStyle.Fill;		
			glControl.Visible = true;

			
			this.Load += new EventHandler(MainForm_Load);	
			this.Closing += new System.ComponentModel.CancelEventHandler(MainForm_Closing);
			this.Controls.Add(glControl);
		}

        void InitializeComponent() {

            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Name = "Computacion Grafica Primitivas 201401";
			this.Text = "Computacion Grafica Primitivas 201401";
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(updateTimer != null)		
				{
					updateTimer.Stop();
					updateTimer.Dispose();
					updateTimer = null;
				}
			}
			base.Dispose( disposing );
		}
		
		private void MainForm_Load(object sender, EventArgs e)
		{
			updateTimer.Interval = 1;
			updateTimer.Tick += new EventHandler(updateTimer_Tick);
			updateTimer.Start();
		}

		private void updateTimer_Tick(object sender, EventArgs e)
		{
			glControl.Invalidate();
		}

		private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(updateTimer != null)
			{
				updateTimer.Stop();
				updateTimer.Dispose();
				updateTimer = null;
			}
		}

		[STAThread]
		public static void Main(string[] args)
		{
            MainForm form = (MainForm)MainForm.App;
			Application.Run(form);
		}
	}			
}
