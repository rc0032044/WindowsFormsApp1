﻿namespace WindowsFormsApp1
{
	partial class Form1
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
			this.btnsquare = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btntri = new System.Windows.Forms.Button();
			this.btncircle = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnsquare
			// 
			this.btnsquare.Location = new System.Drawing.Point(69, 367);
			this.btnsquare.Name = "btnsquare";
			this.btnsquare.Size = new System.Drawing.Size(75, 23);
			this.btnsquare.TabIndex = 0;
			this.btnsquare.Text = "square";
			this.btnsquare.UseVisualStyleBackColor = true;
			this.btnsquare.Click += new System.EventHandler(this.btnsquare_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.pacman;
			this.pictureBox1.Location = new System.Drawing.Point(342, 184);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(108, 96);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// btntri
			// 
			this.btntri.Location = new System.Drawing.Point(607, 367);
			this.btntri.Name = "btntri";
			this.btntri.Size = new System.Drawing.Size(75, 23);
			this.btntri.TabIndex = 5;
			this.btntri.Text = "triangle";
			this.btntri.UseVisualStyleBackColor = true;
			this.btntri.Click += new System.EventHandler(this.btntri_Click);
			// 
			// btncircle
			// 
			this.btncircle.Location = new System.Drawing.Point(353, 367);
			this.btncircle.Name = "btncircle";
			this.btncircle.Size = new System.Drawing.Size(75, 23);
			this.btncircle.TabIndex = 6;
			this.btncircle.Text = "circle";
			this.btncircle.UseVisualStyleBackColor = true;
			this.btncircle.Click += new System.EventHandler(this.btncircle_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btncircle);
			this.Controls.Add(this.btntri);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnsquare);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnsquare;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btntri;
		private System.Windows.Forms.Button btncircle;
	}
}

