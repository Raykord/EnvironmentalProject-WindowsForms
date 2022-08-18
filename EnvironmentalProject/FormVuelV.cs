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
	public partial class FormVuelV : Form
	{
		public FormVuelV()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			MainPage mainPage = new MainPage();
			mainPage.Show();
		}

		private void buttonClean_Click(object sender, EventArgs e)
		{
			textK.Text = "";
			textH.Text = "";
			textI.Text = "";
			textM.Text = "";
			textN.Text = "";
			textP.Text = "";
			textResult.Text = "";
			textTb.Text = "";
			textY1.Text = "";
			textY2.Text = "";
		}

		private void buttonResult_Click(object sender, EventArgs e)
		{
			if (textH.Text != string.Empty
				&& textM.Text != string.Empty
				&& textTb.Text != string.Empty
				&& textP.Text != string.Empty
				&& textK.Text != string.Empty
				&& textY1.Text != string.Empty
				&& textY2.Text != string.Empty
				&& textI.Text != string.Empty
				&& textN.Text != string.Empty)
			{
				double m1, m2, m3, m4, mco, Vco, Vist, hx,
					m, T1, P1, K, Y1, Y2, l, n, h, S, res;
				m = Convert.ToDouble(textM.Text);
				T1 = Convert.ToDouble(textTb.Text);
				P1 = Convert.ToDouble(textP.Text);
				K = Convert.ToDouble(textK.Text);
				Y1 = Convert.ToDouble(textY1.Text);
				Y2 = Convert.ToDouble(textY2.Text);
				l = Convert.ToDouble(textI.Text);
				n = Convert.ToDouble(textN.Text);
				h = Convert.ToDouble(textH.Text);

				m1 = m * K;
				m2 = m1 * Y1;
				m3 = m1 * Y2;
				m4 = m2 + m3;
				mco = (m4 * 28) / 12;
				Vco = ((mco / 0.028) * 22.4) / 1000;
				Vist = (760 * Vco * (T1 + 273.15)) / (P1 * 273);
				S = l * n;
				hx = Vist / S;
				res = h - hx;
				if (res >= 0)
					textResult.Text = Convert.ToString(Math.Round(res)) + " м";
				else
					MessageBox.Show("Данные введены некоректно");
			}
			else
			{
				MessageBox.Show("Вы не заполнили какое-то поле");
			}
		}

		private void FormVuelV_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
