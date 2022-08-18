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
	public partial class FormAqua : Form
	{
		public FormAqua()
		{
			InitializeComponent();
		}

		private void FormAqua_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			MainPage mainPage = new MainPage();
			mainPage.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			textBoxPDK.Text = "";
			textBoxQ.Text = "";
			textBoxLittleQ.Text = "";
			textBoxV.Text = "";
			textBoxH.Text = "";
			textBoxL.Text = "";
			textBoxC.Text = "";
			//comboBoxComponents.Text = "";
			textBoxK.Text = "";
			textBoxCv.Text = "";
			textBoxCpred.Text = "";
			textBoxPDS.Text = "";
			this.chart1.Series[0].Points.Clear();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			const double E = 1, LfOnLpr = 1;
			//user variables
			double PDK, Q, q, V, H, L, C;
			//required variables
			double K, y, b, a, D, Cv, Cstpred, PDS, F;

			//user insert
			PDK = Convert.ToDouble(textBoxPDK.Text);
			Q = Convert.ToDouble(textBoxQ.Text);
			q = Convert.ToDouble(textBoxLittleQ.Text);
			V = Convert.ToDouble(textBoxV.Text);
			H = Convert.ToDouble(textBoxH.Text);
			L = Convert.ToDouble(textBoxL.Text);
			C = Convert.ToDouble(textBoxC.Text);

			//calculation
			D = (V * H) / 200;
			a = E * (LfOnLpr * Math.Pow(D / q, (1 / 3)));
			b = Math.Exp(-a * Math.Pow(L, (1 / 3)));
			y = (1 - b) / (1 + (Q / q) * b);
			K = (y * Q + q) / q;
			Cv = C / K;
			Cstpred = K * PDK;
			PDS = Cstpred * (q / C);

			//results
			textBoxK.Text = Convert.ToString(Math.Round(K, 4));
			textBoxCv.Text = Convert.ToString(Math.Round(Cv, 4)) + " мг/л";
			textBoxCpred.Text = Convert.ToString(Math.Round(Cstpred, 4)) + " мг/л";
			textBoxPDS.Text = Convert.ToString(Math.Round(PDS, 4)) + " мг/л";

			this.chart1.Series[0].Points.AddXY(0, 0);
			double LS, step = 0;
			LS = L / 5;
			for ( int i = 0; i < 10; i++)
			{
				b = Math.Exp(-a * Math.Pow(step, (1 / 3)));
				y = Math.Round(((1 - b) / (1 + (Q / q) * b)), 2);
				K = Math.Round(((y * Q + q) / q), 2);
				Cv = Math.Round((C / K), 2);
				this.chart1.Series[0].Points.AddXY(LS, Cv);
				step += LS;
			}
			


		}
	}
}
