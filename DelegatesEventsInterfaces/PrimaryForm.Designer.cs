namespace DelegatesEventsInterfaces
{
	partial class PrimaryForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimaryForm));
			this.calculateIntegral = new System.Windows.Forms.Button();
			this.rightIntegralBorder = new System.Windows.Forms.TextBox();
			this.leftIntegralBorder = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.resultIntegralLabel = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.equationString = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.leftEquationBorder = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.rightEquationBorder = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.resultEquationLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// calculateIntegral
			// 
			this.calculateIntegral.Location = new System.Drawing.Point(200, 49);
			this.calculateIntegral.Name = "calculateIntegral";
			this.calculateIntegral.Size = new System.Drawing.Size(130, 25);
			this.calculateIntegral.TabIndex = 0;
			this.calculateIntegral.Text = "Посчитать интеграл";
			this.calculateIntegral.UseVisualStyleBackColor = true;
			this.calculateIntegral.Click += new System.EventHandler(this.calculateIntegral_Click);
			// 
			// rightIntegralBorder
			// 
			this.rightIntegralBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rightIntegralBorder.Location = new System.Drawing.Point(14, 32);
			this.rightIntegralBorder.Name = "rightIntegralBorder";
			this.rightIntegralBorder.Size = new System.Drawing.Size(28, 26);
			this.rightIntegralBorder.TabIndex = 1;
			// 
			// leftIntegralBorder
			// 
			this.leftIntegralBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.leftIntegralBorder.Location = new System.Drawing.Point(14, 64);
			this.leftIntegralBorder.Name = "leftIntegralBorder";
			this.leftIntegralBorder.Size = new System.Drawing.Size(28, 26);
			this.leftIntegralBorder.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(80, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "x*x";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(114, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "=";
			// 
			// resultIntegralLabel
			// 
			this.resultIntegralLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.resultIntegralLabel.Location = new System.Drawing.Point(141, 51);
			this.resultIntegralLabel.Name = "resultIntegralLabel";
			this.resultIntegralLabel.Size = new System.Drawing.Size(53, 23);
			this.resultIntegralLabel.TabIndex = 6;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(34, 32);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(40, 59);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// equationString
			// 
			this.equationString.AutoSize = true;
			this.equationString.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.equationString.Location = new System.Drawing.Point(12, 146);
			this.equationString.Name = "equationString";
			this.equationString.Size = new System.Drawing.Size(68, 24);
			this.equationString.TabIndex = 7;
			this.equationString.Text = "x*x = 0";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(12, 6);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(197, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Подсчет интеграла";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(12, 112);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(244, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "Расчет корней уравнения";
			// 
			// leftEquationBorder
			// 
			this.leftEquationBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.leftEquationBorder.Location = new System.Drawing.Point(155, 177);
			this.leftEquationBorder.Name = "leftEquationBorder";
			this.leftEquationBorder.Size = new System.Drawing.Size(28, 26);
			this.leftEquationBorder.TabIndex = 12;
			this.leftEquationBorder.Text = "0";
			this.leftEquationBorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(12, 180);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(127, 23);
			this.label8.TabIndex = 13;
			this.label8.Text = "Левая граница:";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(12, 212);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(137, 23);
			this.label9.TabIndex = 15;
			this.label9.Text = "Правая граница:";
			// 
			// rightEquationBorder
			// 
			this.rightEquationBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rightEquationBorder.Location = new System.Drawing.Point(155, 209);
			this.rightEquationBorder.Name = "rightEquationBorder";
			this.rightEquationBorder.Size = new System.Drawing.Size(28, 26);
			this.rightEquationBorder.TabIndex = 14;
			this.rightEquationBorder.Text = "1";
			this.rightEquationBorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Алгоритм дихотомии",
            "Алгоритм перебора"});
			this.comboBox1.Location = new System.Drawing.Point(14, 255);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(169, 21);
			this.comboBox1.TabIndex = 16;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(200, 148);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(130, 25);
			this.button1.TabIndex = 17;
			this.button1.Text = "Посчитать корень";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(196, 195);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(66, 23);
			this.label10.TabIndex = 18;
			this.label10.Text = "Ответ:";
			// 
			// resultEquationLabel
			// 
			this.resultEquationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.resultEquationLabel.Location = new System.Drawing.Point(254, 195);
			this.resultEquationLabel.Name = "resultEquationLabel";
			this.resultEquationLabel.Size = new System.Drawing.Size(66, 23);
			this.resultEquationLabel.TabIndex = 19;
			// 
			// PrimaryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(348, 288);
			this.Controls.Add(this.resultEquationLabel);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.rightEquationBorder);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.leftEquationBorder);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.equationString);
			this.Controls.Add(this.resultIntegralLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rightIntegralBorder);
			this.Controls.Add(this.leftIntegralBorder);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.calculateIntegral);
			this.MinimumSize = new System.Drawing.Size(358, 93);
			this.Name = "PrimaryForm";
			this.ShowIcon = false;
			this.Text = "Вычисления";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button calculateIntegral;
		private System.Windows.Forms.TextBox rightIntegralBorder;
		private System.Windows.Forms.TextBox leftIntegralBorder;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label resultIntegralLabel;
		private System.Windows.Forms.Label equationString;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox leftEquationBorder;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox rightEquationBorder;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label resultEquationLabel;
	}
}