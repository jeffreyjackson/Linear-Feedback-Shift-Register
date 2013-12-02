using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.IO;
namespace JeffreyJackson_CECS564_2
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmLFSR : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtKeyword;
		private System.Windows.Forms.Label lblKeyword;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnApply;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.TextBox txtPrimitivePolynomial;
		private System.Windows.Forms.Label lblPrimitivePolynomial;
		private System.Windows.Forms.Button btnCharts;

		private int[] intFrequencyDistribution_In = new int[256];
		private int[] intFrequencyDistribution_Out = new int[256];

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmLFSR()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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
				if (components != null) 
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
			this.txtKeyword = new System.Windows.Forms.TextBox();
			this.lblKeyword = new System.Windows.Forms.Label();
			this.btnApply = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.txtPrimitivePolynomial = new System.Windows.Forms.TextBox();
			this.lblPrimitivePolynomial = new System.Windows.Forms.Label();
			this.btnCharts = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtKeyword
			// 
			this.txtKeyword.Location = new System.Drawing.Point(104, 32);
			this.txtKeyword.Name = "txtKeyword";
			this.txtKeyword.Size = new System.Drawing.Size(80, 20);
			this.txtKeyword.TabIndex = 0;
			this.txtKeyword.Text = "";
			this.txtKeyword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
			// 
			// lblKeyword
			// 
			this.lblKeyword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblKeyword.Location = new System.Drawing.Point(100, 8);
			this.lblKeyword.Name = "lblKeyword";
			this.lblKeyword.Size = new System.Drawing.Size(88, 24);
			this.lblKeyword.TabIndex = 2;
			this.lblKeyword.Text = "Keyword";
			// 
			// btnApply
			// 
			this.btnApply.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnApply.Location = new System.Drawing.Point(68, 128);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(152, 32);
			this.btnApply.TabIndex = 4;
			this.btnApply.Text = "Stream Cipher";
			this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
			// 
			// txtPrimitivePolynomial
			// 
			this.txtPrimitivePolynomial.Location = new System.Drawing.Point(40, 96);
			this.txtPrimitivePolynomial.Name = "txtPrimitivePolynomial";
			this.txtPrimitivePolynomial.Size = new System.Drawing.Size(208, 20);
			this.txtPrimitivePolynomial.TabIndex = 7;
			this.txtPrimitivePolynomial.Text = "";
			this.txtPrimitivePolynomial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblPrimitivePolynomial
			// 
			this.lblPrimitivePolynomial.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblPrimitivePolynomial.Location = new System.Drawing.Point(32, 64);
			this.lblPrimitivePolynomial.Name = "lblPrimitivePolynomial";
			this.lblPrimitivePolynomial.Size = new System.Drawing.Size(224, 24);
			this.lblPrimitivePolynomial.TabIndex = 8;
			this.lblPrimitivePolynomial.Text = "Primitive Polynomial";
			this.lblPrimitivePolynomial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCharts
			// 
			this.btnCharts.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnCharts.Location = new System.Drawing.Point(68, 168);
			this.btnCharts.Name = "btnCharts";
			this.btnCharts.Size = new System.Drawing.Size(152, 32);
			this.btnCharts.TabIndex = 9;
			this.btnCharts.Text = "Histograms";
			this.btnCharts.Click += new System.EventHandler(this.btnCharts_Click);
			// 
			// frmLFSR
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(296, 206);
			this.Controls.Add(this.btnCharts);
			this.Controls.Add(this.lblPrimitivePolynomial);
			this.Controls.Add(this.txtPrimitivePolynomial);
			this.Controls.Add(this.btnApply);
			this.Controls.Add(this.lblKeyword);
			this.Controls.Add(this.txtKeyword);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLFSR";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Linear Feedback Shift Register";
			this.Load += new System.EventHandler(this.frmLFSR_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmLFSR());
		}

		private void frmLFSR_Load(object sender, System.EventArgs e)
		{
			//Assignment: Use Primitive Polynomial = x^32 + x^7 + x^5 + x^3 + x^2 + x + 1
			this.txtPrimitivePolynomial.Text = "10000000000000000000000001010111";
		}

		private bool CheckKeyword()
		{
			bool blnInputValid = true;
			bool blnStillZero = true;
			foreach (char c in this.txtKeyword.Text.ToString().ToUpper())
			{
				switch(c)
				{
					case '0':
						break;
					case '1':
					case '2':
					case '3':
					case '4':
					case '5':
					case '6':
					case '7':
					case '8':
					case '9':
					case 'A':
					case 'B':
					case 'C':
					case 'D':
					case 'E':
					case 'F':
						blnInputValid = true;
						blnStillZero = false;
						break;
					default:
						blnInputValid = false;
						break;
				}
				if (blnInputValid == false)
				{
					return false;
				}
			}
			if (blnStillZero == true)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		private void btnApply_Click(object sender, System.EventArgs e)
		{
			bool blnInputValid = CheckKeyword();
			if (blnInputValid == true)
			{
				FileStream fsIncomingFile = null;
				FileStream fsOutgoingFile = null;
				LinearFeedbackShiftRegister LFSR = new LinearFeedbackShiftRegister(this.txtKeyword.Text, this.txtPrimitivePolynomial.Text);
				openFileDialog1.Title = "Open Input File for Cipher Stream";
				saveFileDialog1.Title = "Save Output File of Cipher Stream";
				if(openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					if(saveFileDialog1.ShowDialog() == DialogResult.OK)
					{
						fsIncomingFile = new FileStream(this.openFileDialog1.FileName,FileMode.Open);
						fsOutgoingFile = new FileStream(this.saveFileDialog1.FileName,FileMode.Create);
						LFSR.CipherStream(ref fsIncomingFile, ref fsOutgoingFile, this.txtKeyword.TextLength);
						intFrequencyDistribution_In = LFSR.GetInputFrequencyDistribution();
						intFrequencyDistribution_Out = LFSR.GetOutputFrequencyDistribution();
						System.Windows.Forms.MessageBox.Show("Stream Cipher Completed Successfully!","Stream Closed");
					}
				}
			}
			else
			{
				System.Windows.Forms.MessageBox.Show("Please enter a valid keyword in Bytes", "Invalid Input");
				this.txtKeyword.Text = "";
				this.txtKeyword.Focus();
			}
		}

		private void txtKeyword_TextChanged(object sender, System.EventArgs e)
		{
			if (this.txtKeyword.TextLength == 8)
			{
				this.txtKeyword.Text = this.txtKeyword.Text.ToUpper();
			}
			else if (this.txtKeyword.TextLength > 8)
			{
				this.txtKeyword.Text = this.txtKeyword.Text.Remove(this.txtKeyword.TextLength-1,1);
			}
		}

		private void btnCharts_Click(object sender, System.EventArgs e)
		{
			frmHistogram ChartsDisplay = new frmHistogram(intFrequencyDistribution_In,intFrequencyDistribution_Out);
			ChartsDisplay.Show();
		}
	}

	public class BinaryAndByteConverter
	{
		public string FromByteToBinary(byte byteInput)
		{
			StringBuilder strBits = new StringBuilder();
			int intMask = 1 << 31;
			int intByte = Convert.ToInt32(Convert.ToString(byteInput,10));
			for (int i=1; i<=32; i++)
			{
				strBits.Append((intByte & intMask) == 0 ? "0" : "1");
				intByte <<= 1;
			}
			return strBits.Remove(0,24).ToString();
		}

		public int FromByteToDecimal(byte byteInput)
		{
			return Convert.ToInt32(Convert.ToString(byteInput,10));
		}

		public byte FromBinaryToByte(string strBits)
		{
			return Convert.ToByte(strBits,2);
		}

		public string FromCharArrayToBinary(ref char[] charStreamBuffer, int intPosition)
		{
			string strByte = null;
			for (int i=0; i<8; i++)
			{
				strByte = strByte + charStreamBuffer[intPosition*8+i].ToString();
			}
			return strByte;
		}

		public byte FromCharArrayToByte(char[] charPartition)
		{
			return Convert.ToByte(charPartition[0].ToString()  + charPartition[1].ToString(),16);
		}
	}

	public class LinearFeedbackShiftRegister
	{
		private char[] charBinaryRegister;	//Register in Binary
		private char[] charPrimitivePolynomial;
		private int[] intInputFrequencyDistribution = new int[256];
		private int[] intOutputFrequencyDistribution = new int[256];
		private char[] charKeyword;			//Register in Hexadecimal
		private string strRegister;			//         ""
		BinaryAndByteConverter BinaryConverter = new BinaryAndByteConverter();
		private int intBufferSize;

		public LinearFeedbackShiftRegister(string strKeyword, string strPrimitivePolynomial)
		{			
			intBufferSize = 4 * strKeyword.Length;
			charBinaryRegister = new char[intBufferSize];
			charPrimitivePolynomial = new char[intBufferSize];
			charPrimitivePolynomial = strPrimitivePolynomial.ToCharArray();
			strRegister = strKeyword.Replace(" ","");
			charKeyword = strRegister.ToCharArray();
			SeedRegister(ref charBinaryRegister, charKeyword);
		}

		private void SeedRegister(ref char[] charBinaryRegister, char[] charKeyword)
		{
			char[] charByte = new char[2];
			int intBytePosition = 0;
			for(int i = charKeyword.GetLowerBound(0); i<charKeyword.GetUpperBound(0);)
			{
				charByte[0] = charKeyword[i+0];
				charByte[1] = charKeyword[i+1];
				UpdateBinaryPartition(intBytePosition, BinaryConverter.FromByteToBinary(BinaryConverter.FromCharArrayToByte(charByte)).ToCharArray(), ref charBinaryRegister); 
				i=i+2;
				intBytePosition = intBytePosition +1;
			}
		}

		private void UpdateBinaryPartition(int intBytePosition, char[] charPartition, ref char[] charBinaryString)
		{
			charBinaryString[intBytePosition*8+0] = charPartition[0];
			charBinaryString[intBytePosition*8+1] = charPartition[1];
			charBinaryString[intBytePosition*8+2] = charPartition[2];
			charBinaryString[intBytePosition*8+3] = charPartition[3];
			charBinaryString[intBytePosition*8+4] = charPartition[4];
			charBinaryString[intBytePosition*8+5] = charPartition[5];
			charBinaryString[intBytePosition*8+6] = charPartition[6];
			charBinaryString[intBytePosition*8+7] = charPartition[7];
		}

		private void AddToInputFrequencyDistribution(byte byteInput)
		{
			int intIndex = BinaryConverter.FromByteToDecimal(byteInput);
			intInputFrequencyDistribution[intIndex] = intInputFrequencyDistribution[intIndex] + 1;
		}

		private void AddToOutputFrequencyDistribution(byte byteInput)
		{
			int intIndex = BinaryConverter.FromByteToDecimal(byteInput);
			intOutputFrequencyDistribution[intIndex] = intOutputFrequencyDistribution[intIndex] + 1;
		}

		public int[] GetInputFrequencyDistribution()
		{
			return intInputFrequencyDistribution;
		}

		public int[] GetOutputFrequencyDistribution()
		{
			return intOutputFrequencyDistribution;
		}

		private void ShiftRegister(ref char[] charBuffer, ref char charInsert)
		{
			for (int i = 0;i<charBuffer.GetUpperBound(0);i++)
			{
				charBuffer[i] = charBuffer[i+1];
			}
			charBuffer[intBufferSize-1] = charInsert;
		}

		private void AlgorithmLFSR(ref char[] charStreamBuffer, ref char[] charRegister)
		{
			char[] charUpdatedRegister = charRegister;
			for (int j=0; j<intBufferSize; j++)
			{
				//charBit is used to collect the first LHS in the XOR gate
				char charBit = '.';
				for (int i=0; i<intBufferSize; i++)
				{
					if (charPrimitivePolynomial[i] == '1')
					{
						//Begin XOR sequence after the first LHS has been collected
						if (charBit != '.')
						{
							if (charBit != charRegister[i])
							{
								charBit = '1';
							}
							else
							{
								charBit = '0';
							}
						}
						//Collect the LHS here first
						else
						{
							charBit = charRegister[i];
						}
					}
				}
				//ShiftRegister will update the buffer and insert new bit
				ShiftRegister(ref charUpdatedRegister,ref charBit);
			}
			for(int i=0; i<intBufferSize; i++)
			{
				if(charRegister[i] != charStreamBuffer[i])
				{
					charStreamBuffer[i] = '1';
				}
				else
				{
					charStreamBuffer[i] = '0';
				}
			}
			charRegister = charUpdatedRegister;
		}

		public void CipherStream(ref FileStream strmInput, ref FileStream strmOutput, int intLength)
		{
			BufferedStream bufferedInput = new BufferedStream(strmInput);
			BufferedStream bufferedOutput = new BufferedStream(strmOutput);
			byte[] byteInput = new byte[intLength/2];
			byte[] byteOutput = new byte[intLength/2];
			char[] charStreamBuffer = new char[intLength*4];
			int intNumOfBytesToWrite = 0;
			while((intNumOfBytesToWrite = bufferedInput.Read(byteInput,0,intLength/2))>0)
			{
				for(int i=0; i<intLength/2; i++)
				{
					AddToInputFrequencyDistribution(byteInput[i]);
					UpdateBinaryPartition(i,BinaryConverter.FromByteToBinary((byteInput[i])).ToCharArray(), ref charStreamBuffer);
				}

				AlgorithmLFSR(ref charStreamBuffer, ref charBinaryRegister);
				
				for(int i=0; i<intLength/2; i++)
				{
					byteOutput[i] = BinaryConverter.FromBinaryToByte(BinaryConverter.FromCharArrayToBinary(ref charStreamBuffer,i));
					AddToOutputFrequencyDistribution(byteOutput[i]);
				}
				bufferedOutput.Write(byteOutput,0,intNumOfBytesToWrite);
			}
			bufferedInput.Close();
			bufferedOutput.Close();
			strmInput.Close();
			strmOutput.Close();
		}
	}
}