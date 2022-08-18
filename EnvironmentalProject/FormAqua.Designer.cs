
namespace EnvironmentalProject
{
	partial class FormAqua
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
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAqua));
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxPDK = new System.Windows.Forms.TextBox();
			this.textBoxQ = new System.Windows.Forms.TextBox();
			this.textBoxLittleQ = new System.Windows.Forms.TextBox();
			this.textBoxV = new System.Windows.Forms.TextBox();
			this.textBoxH = new System.Windows.Forms.TextBox();
			this.textBoxL = new System.Windows.Forms.TextBox();
			this.textBoxC = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBoxPDS = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBoxCpred = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBoxCv = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBoxK = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 13);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(33, 31);
			this.button1.TabIndex = 0;
			this.button1.Text = "<";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(447, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 34);
			this.label2.TabIndex = 3;
			this.label2.Text = "Расход воды \r\nпредприятием";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(257, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(153, 34);
			this.label3.TabIndex = 4;
			this.label3.Text = "Расстояние до места \r\nводопользования";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(61, 147);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(125, 34);
			this.label4.TabIndex = 5;
			this.label4.Text = "Средняя глубина \r\nна участке";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(616, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 17);
			this.label5.TabIndex = 6;
			this.label5.Text = "Скорость течения";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(447, 147);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(151, 34);
			this.label7.TabIndex = 8;
			this.label7.Text = "Концентрация \r\nвредного компонента";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(257, 36);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(160, 34);
			this.label8.TabIndex = 9;
			this.label8.Text = "Расход воды водотока \r\nв месте водозабора";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(61, 36);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(163, 34);
			this.label9.TabIndex = 10;
			this.label9.Text = "Предельно допустимая\r\n концентрация(ПДК)";
			// 
			// textBoxPDK
			// 
			this.textBoxPDK.Location = new System.Drawing.Point(64, 73);
			this.textBoxPDK.Name = "textBoxPDK";
			this.textBoxPDK.Size = new System.Drawing.Size(100, 22);
			this.textBoxPDK.TabIndex = 11;
			// 
			// textBoxQ
			// 
			this.textBoxQ.Location = new System.Drawing.Point(260, 73);
			this.textBoxQ.Name = "textBoxQ";
			this.textBoxQ.Size = new System.Drawing.Size(100, 22);
			this.textBoxQ.TabIndex = 12;
			// 
			// textBoxLittleQ
			// 
			this.textBoxLittleQ.Location = new System.Drawing.Point(451, 73);
			this.textBoxLittleQ.Name = "textBoxLittleQ";
			this.textBoxLittleQ.Size = new System.Drawing.Size(100, 22);
			this.textBoxLittleQ.TabIndex = 13;
			// 
			// textBoxV
			// 
			this.textBoxV.Location = new System.Drawing.Point(619, 73);
			this.textBoxV.Name = "textBoxV";
			this.textBoxV.Size = new System.Drawing.Size(100, 22);
			this.textBoxV.TabIndex = 14;
			// 
			// textBoxH
			// 
			this.textBoxH.Location = new System.Drawing.Point(64, 184);
			this.textBoxH.Name = "textBoxH";
			this.textBoxH.Size = new System.Drawing.Size(100, 22);
			this.textBoxH.TabIndex = 15;
			// 
			// textBoxL
			// 
			this.textBoxL.Location = new System.Drawing.Point(260, 184);
			this.textBoxL.Name = "textBoxL";
			this.textBoxL.Size = new System.Drawing.Size(100, 22);
			this.textBoxL.TabIndex = 16;
			// 
			// textBoxC
			// 
			this.textBoxC.Location = new System.Drawing.Point(450, 184);
			this.textBoxC.Name = "textBoxC";
			this.textBoxC.Size = new System.Drawing.Size(100, 22);
			this.textBoxC.TabIndex = 17;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(252)))), ((int)(((byte)(152)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.textBoxPDS);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.textBoxCpred);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.textBoxCv);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.textBoxK);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Location = new System.Drawing.Point(64, 307);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(691, 212);
			this.panel1.TabIndex = 18;
			// 
			// textBoxPDS
			// 
			this.textBoxPDS.Location = new System.Drawing.Point(557, 121);
			this.textBoxPDS.Name = "textBoxPDS";
			this.textBoxPDS.Size = new System.Drawing.Size(100, 22);
			this.textBoxPDS.TabIndex = 23;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(554, 84);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(121, 34);
			this.label12.TabIndex = 22;
			this.label12.Text = "Предельно \r\nдопустимый сток";
			// 
			// textBoxCpred
			// 
			this.textBoxCpred.Location = new System.Drawing.Point(378, 121);
			this.textBoxCpred.Name = "textBoxCpred";
			this.textBoxCpred.Size = new System.Drawing.Size(100, 22);
			this.textBoxCpred.TabIndex = 21;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(375, 84);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(154, 34);
			this.label11.TabIndex = 20;
			this.label11.Text = "Предельная \r\nконцентрация в стоке";
			// 
			// textBoxCv
			// 
			this.textBoxCv.Location = new System.Drawing.Point(198, 121);
			this.textBoxCv.Name = "textBoxCv";
			this.textBoxCv.Size = new System.Drawing.Size(100, 22);
			this.textBoxCv.TabIndex = 19;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(195, 84);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(129, 34);
			this.label10.TabIndex = 18;
			this.label10.Text = "Концентрация в \r\nместе водозабора";
			// 
			// textBoxK
			// 
			this.textBoxK.Location = new System.Drawing.Point(20, 121);
			this.textBoxK.Name = "textBoxK";
			this.textBoxK.Size = new System.Drawing.Size(100, 22);
			this.textBoxK.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(17, 84);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 34);
			this.label6.TabIndex = 16;
			this.label6.Text = "Кратность \r\nразбавления";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(653, 255);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(102, 46);
			this.button2.TabIndex = 37;
			this.button2.Text = "Расчитать";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(514, 255);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(102, 46);
			this.button3.TabIndex = 36;
			this.button3.Text = "Очистить";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			this.chart1.Location = new System.Drawing.Point(777, 36);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(750, 436);
			this.chart1.TabIndex = 38;
			this.chart1.Text = "chart1";
			// 
			// FormAqua
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(240)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1588, 531);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBoxC);
			this.Controls.Add(this.textBoxL);
			this.Controls.Add(this.textBoxH);
			this.Controls.Add(this.textBoxV);
			this.Controls.Add(this.textBoxLittleQ);
			this.Controls.Add(this.textBoxQ);
			this.Controls.Add(this.textBoxPDK);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormAqua";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Охрана водоёмов";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAqua_FormClosed);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxPDK;
		private System.Windows.Forms.TextBox textBoxQ;
		private System.Windows.Forms.TextBox textBoxLittleQ;
		private System.Windows.Forms.TextBox textBoxV;
		private System.Windows.Forms.TextBox textBoxH;
		private System.Windows.Forms.TextBox textBoxL;
		private System.Windows.Forms.TextBox textBoxC;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxPDS;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBoxCpred;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBoxCv;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxK;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
	}
}