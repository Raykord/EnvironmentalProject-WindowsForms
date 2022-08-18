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
	public partial class FormCyclone : Form
	{
		public static double d50, wop, dt50, lgbt, k1, k2, l500, D, ng, F, n = 1, Cvhc;
		public FormCyclone()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			MainPage mainPage = new MainPage();
			mainPage.Show();
		}

		private void FormCyclone_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			textBoxQ.Text = "";
			textBoxP.Text = "";
			textBoxU.Text = "";
			textBoxLg.Text = "";
			textBoxDm.Text = "";
			textBoxCvh.Text = "";
			textBoxPch.Text = "";
			textBoxNg.Text = "";
			comboBox1.Text = "";
			textBoxD.Text = "";
			textBoxW.Text = "";
			textBoxDeltaP.Text = "";
			textBoxNgr.Text = "";
			textBoxCvih.Text = "";
			textBoxResult.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			//constants
			const double Dt = 0.6, pcht = 1930, ut = 22.2, wt = 3.5;
			//user variabels
			double Q, p, u, dm, lgb, Cvh, pch;
			//just variabels
			double w, l, deltaP, X, ngRasch, Cvih;

			//insert
			Q = Convert.ToDouble(textBoxQ.Text);
			p = Convert.ToDouble(textBoxP.Text);
			u = Convert.ToDouble(textBoxU.Text);
			lgb = Convert.ToDouble(textBoxLg.Text);
			dm = Convert.ToDouble(textBoxDm.Text);
			Cvh = Convert.ToDouble(textBoxCvh.Text);
			pch = Convert.ToDouble(textBoxPch.Text);
			ng = Convert.ToDouble(textBoxNg.Text);

			//вытаскиваю wop, dt50, lgbt, l500
			switch (comboBox1.Text)
			{
				case "ЦН-24":
					wop = 4.5;
					dt50 = 8.5;
					lgbt = 0.308;
					l500 = 75;
					break;
				case "ЦН-15У":
					wop = 3.5;
					dt50 = 6;
					lgbt = 0.283;
					l500 = 155;
					break;
				case "ЦН-15":
					wop = 3.5;
					dt50 = 4.5;
					lgbt = 0.352;
					l500 = 155;
					break;
				case "ЦН-11":
					wop = 3.5;
					dt50 = 6.35;
					lgbt = 0.352;
					l500 = 245;
					break;
				case "СДК-ЦН-33":
					wop = 2;
					dt50 = 2.31;
					lgbt = 0.364;
					l500 = 520;
					break;
				case "СДК-ЦН-34":
					wop = 1.7;
					dt50 = 1.95;
					lgbt = 0.308;
					l500 = 1050;
					break;
				case "СДК-ЦН-34м":
					wop = 2;
					dt50 = 1.3;
					lgbt = 0.340;
					l500 = 1050;
					break;
			}
			//calculation
			//if (dm > 2*dt50)
			//{
				Math.Round(D = Math.Sqrt((4 * Q) / (Math.PI * wop)), 3); //диаметр буде 0.xx
				D *= 1000;
				if (D > 3000)
				{
					D /= 2;
					n = 2;
				}
				//тупая проверка для приведения диаметра к типовым значениям
				if (D < 100)
				{
					textBoxResult.Text = "Циклон не подходит, маленький диаметр";
					return;
				}
				else if (D > 150)
				{
					int counter = 100;
					while (counter < 3000)
					{
						if (counter < 1000)
						{
							if (D < counter + 50)
							{
								D = counter;
							}
							else
							{
								D = counter + 100;
							}
							counter += 100;
						}
						else if (counter < 2000)
						{
							if (D < counter + 100)
							{
								D = counter;
							}
							else
							{
								D = counter + 200;
							}
							counter += 200;
						}
						else if (counter < 2400)
						{
							if (D < counter + 400)
							{
								D = counter;
							}
							else
							{
								D = counter + 400;
							}
							counter += 400;
						}
						else
						{
							if (D < counter + 400)
							{
								D = counter;
							}
							else
							{
								D = counter + 400;
							}
							counter = 3000;
						}
					}
				}
				else
				{
					D = 150;
				}
				D /= 1000;

				//вычисляем w
				w = 4 * Q / (Math.PI * n * Math.Pow(D, 2));
				//считаю отклонение от нормы
				double otkl;
				otkl = Math.Round((wop / w) * 100 - 100);
				/*if (otkl > 15 || otkl < -15)
				{
					textBoxResult.Text = "Циклон не подходит, действительная скорость сильно отклоняется от оптимальной";
					return;
				}*/

				//вытаскиваю k1
				if (comboBox1.Text == "ЦН-11")
				{
					switch (D)
					{
						case 150:
							k1 = 0.94;
							break;
						case 200:
							k1 = 0.95;
							break;
						case 300:
							k1 = 0.96;
							break;
						case 450:
							k1 = 0.94;
							break;
						default:
							k1 = 1;
							break;
					}
				}
				else if (comboBox1.Text == "ЦН-15У" || comboBox1.Text == "ЦН-15" || comboBox1.Text == "ЦН-24")
				{
					switch (D)
					{
						case 150:
							k1 = 0.85;
							break;
						case 200:
							k1 = 0.09;
							break;
						case 300:
							k1 = 0.93;
							break;
						case 450:
							k1 = 1;
							break;
						default:
							k1 = 1;
							break;
					}
				}
				else
				{
					switch (D)
					{
						case 150:
							k1 = 1;
							break;
						case 200:
							k1 = 1;
							break;
						case 300:
							k1 = 1;
							break;
						case 450:
							k1 = 1;
							break;
						default:
							k1 = 1;
							break;
					}
				}
				
				//вытаскиваю k2
				if (comboBox1.Text == "ЦН-11")
				{
				if (Cvh < 10)
					Cvhc = 0;
				else if (Cvh < 20 && Cvh >= 10)
				{
					Cvhc = 10;
				}
				else if (Cvh < 30 && Cvh >= 15)
				{
					Cvhc = 20;
				}
				else if (Cvh < 80 && Cvh >= 20)
				{
					Cvhc = 40;
				}
				else if (Cvh < 120 && Cvh >= 80)
				{
					Cvhc = 80;
				}
				else if (Cvh < 150 && Cvh >= 120)
				{
					Cvhc = 120;
				}
				else if (Cvh >= 150)
				{
					Cvhc = 150;
				}

				switch (Cvhc)
					{
						case 0:
							k2 = 1;
							break;
						case 10:
							k2 = 0.96;
							break;
						case 20:
							k2 = 0.94;
							break;
						case 40:
							k2 = 0.92;
							break;
						case 80:
							k2 = 0.90;
							break;
						case 120:
							k2 = 0.87;
							break;
						case 150:
							k2 = 0;
							break;
					}
				}
				else if (comboBox1.Text == "ЦН-15")
				{
					switch (Cvhc)
					{
						case 0:
							k2 = 1;
							break;
						case 10:
							k2 = 0.93;
							break;
						case 20:
							k2 = 0.92;
							break;
						case 40:
							k2 = 0.91;
							break;
						case 80:
							k2 = 0.90;
							break;
						case 120:
							k2 = 0.87;
							break;
						case 150:
							k2 = 0.86;
							break;
					}
				}
				else if (comboBox1.Text == "ЦН-15У")
				{
					switch (Cvhc)
					{
						case 0:
							k2 = 1;
							break;
						case 10:
							k2 = 0.93;
							break;
						case 20:
							k2 = 0.92;
							break;
						case 40:
							k2 = 0.91;
							break;
						case 80:
							k2 = 0.89;
							break;
						case 120:
							k2 = 0.88;
							break;
						case 150:
							k2 = 0.87;
							break;
					}
				}
				else if (comboBox1.Text == "ЦН-24")
				{
					switch (Cvhc)
					{
						case 0:
							k2 = 1;
							break;
						case 10:
							k2 = 0.95;
							break;
						case 20:
							k2 = 0.93;
							break;
						case 40:
							k2 = 0.92;
							break;
						case 80:
							k2 = 0.90;
							break;
						case 120:
							k2 = 0.87;
							break;
						case 150:
							k2 = 0.86;
							break;
					}
				}
				else if (comboBox1.Text == "СДК-ЦН-33")
				{
					switch (Cvhc)
					{
						case 0:
							k2 = 1;
							break;
						case 10:
							k2 = 0.81;
							break;
						case 20:
							k2 = 0.785;
							break;
						case 40:
							k2 = 0.78;
							break;
						case 80:
							k2 = 0.77;
							break;
						case 120:
							k2 = 0.76;
							break;
						case 150:
							k2 = 0.745;
							break;
					}
				}
				else if (comboBox1.Text == "СДК-ЦН-34")
				{
					switch (Cvhc)
					{
						case 0:
							k2 = 1;
							break;
						case 10:
							k2 = 0.98;
							break;
						case 20:
							k2 = 0.947;
							break;
						case 40:
							k2 = 0.93;
							break;
						case 80:
							k2 = 0.915;
							break;
						case 120:
							k2 = 0.91;
							break;
						case 150:
							k2 = 0.90;
							break;
					}
				}
				else if (comboBox1.Text == "СДК-ЦН-34м")
				{
					switch (Cvhc)
					{
						case 0:
							k2 = 1;
							break;
						case 10:
							k2 = 0.99;
							break;
						case 20:
							k2 = 0.97;
							break;
						case 40:
							k2 = 0.93;
							break;
						case 80:
							k2 = 0.915;
							break;
						case 120:
							k2 = 0.91;
							break;
						case 150:
							k2 = 0.90;
							break;
					}
				}

				//считаю l deltaP
				l = k1 * k2 * l500;
				deltaP = l * p * (Math.Pow(w, 2) / 2);

				//считаю ngRasch
				d50 = dt50 * Math.Sqrt((D / Dt) * (pcht / pch) * (u / ut) * (wt / w));
				if (d50 < dm)
				{
					textBoxResult.Text = "Циклон не подходит, маленький медианный размер частиц";
					return;
				}
				X = Math.Log10(dm / d50) * (1 / (Math.Pow(lgbt, 2) + Math.Pow(lgb, 2)));
				X = Math.Abs(X);
				if (X <= 0 && X <=0.6)
				{
					F = 0.3762 * X + 0.5;
				}
				else
				{
					F = 1 - (1 / (5.8 * X + 0.5));
				}
				ngRasch = 0.5 * (1 + F);
				if (ngRasch < ng)
				{
					textBoxResult.Text = "Циклон не подходит, маленький коэффициент гидравлического сопротивления"; 
				}
				else
				{
					textBoxResult.Text = "Циклон подходит";
				}

				//считаю Cvih
				Cvih = Cvh * (1 - ng);


				//вывод
				textBoxD.Text = Convert.ToString(Math.Round(D, 2));
				textBoxW.Text = Convert.ToString(Math.Round(w, 2));
				textBoxDeltaP.Text = Convert.ToString(Math.Round(deltaP, 2));
				textBoxNgr.Text = Convert.ToString(Math.Round(ngRasch, 2));
				textBoxCvih.Text = Convert.ToString(Math.Round(Cvih, 2));

			//}
			/*else
			{
				textBoxResult.Text = "Циклон не подходит, маленький диаметр частиц";
			}*/
		}




	}
}
