﻿using System;
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

		private async void button1_Click(object sender, EventArgs e)
		{
			for(int i = 0; i < 20; i++)
			{
				pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
				await Task.Delay(50);
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
