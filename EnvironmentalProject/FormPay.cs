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
	public partial class FormPay : Form
	{
		public FormPay()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double m, q, k1, k2, P, P2, Pslo, Pob;
			double Kl = 1.67, Kg = 1.2, f = 0.02, E = 85, Ki = 1.67, Ke = 1.9;
			double[] d = new double[4];
			double[] M = new double[4];
			double[] Ml = new double[4];
			double[] Mh = new double[4];
			double[] Hbl = new double[4];
			double[] Hb = new double[4];
			double[] Ch = new double[4];
			double[] Ph = new double[4];
			double[] Cl = new double[4];
			double[] Pl = new double[4];
			double[] Psl = new double[4];
			d[0] = 0;
			m = Convert.ToDouble(textBoxM.Text);
			q = Convert.ToDouble(textBoxQ.Text);
			k1 = Convert.ToDouble(textBoxK1.Text);
			k2 = Convert.ToDouble(textBoxK2.Text);
			d[1] = Convert.ToDouble(textBoxD2.Text);
			d[2] = Convert.ToDouble(textBoxD3.Text);
			d[3] = Convert.ToDouble(textBoxD4.Text);

			Hbl[0] = 80;
			Hbl[1] = 0.6;
			Hbl[2] = 52;
			Hbl[3] = 80;
			
			

			Hb[0] = 400;
			Hb[1] = 3;
			Hb[2] = 260;
			Hb[3] = 400;
			
			P = 0;
			P2 = 0;
			Pslo = 0;
			for (int i = 0; i < M.Length; i++)
			{ 
				M[i] = d[i] * m * 0.001;
				Mh[i] = k1 * M[i];
				Ml[i] = k2 * M[i];
				Ch[i] = Hbl[i] * Ke * Kg;
				Ph[i] = Ch[i] * Mh[i];
				P += Ch[i];
				Cl[i] = Hb[i] * Ke * Kg;
				Pl[i] = Cl[i] * (Ml[i] - Mh[i]);
				P2 += Pl[i];
				Psl[i] = 5 * Cl[i] * (M[i] - Ml[i]);
				Pslo += Psl[i];
			}

			Pob = (P + P2 + Pslo) * Ki;

			textBoxP.Text = Convert.ToString(P);
			textBoxP2.Text = Convert.ToString(P2);
			textBoxPslo.Text = Convert.ToString(Pslo);
			textBoxPob.Text = Convert.ToString(Pob);

			for (int i = 0; i < M.Length; i++) {
				textBoxMi.Text += "	" + Convert.ToString(M[i]);
				textBoxMh.Text += "	" + Convert.ToString(Mh[i]);
				textBoxMl.Text += "	" + Convert.ToString(Ml[i]);
				textBoxHbl.Text += "	" + Convert.ToString(Hbl[i]);
				textBoxHb.Text += "	" + Convert.ToString(Hb[i]);
				textBoxCh.Text += "	" + Convert.ToString(Ch[i]);
				textBoxPh.Text += "	" + Convert.ToString(Ph[i]);
				textBoxCl.Text += "	" + Convert.ToString(Cl[i]);
				textBoxMminM.Text += "	" + Convert.ToString(Ml[i] - Mh[i]);
				textBoxPl.Text += "	" + Convert.ToString(Pl[i]);
				textBoxMminM2.Text += "	" + Convert.ToString(M[i] - Ml[i]);
				textBoxPsl.Text += "	" + Convert.ToString(Psl[i]);
			}
		}

		private void FormPay_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			MainPage mainPage = new MainPage();
			mainPage.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			textBoxMi.Text = "";
			textBoxMh.Text = "";
			textBoxMl.Text = "";
			textBoxHbl.Text = "";
			textBoxHb.Text = "";
			textBoxCh.Text = "";
			textBoxPh.Text = "";
			textBoxCl.Text = "";
			textBoxMminM.Text = "";
			textBoxPl.Text = "";
			textBoxMminM2.Text = "";
			textBoxPsl.Text = "";
			textBoxP.Text = "";
			textBoxP2.Text = "";
			textBoxPslo.Text = "";
			textBoxPob.Text = "";
			textBoxM.Text = "";
			textBoxQ.Text = "";
			textBoxK1.Text = "";
			textBoxK2.Text = "";
			textBoxD2.Text = "";
			textBoxD3.Text = "";
			textBoxD4.Text = "";
		}
	}
}
