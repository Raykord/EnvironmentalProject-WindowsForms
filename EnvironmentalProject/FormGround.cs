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
	public partial class FormGround : Form
	{
		public FormGround()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			MainPage mainPage = new MainPage();
			mainPage.Show();
		}

		private void FormGround_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			textBoxS.Text = "";
			textBoxH.Text = "";
			textBoxPp.Text = "";
			textBoxPoc.Text = "";
			textBoxM.Text = "";
			textBoxH.Text = "";
			textBoxVisota.Text = "";
			textBoxCosCu.Text = "";
			textBoxCcu.Text = "";
			textBoxCmn.Text = "";
			textBoxCv.Text = "";
			textBoxCno3.Text = "";
			textBoxCfcu.Text = "";
			textBoxCfmn.Text = "";
			textBoxCfv.Text = "";
			textBoxCfno3.Text = "";
			textBoxV.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			double s, h, pP, pOc, cCu, cMn, cV, cNo3, cfCu, cfMn, cfV, cfNo3;
			double v, m, mCu, mMn,mV, mNo3, visota, w, cOsCu, cOsMn, cOsV, cOsNo3, cSmCu, cSmMn, cSmV, cSmNo3, mOs;
			s = Convert.ToDouble(textBoxS.Text);
			h = Convert.ToDouble(textBoxH.Text);
			pP = Convert.ToDouble(textBoxPp.Text);
			pOc = Convert.ToDouble(textBoxPoc.Text);
			cCu = Convert.ToDouble(textBoxCcu.Text);
			cMn = Convert.ToDouble(textBoxCmn.Text);
			cV = Convert.ToDouble(textBoxCv.Text);
			cNo3 = Convert.ToDouble(textBoxCno3.Text);
			cfCu = Convert.ToDouble(textBoxCfcu.Text);
			cfMn = Convert.ToDouble(textBoxCfmn.Text);
			cfV = Convert.ToDouble(textBoxCfv.Text);
			cfNo3 = Convert.ToDouble(textBoxCfno3.Text);

			cSmCu = 3;
			cSmMn = 1000;
			cSmV = 150;
			cSmNo3 = 130;
			s *= 10000;

			w = h * s;
			m = w * pP;
			cOsCu = cCu / pOc;
			cOsMn = cMn / pOc;
			cOsV = cV / pOc;
			cOsNo3 = cNo3 / pOc;

			mCu = (m * (cSmCu - cfCu)) / (cOsCu - cSmCu);
			mMn = (m * (cSmMn - cfMn)) / (cOsMn - cSmMn);
			mV = (m * (cSmV - cfV)) / (cOsV - cSmV);
			mNo3 = (m * (cSmNo3 - cfNo3)) / (cOsNo3 - cSmNo3);

			mOs = Math.Min(Math.Min(mCu, mMn), Math.Min(mV, mNo3));
			v = mOs / pOc;
			visota = (v / s) * 100;

			textBoxCosCu.Text = Convert.ToString(Math.Round(cOsCu, 2)) + " м/кг";
			textBoxCosMn.Text = Convert.ToString(Math.Round(cOsMn, 2)) + " м/кг";
			textBoxCosV.Text = Convert.ToString(Math.Round(cOsV, 2)) + " м/кг";
			textBoxCosNo3.Text = Convert.ToString(Math.Round(cOsNo3, 2)) + " м/кг";
			textBoxV.Text = Convert.ToString(Math.Round(v, 2)) + " м^3";
			textBoxVisota.Text = Convert.ToString(Math.Round(visota, 2)) + " см";
			textBoxM.Text = Convert.ToString(Math.Round(mOs, 2)) + " т";
		}
	}
}
