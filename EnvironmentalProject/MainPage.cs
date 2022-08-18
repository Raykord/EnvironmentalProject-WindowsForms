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
	public partial class MainPage : Form
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void MainPage_MouseHover(object sender, EventArgs e)
		{
			
		}

		private void label3_MouseEnter(object sender, EventArgs e)
		{
			label3.ForeColor = Color.FromArgb(0, 78, 56);
		}

		private void label3_MouseLeave(object sender, EventArgs e)
		{
			label3.ForeColor = Color.Black;
		}

		private void label4_MouseEnter(object sender, EventArgs e)
		{
			label4.ForeColor = Color.FromArgb(0, 78, 56);
		}

		private void label4_MouseLeave(object sender, EventArgs e)
		{
			label4.ForeColor = Color.Black;
		}

		private void label5_MouseEnter(object sender, EventArgs e)
		{
			label5.ForeColor = Color.FromArgb(0, 78, 56);
		}

		private void label5_MouseLeave(object sender, EventArgs e)
		{
			label5.ForeColor = Color.Black;
		}

		private void label6_MouseEnter(object sender, EventArgs e)
		{
			label6.ForeColor = Color.FromArgb(0, 78, 56);
		}

		private void label6_MouseLeave(object sender, EventArgs e)
		{
			label6.ForeColor = Color.Black;
		}

		private void label7_MouseEnter(object sender, EventArgs e)
		{
			label7.ForeColor = Color.FromArgb(0, 78, 56);
		}

		private void label7_MouseLeave(object sender, EventArgs e)
		{
			label7.ForeColor = Color.Black;
		}

		private void label8_MouseEnter(object sender, EventArgs e)
		{
			label8.ForeColor = Color.FromArgb(0, 78, 56);
		}

		private void label8_MouseLeave(object sender, EventArgs e)
		{
			label8.ForeColor = Color.Black;
		}

		private void label9_MouseEnter(object sender, EventArgs e)
		{
			label9.ForeColor = Color.FromArgb(0, 78, 56);
		}

		private void label9_MouseLeave(object sender, EventArgs e)
		{
			label9.ForeColor = Color.Black;
		}

		private void label10_MouseEnter(object sender, EventArgs e)
		{
			label10.ForeColor = Color.FromArgb(0, 78, 56);
		}

		private void label10_MouseLeave(object sender, EventArgs e)
		{
			label10.ForeColor = Color.Black;
		}

		private void label11_MouseEnter(object sender, EventArgs e)
		{
			label11.ForeColor = Color.FromArgb(0, 78, 56);
		}

		private void label11_MouseLeave(object sender, EventArgs e)
		{
			label11.ForeColor = Color.Black;
		}

		private void label3_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormCoSearch formCoSearch = new FormCoSearch();
			formCoSearch.Show();
		}

		private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormVuelV formVuelV = new FormVuelV();
			formVuelV.Show();
		}

		private void label6_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormAtmos formAtmos = new FormAtmos();
			formAtmos.Show();
		}

		private void label7_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormAqua formAqua = new FormAqua();
			formAqua.Show();
		}

		private void label10_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormCyclone formCyclone = new FormCyclone();
			formCyclone.Show();
		}

		private void label8_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormGround formGround = new FormGround();
			formGround.Show();
		}

		private void label9_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormPay formPay = new FormPay();
			formPay.Show();
		}

		private void label5_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormAutecol formAutecol = new FormAutecol();
			formAutecol.Show();
		}

		private void label11_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormDemog formDemog = new FormDemog();
			formDemog.Show();
		}
	}
}
