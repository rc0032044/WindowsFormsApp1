using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private async void btnsquare_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 50; i++)
			{
				pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
				await Task.Delay(25);
			}
			for (int i = 0; i < 50; i++)
			{
				pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 5);
				await Task.Delay(25);
			}
			for (int i = 0; i < 50; i++)
			{
				pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y);
				await Task.Delay(25);
			}
			for (int i = 0; i < 50; i++)
			{
				pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 5);
				await Task.Delay(25);
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private async void btntri_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 14; i++)
			{
				pictureBox1.Location = new Point(pictureBox1.Location.X + 15, pictureBox1.Location.Y);
				await Task.Delay(25);
			}
			pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);

			for (int i = 0; i < 10; i++)
			{
				pictureBox1.Location = new Point(pictureBox1.Location.X - 11, pictureBox1.Location.Y - 11);
				await Task.Delay(25);
			}
			for (int i = 0; i < 10; i++)
			{
				pictureBox1.Location = new Point(pictureBox1.Location.X - 11, pictureBox1.Location.Y + 11);
				await Task.Delay(25);
			}
		}

		private async void btncircle_Click(object sender, EventArgs e)
		{
			int r = 100;
			int x = pictureBox1.Location.X - r;
			int y = pictureBox1.Location.Y;
			
			for (double a = 0; a < Math.PI * 2; a = a + (Math.PI / 180.0))
			{
				pictureBox1.Location = new Point((int)(x + r * Math.Cos(a)), (int)(y + r * Math.Sin(a)));
				await Task.Delay(10);
			}
		}

	}
		
}