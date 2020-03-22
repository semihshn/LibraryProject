namespace KUTUPHANEPROJE_DENEMELER
{
	partial class SignUp
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
			this.txtBoxPassword = new System.Windows.Forms.TextBox();
			this.txtBoxUser = new System.Windows.Forms.TextBox();
			this.panel_left = new System.Windows.Forms.Panel();
			this.lblDuyuru = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel_right = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnRegister = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.panel_left.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel_right.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtBoxPassword
			// 
			this.txtBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
			this.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtBoxPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
			this.txtBoxPassword.Location = new System.Drawing.Point(12, 212);
			this.txtBoxPassword.Name = "txtBoxPassword";
			this.txtBoxPassword.Size = new System.Drawing.Size(168, 19);
			this.txtBoxPassword.TabIndex = 13;
			this.txtBoxPassword.Text = "Password";
			this.txtBoxPassword.UseSystemPasswordChar = true;
			this.txtBoxPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxPassword_MouseClick);
			// 
			// txtBoxUser
			// 
			this.txtBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
			this.txtBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtBoxUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBoxUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
			this.txtBoxUser.Location = new System.Drawing.Point(12, 130);
			this.txtBoxUser.Name = "txtBoxUser";
			this.txtBoxUser.Size = new System.Drawing.Size(168, 19);
			this.txtBoxUser.TabIndex = 11;
			this.txtBoxUser.Text = "Full Name";
			this.txtBoxUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxUser_MouseClick);
			// 
			// panel_left
			// 
			this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
			this.panel_left.Controls.Add(this.lblDuyuru);
			this.panel_left.Controls.Add(this.label1);
			this.panel_left.Controls.Add(this.label3);
			this.panel_left.Controls.Add(this.pictureBox1);
			this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel_left.Location = new System.Drawing.Point(0, 0);
			this.panel_left.Margin = new System.Windows.Forms.Padding(2);
			this.panel_left.Name = "panel_left";
			this.panel_left.Size = new System.Drawing.Size(272, 617);
			this.panel_left.TabIndex = 17;
			// 
			// lblDuyuru
			// 
			this.lblDuyuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDuyuru.Location = new System.Drawing.Point(24, 288);
			this.lblDuyuru.Name = "lblDuyuru";
			this.lblDuyuru.Size = new System.Drawing.Size(216, 88);
			this.lblDuyuru.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(21, 258);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 18);
			this.label1.TabIndex = 20;
			this.label1.Text = "DUYURU";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(20, 223);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(220, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Research, Learn, Teach";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(86, 91);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(97, 93);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel_right
			// 
			this.panel_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
			this.panel_right.Controls.Add(this.panel2);
			this.panel_right.Controls.Add(this.flowLayoutPanel2);
			this.panel_right.Controls.Add(this.flowLayoutPanel1);
			this.panel_right.Controls.Add(this.btnRegister);
			this.panel_right.Controls.Add(this.label5);
			this.panel_right.Controls.Add(this.txtBoxPassword);
			this.panel_right.Controls.Add(this.btnLogin);
			this.panel_right.Controls.Add(this.txtBoxUser);
			this.panel_right.Controls.Add(this.label4);
			this.panel_right.Controls.Add(this.label7);
			this.panel_right.Controls.Add(this.label8);
			this.panel_right.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_right.Location = new System.Drawing.Point(272, 0);
			this.panel_right.Margin = new System.Windows.Forms.Padding(2);
			this.panel_right.Name = "panel_right";
			this.panel_right.Size = new System.Drawing.Size(296, 617);
			this.panel_right.TabIndex = 18;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.button6);
			this.panel2.Controls.Add(this.button5);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(296, 30);
			this.panel2.TabIndex = 40;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(137)))), ((int)(((byte)(130)))));
			this.button6.Dock = System.Windows.Forms.DockStyle.Right;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button6.Location = new System.Drawing.Point(231, 0);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(33, 30);
			this.button6.TabIndex = 5;
			this.button6.Text = "-";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(137)))), ((int)(((byte)(130)))));
			this.button5.Dock = System.Windows.Forms.DockStyle.Right;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button5.Location = new System.Drawing.Point(264, 0);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(32, 30);
			this.button5.TabIndex = 5;
			this.button5.Text = "X";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
			this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 235);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(280, 3);
			this.flowLayoutPanel2.TabIndex = 14;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
			this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 156);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(280, 3);
			this.flowLayoutPanel1.TabIndex = 12;
			// 
			// btnRegister
			// 
			this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
			this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnRegister.ForeColor = System.Drawing.Color.White;
			this.btnRegister.Location = new System.Drawing.Point(92, 367);
			this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(116, 32);
			this.btnRegister.TabIndex = 7;
			this.btnRegister.Text = "Register now";
			this.btnRegister.UseVisualStyleBackColor = false;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
			this.label5.Location = new System.Drawing.Point(44, 333);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(221, 23);
			this.label5.TabIndex = 6;
			this.label5.Text = "Don\'t have an account yet?";
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(82, 258);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(136, 37);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Sign up";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 13F);
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
			this.label4.Location = new System.Drawing.Point(8, 180);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 21);
			this.label4.TabIndex = 3;
			this.label4.Text = "Password:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 13F);
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
			this.label7.Location = new System.Drawing.Point(8, 106);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(110, 21);
			this.label7.TabIndex = 1;
			this.label7.Text = "User Name:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
			this.label8.Location = new System.Drawing.Point(99, 44);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(107, 30);
			this.label8.TabIndex = 0;
			this.label8.Text = "SIGN UP";
			// 
			// SignUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(568, 617);
			this.Controls.Add(this.panel_right);
			this.Controls.Add(this.panel_left);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SignUp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.SignUp_Load);
			this.panel_left.ResumeLayout(false);
			this.panel_left.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel_right.ResumeLayout(false);
			this.panel_right.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox txtBoxPassword;
		private System.Windows.Forms.TextBox txtBoxUser;
		private System.Windows.Forms.Panel panel_left;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel_right;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblDuyuru;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
	}
}

