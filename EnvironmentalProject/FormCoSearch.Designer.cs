
namespace EnvironmentalProject
{
	partial class FormCoSearch
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCoSearch));
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(240, 334);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(356, 17);
			this.label4.TabIndex = 19;
			this.label4.Text = "Объем CO необходимы для образования древесины";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(296, 354);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(249, 22);
			this.textBox3.TabIndex = 18;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(445, 267);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 40);
			this.button2.TabIndex = 17;
			this.button2.Text = "Очистить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(296, 267);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 40);
			this.button1.TabIndex = 16;
			this.button1.Text = "Посчитать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Липа",
            "Сосна",
            "Бук",
            "Дуб",
            "Орех",
            "Груша",
            "Ясень",
            "Клен",
            "Кл.дерево",
            "Акация"});
			this.comboBox1.Location = new System.Drawing.Point(335, 95);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(172, 24);
			this.comboBox1.TabIndex = 15;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(335, 220);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(172, 22);
			this.textBox2.TabIndex = 14;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(335, 162);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(172, 22);
			this.textBox1.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(360, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 17);
			this.label3.TabIndex = 12;
			this.label3.Text = "Выберете дерево";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(360, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 17);
			this.label2.TabIndex = 11;
			this.label2.Text = "Введите высоту";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(360, 142);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 17);
			this.label1.TabIndex = 10;
			this.label1.Text = "Введите диаметр";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(13, 13);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(39, 37);
			this.button3.TabIndex = 20;
			this.button3.Text = "<";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// FormCoSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(240)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(841, 450);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormCoSearch";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " Определение объема углекислого газа";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCoSearch_FormClosed_1);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
	}
}