namespace WindowsFormsApp1
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
			this.btnUP = new System.Windows.Forms.Button();
			this.btnLeft = new System.Windows.Forms.Button();
			this.btnRight = new System.Windows.Forms.Button();
			this.btnDown = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnUP
			// 
			this.btnUP.Location = new System.Drawing.Point(69, 367);
			this.btnUP.Name = "btnUP";
			this.btnUP.Size = new System.Drawing.Size(75, 23);
			this.btnUP.TabIndex = 0;
			this.btnUP.Text = "button1";
			this.btnUP.UseVisualStyleBackColor = true;
			this.btnUP.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnLeft
			// 
			this.btnLeft.Location = new System.Drawing.Point(141, 396);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.Size = new System.Drawing.Size(75, 23);
			this.btnLeft.TabIndex = 1;
			this.btnLeft.Text = "button2";
			this.btnLeft.UseVisualStyleBackColor = true;
			this.btnLeft.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnRight
			// 
			this.btnRight.Location = new System.Drawing.Point(0, 396);
			this.btnRight.Name = "btnRight";
			this.btnRight.Size = new System.Drawing.Size(75, 23);
			this.btnRight.TabIndex = 2;
			this.btnRight.Text = "button3";
			this.btnRight.UseVisualStyleBackColor = true;
			// 
			// btnDown
			// 
			this.btnDown.Location = new System.Drawing.Point(69, 425);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(75, 23);
			this.btnDown.TabIndex = 3;
			this.btnDown.Text = "button4";
			this.btnDown.UseVisualStyleBackColor = true;
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
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnDown);
			this.Controls.Add(this.btnRight);
			this.Controls.Add(this.btnLeft);
			this.Controls.Add(this.btnUP);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnUP;
		private System.Windows.Forms.Button btnLeft;
		private System.Windows.Forms.Button btnRight;
		private System.Windows.Forms.Button btnDown;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

