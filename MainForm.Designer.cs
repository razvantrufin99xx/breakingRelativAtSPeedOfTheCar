/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/29/2024
 * Time: 12:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace graficulFranariiMasinii
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 236);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(167, 74);
			this.button1.TabIndex = 1;
			this.button1.Text = "calculeaza distanat de franare si afiseaza graficul";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(12, 162);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(167, 20);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "300";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 136);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "viteza in mile pe ora";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 400);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(167, 143);
			this.textBox1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(10, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(169, 98);
			this.label2.TabIndex = 4;
			this.label2.Text = "calculul distantei de franare al unui automobil data viteza in mile pe ora  cu aj" +
	"utorul functiei d= 0.01 * s * s unde d e distanta si s este speed sau viteza";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Location = new System.Drawing.Point(203, 35);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1477, 808);
			this.panel1.TabIndex = 5;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(12, 562);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(167, 20);
			this.textBox3.TabIndex = 6;
			this.textBox3.TextChanged += new System.EventHandler(this.TextBox3TextChanged);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(12, 210);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(167, 20);
			this.textBox4.TabIndex = 7;
			this.textBox4.Text = "10";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 183);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "franare :";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(203, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(476, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "fiecare distanta dintre doua cercuri este de fapt lungimea unei masini ";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(136, 619);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(61, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "clr";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 619);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(61, 23);
			this.button3.TabIndex = 11;
			this.button3.Text = "reset";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(10, 316);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(167, 74);
			this.button4.TabIndex = 12;
			this.button4.Text = "(automat) calculeaza distanat de franare si afiseaza graficul";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1692, 855);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "graficulFranariiMasinii";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
