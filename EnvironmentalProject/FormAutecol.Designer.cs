
namespace EnvironmentalProject
{
	partial class FormAutecol
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAutecol));
			this.button1 = new System.Windows.Forms.Button();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxTmin = new System.Windows.Forms.TextBox();
			this.textBoxTmax = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxVeetMax = new System.Windows.Forms.TextBox();
			this.textBoxVeetMin = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 13);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(33, 30);
			this.button1.TabIndex = 0;
			this.button1.Text = "<";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(52, 42);
			this.chart1.Name = "chart1";
			series1.BorderWidth = 3;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series1.Color = System.Drawing.Color.Red;
			series1.Legend = "Legend1";
			series1.LegendText = "Максимальная \\nсмертность";
			series1.Name = "Series1";
			series1.YValuesPerPoint = 2;
			series2.BorderWidth = 3;
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series2.Color = System.Drawing.Color.Blue;
			series2.LabelForeColor = System.Drawing.Color.BlanchedAlmond;
			series2.Legend = "Legend1";
			series2.LegendText = "Минимальная\\nсмертность";
			series2.Name = "Series2";
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
			series3.Legend = "Legend1";
			series3.LegendText = "Температура в районе";
			series3.Name = "Series3";
			series3.YValuesPerPoint = 2;
			this.chart1.Series.Add(series1);
			this.chart1.Series.Add(series2);
			this.chart1.Series.Add(series3);
			this.chart1.Size = new System.Drawing.Size(627, 374);
			this.chart1.TabIndex = 1;
			this.chart1.Text = "chart1";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(219, 348);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(92, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Построить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(252)))), ((int)(((byte)(152)))));
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.textBoxVeetMax);
			this.panel1.Controls.Add(this.textBoxVeetMin);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.textBoxTmax);
			this.panel1.Controls.Add(this.textBoxTmin);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Location = new System.Drawing.Point(676, 42);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(314, 374);
			this.panel1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(69, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(205, 34);
			this.label1.TabIndex = 3;
			this.label1.Text = "Введите минимальную\r\nи максимальную температуру";
			// 
			// textBoxTmin
			// 
			this.textBoxTmin.Location = new System.Drawing.Point(72, 75);
			this.textBoxTmin.Name = "textBoxTmin";
			this.textBoxTmin.Size = new System.Drawing.Size(49, 22);
			this.textBoxTmin.TabIndex = 4;
			// 
			// textBoxTmax
			// 
			this.textBoxTmax.Location = new System.Drawing.Point(219, 75);
			this.textBoxTmax.Name = "textBoxTmax";
			this.textBoxTmax.Size = new System.Drawing.Size(49, 22);
			this.textBoxTmax.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "min:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(179, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "max:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(179, 180);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 17);
			this.label4.TabIndex = 12;
			this.label4.Text = "max:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(32, 178);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 17);
			this.label5.TabIndex = 11;
			this.label5.Text = "min:";
			// 
			// textBoxVeetMax
			// 
			this.textBoxVeetMax.Location = new System.Drawing.Point(219, 175);
			this.textBoxVeetMax.Name = "textBoxVeetMax";
			this.textBoxVeetMax.Size = new System.Drawing.Size(49, 22);
			this.textBoxVeetMax.TabIndex = 10;
			// 
			// textBoxVeetMin
			// 
			this.textBoxVeetMin.Location = new System.Drawing.Point(72, 175);
			this.textBoxVeetMin.Name = "textBoxVeetMin";
			this.textBoxVeetMin.Size = new System.Drawing.Size(49, 22);
			this.textBoxVeetMin.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(69, 120);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(189, 34);
			this.label6.TabIndex = 8;
			this.label6.Text = "Введите минимальную\r\nи максимальную влажность";
			// 
			// FormAutecol
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(240)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1002, 487);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormAutecol";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Аутэкология";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAutecol_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxVeetMax;
		private System.Windows.Forms.TextBox textBoxVeetMin;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxTmax;
		private System.Windows.Forms.TextBox textBoxTmin;
		private System.Windows.Forms.Label label1;
	}
}