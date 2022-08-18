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
	public partial class FormAtmos : Form
	{
		public static int numberOfElement;
		public static double n, u, d, PDKss;
		public FormAtmos()
		{
			InitializeComponent();
		}

		private void FormAtmos_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			MainPage mainPage = new MainPage();
			mainPage.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBoxC.Text = "";
			textBoxM.Text = "";
			textBoxQ.Text = "";
			textBoxT.Text = "";
			textBoxH.Text = "";
			textBoxD.Text = "";
			textBoxCm.Text = "";
			textBoxXXm.Text = "";
			textBoxPVD.Text = "";
			comboBoxElements.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBoxC.Text != string.Empty
			&& textBoxM.Text != string.Empty
			&& textBoxQ.Text != string.Empty
			&& textBoxT.Text != string.Empty
			&& textBoxH.Text != string.Empty
			&& textBoxD.Text != string.Empty
			&& comboBoxElements.Text != string.Empty)
			{
				const double A = 140, F = 1, nRel = 1;
				double Cf, M, Q, deltaT, H, D, Cm, m, f, w0, vm, X, PVD;
				Cf = Convert.ToDouble(textBoxC.Text);
				M = Convert.ToDouble(textBoxM.Text);
				Q = Convert.ToDouble(textBoxQ.Text);
				deltaT = Convert.ToDouble(textBoxT.Text);
				H = Convert.ToDouble(textBoxH.Text);
				D = Convert.ToDouble(textBoxD.Text);
				switch (comboBoxElements.Text)
				{
					case "Оксид азота":
						numberOfElement = 1;
						PDKss = 0.06;
						break;
					case "Оксид углерода":
						numberOfElement = 2;
						PDKss = 3;
						break;
					case "Диоксид азота":
						numberOfElement = 3;
						PDKss = 0.04;
						break;
					case "Диоксид серы":
						numberOfElement = 4;
						PDKss = 0.05;
						break;
				}
				w0 = (4 * Q) / (Math.PI * Math.Pow(D, 2));
				f = 1000 * ((Math.Pow(w0, 2) * D) / (Math.Pow(H, 2) * deltaT));
				m = 1 / (0.67 + 0.1 * Math.Sqrt(f) + 0.34 * Math.Pow(f, 1 / 3));
				vm = 0.65 * Math.Pow((Q * deltaT) / H, 1 / 3);
				if (vm >= 2)
				{
					n = 1;
					d = 7 * Math.Sqrt(vm) * (1 + 0.28 * Math.Pow(f, 1 / 3));
				}
				else if (vm >= 0.5 && vm < 2)
				{
					n = 0.532 * Math.Pow(vm, 2) - 2.13 * vm + 3.13;
					d = 4.95 * vm * (1 + 0.28 * Math.Pow(f, 1 / 3));
				}
				else if (vm < 0.5)
				{
					n = 4.4 * vm;
					d = 2.48 * (1 + 0.28 * Math.Pow(f, 1 / 3));
				}
				//1
				Cm = (A * M * F * m * n * nRel) / (Math.Pow(H, 2) * Math.Pow(Q * deltaT, 1 / 3));
				textBoxCm.Text = Convert.ToString(Math.Round(Cm, 2));

				//2
				X = (5 - F) * d * H / 4;
				textBoxXm.Text = Convert.ToString(Math.Round(X, 2));

				//3

				//4

				PVD = (PDKss - Cf) * ((Math.Pow(H, 2) * Math.Pow(Q * deltaT, 1 / 3)) / (A * F * m * n * nRel));
				textBoxPVD.Text = Convert.ToString(Math.Round(PVD, 2));
			}
			else
			{
				MessageBox.Show("Вы не заполнили какое-то поле");
			}
		}

	}
}
