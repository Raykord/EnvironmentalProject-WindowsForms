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
	public partial class FormAutecol : Form
	{
		static int counterD = 0, counterL = 0;
		public FormAutecol()
		{
			InitializeComponent();
		}

		private void FormAutecol_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			MainPage mainPage = new MainPage();
			mainPage.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int tMax, veetMax, tMin, veetMin;
			int[] tDeath = new int[] { 10, 4, 15, 28, 36, 37 };
			int[] veetDeath = new int[] { 100, 80, 40, 15, 55, 100 };
			int[] tMinDeath = new int[] { 20, 22, 27, 26, 22, 30 };
			int[] veetMinDeath = new int[] { 85, 95, 55, 55, 70, 80 };
			this.chart1.Series[0].Points.Clear();
			this.chart1.Series[1].Points.Clear();

			for (int i = 0; i < tDeath.Length; i++)
			{
				this.chart1.Series[0].Points.AddXY(tDeath[i], veetDeath[i]);
				this.chart1.Series[1].Points.AddXY(tMinDeath[i], veetMinDeath[i]);
			}

			tMin = Convert.ToInt32(textBoxTmin.Text);
			tMax = Convert.ToInt32(textBoxTmax.Text);
			veetMin = Convert.ToInt32(textBoxVeetMin.Text); 
			veetMax = Convert.ToInt32(textBoxVeetMax.Text);

			for (int i = veetMin; i <= veetMax; i++)
			{
				//this.chart1.Series[2].Points.AddXY(tMin, veetMin);
			
				for (int z = tMin; z <= tMax; z++)
				{
					this.chart1.Series[2].Points.AddXY(z, i);
				}
			}
		}
	}
}
