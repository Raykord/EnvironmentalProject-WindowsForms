using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvironmentalProject
{
	public partial class FormDemog : Form
	{
		double M2;
		public FormDemog()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			MainPage mainPage = new MainPage();
			mainPage.Show();
		}

		private void FormDemog_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double Tr, K1, A, E, L, B, K3, K4;
			double[] D = new double[6];

			Tr = Convert.ToDouble(textBoxT.Text);
			K1 = Convert.ToDouble(textBoxK1.Text);
			A = Convert.ToDouble(textBoxA.Text);
			E = Convert.ToDouble(textBoxE.Text);
			L = Convert.ToDouble(textBoxL.Text);
			K3 = Convert.ToDouble(textBoxK3.Text);
			B = Convert.ToDouble(textBoxB.Text);
			K4 = Convert.ToDouble(textBoxK4.Text);


			//D1
			double H1 = 25;
			D[0] = Tr * K1 * 1000 / H1;
			textBoxD1.Text = Convert.ToString(D[0]);

			//D2
			if (comboBox1.Text == "Южный сток") {
				D[1] = E * 0.25 * 1000 / 1500;
				textBoxD2.Text = Convert.ToString(D[1]);
			}
			else
			{
				D[1] = E * 0.25 * 1000 / 1500;
				textBoxD2.Text = Convert.ToString(D[1]);
			}

			//D3
			D[2] = A * Tr * 1000 / 40;
			textBoxD3.Text = Convert.ToString(D[2]);

			//D4
			if (comboBox2.Text == "Умеренный")
			{
				M2 = 0.7;
				D[3] = Tr * L * 0.5 * 10 / (200 * 0.3);
				textBoxD4.Text = Convert.ToString(D[3]);
			}
			else
			{
				M2 = 0.3;
				D[3] = Tr * L * 0.5 * 10 / (200 * 0.1);
				textBoxD4.Text = Convert.ToString(D[3]);
			}

			//D5
			if (comboBox3.Text == "Степная")
			{
				D[4] = 2 * B * 0.3 * 1000 / (0.3 * M2);
				textBoxD5.Text = Convert.ToString(D[4]);
			}
			else
			{
				D[4] = 2 * B * 0.3 * 1000 / (0.5 * M2);
				textBoxD5.Text = Convert.ToString(D[4]);
			}


			//D6
			D[5] = Tr * K3 * K4 * 1000 / 1250;
			textBoxD6.Text = Convert.ToString(D[5]);


			//chart
			this.chart1.Series[0].Points.AddXY(0, 0);
			this.chart1.Series[1].Points.AddXY(0, 0);
			
			for (int i = 0; i < D.Length; i++)
			{
				this.chart1.Series[0].Points.AddXY(i+1, Math.Round(D[i]));
			}
			
			for (int i = 0; i < D.Length; i++)
			{
				if (D.Min() == D[i])
				{
					this.chart1.Series[1].Points.AddXY(i+1, Math.Round(D[i]));
				}
				
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			textBoxT.Text = "";
			textBoxK1.Text = "";
			textBoxA.Text = "";
			textBoxE.Text = "";
			textBoxL.Text = "";
			textBoxK3.Text = "";
			textBoxB.Text = "";
			textBoxK4.Text = "";
			textBoxD6.Text = "";
			textBoxD5.Text = "";
			textBoxD4.Text = "";
			textBoxD3.Text = "";
			textBoxD2.Text = "";
			textBoxD1.Text = "";
			comboBox1.Text = "";
			comboBox2.Text = "";
			comboBox3.Text = "";
		}
	}
}
