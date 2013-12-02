using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace JeffreyJackson_CECS564_2
{
	/// <summary>
	/// Summary description for frmHistogram.
	/// </summary>
	public class frmHistogram : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private AxMSChart20Lib.AxMSChart chartOutput;
		private AxMSChart20Lib.AxMSChart chartInput;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmHistogram(int[] InputData, int[] OutputData)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			chartInput.ChartData = InputData;
			chartOutput.ChartData = OutputData;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmHistogram));
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.chartOutput = new AxMSChart20Lib.AxMSChart();
			this.chartInput = new AxMSChart20Lib.AxMSChart();
			((System.ComponentModel.ISupportInitialize)(this.chartOutput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartInput)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(180, 256);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 24);
			this.label2.TabIndex = 7;
			this.label2.Text = "Output File";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(188, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 24);
			this.label1.TabIndex = 6;
			this.label1.Text = "Input File";
			// 
			// chartOutput
			// 
			this.chartOutput.DataSource = null;
			this.chartOutput.Location = new System.Drawing.Point(12, 288);
			this.chartOutput.Name = "chartOutput";
			this.chartOutput.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("chartOutput.OcxState")));
			this.chartOutput.Size = new System.Drawing.Size(440, 200);
			this.chartOutput.TabIndex = 4;
			// 
			// chartInput
			// 
			this.chartInput.DataSource = null;
			this.chartInput.Location = new System.Drawing.Point(16, 40);
			this.chartInput.Name = "chartInput";
			this.chartInput.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("chartInput.OcxState")));
			this.chartInput.Size = new System.Drawing.Size(440, 200);
			this.chartInput.TabIndex = 8;
			// 
			// frmHistogram
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(464, 496);
			this.Controls.Add(this.chartInput);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.chartOutput);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmHistogram";
			this.Text = "Frequency Distributions";
			((System.ComponentModel.ISupportInitialize)(this.chartOutput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartInput)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
	}
}
