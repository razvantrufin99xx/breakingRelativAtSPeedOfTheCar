/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/29/2024
 * Time: 12:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace graficulFranariiMasinii
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	g = panel1.CreateGraphics();
		}
		
		public Graphics g;
		public Pen p = new Pen(Color.FromArgb(25,250,150,50),2);
			
			
		public double d(double s)
		{
			return 0.010 * s * s;
		}
		
		public int timepressed = 0;
		
		public void draw(double pd, double ji)
		{
			
			g.DrawEllipse(p,(int)pd,(int)ji+(1+(timepressed*3)), 5,5);
			g.DrawEllipse(p,(int)pd+3,(int)ji+(1+(timepressed*3)), 5,5);
			
		}
		public void run(double x,double step)
		{
			double D = 0;
			for(double i = x; i >0 ; i-=step)
			{
				//textBox2.Text = i.ToString();
				//D = d(double.Parse(textBox2.Text));
				D = d(i);
				textBox3.Text = D.ToString();
				textBox3.Refresh();
				this.textBox1.Text += D.ToString() +  "," + i.ToString() + " \r\n";
				draw(D,i);
			}
		}
		
		public void fc()
		{
				run(double.Parse(textBox2.Text),double.Parse(textBox4.Text));
				timepressed++;
				textBox1.Text = "";
		}
		void Button1Click(object sender, EventArgs e)
		{
			
			fc();
			
		}
		void TextBox3TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			g.Clear(Color.Black);
		}
		void Button3Click(object sender, EventArgs e)
		{
			timepressed=0;
		}
		void Button4Click(object sender, EventArgs e)
		{
			for(double i = 50; i >0 ; i-=2)
			{
				fc();
			}
			
		}
		
	}
}
