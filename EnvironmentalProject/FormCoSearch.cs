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
	public partial class FormCoSearch : Form
	{
		public FormCoSearch()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			comboBox1.Text = "";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double D, h, p;
			D = Convert.ToDouble(textBox1.Text);
			h = Convert.ToDouble(textBox2.Text);

			switch (comboBox1.Text)
			{
				case "Липа":
					p = 0.45;
					textBox3.Text = Convert.ToString(calculete(D, h, p)) + " метров кубических";
					break;
				case "Сосна":
					p = 0.5;
					textBox3.Text = Convert.ToString(calculete(D, h, p)) + " метров кубических";
					break;
				case "Бук":
					p = 0.65;
					textBox3.Text = Convert.ToString(calculete(D, h, p)) + " метров кубических";
					break;
				case "Дуб":
					p = 0.7;
					textBox3.Text = Convert.ToString(calculete(D, h, p)) + " метров кубических";
					break;
				case "Орех":
					p = 0.66;
					textBox3.Text = Convert.ToString(calculete(D, h, p)) + " метров кубических";
					break;
				case "Груша":
					p = 0.725;
					textBox3.Text = Convert.ToString(calculete(D, h, p)) + " метров кубических";
					break;
				case "Ясень":
					p = 0.74;
					textBox3.Text = Convert.ToString(calculete(D, h, p)) + " метров кубических";
					break;
				case "Клен":
					p = 0.7;
					textBox3.Text = Convert.ToString(calculete(D, h, p)) + " метров кубических";
					break;
				case "Кл.дерево":
					p = 0.7;
					textBox3.Text = Convert.ToString(calculete(D, h, p)) + " метров кубических";
					break;
				case "Акация":
					p = 0.7;
					textBox3.Text = Convert.ToString(calculete(D, h, p)) + " метров кубических";
					break;
			}
		}

		public double calculete(double D, double h, double p)
		{
			double m, m2, Vco;
			m = Math.PI * Math.Sqrt(D / 2) * h * p;
			m2 = (m * 44) / 12;
			Vco = (m2 / 0.044) * 22.4;
			return Math.Round(Vco) / 1000;
		}

		private void FormCoSearch_FormClosed_1(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			MainPage mainPage = new MainPage();
			mainPage.Show();
		}
	}
}
