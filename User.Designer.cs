namespace KUTUPHANEPROJE_DENEMELER
{
	partial class User
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnFotografSec = new System.Windows.Forms.Button();
			this.txtBoxBookName = new System.Windows.Forms.TextBox();
			this.btnVoting = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblAdSoyad = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.p1 = new System.Windows.Forms.Panel();
			this.btnTumKitap = new System.Windows.Forms.Button();
			this.btnAlinan = new System.Windows.Forms.Button();
			this.btnKitapVer = new System.Windows.Forms.Button();
			this.btnKitapAl = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBoxVote = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// btnFotografSec
			// 
			this.btnFotografSec.Location = new System.Drawing.Point(38, 113);
			this.btnFotografSec.Name = "btnFotografSec";
			this.btnFotografSec.Size = new System.Drawing.Size(109, 23);
			this.btnFotografSec.TabIndex = 25;
			this.btnFotografSec.Text = "Select Photo";
			this.btnFotografSec.UseVisualStyleBackColor = true;
			this.btnFotografSec.Click += new System.EventHandler(this.btnFotografSec_Click);
			// 
			// txtBoxBookName
			// 
			this.txtBoxBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
			this.txtBoxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBoxBookName.ForeColor = System.Drawing.SystemColors.Info;
			this.txtBoxBookName.Location = new System.Drawing.Point(339, 289);
			this.txtBoxBookName.Name = "txtBoxBookName";
			this.txtBoxBookName.Size = new System.Drawing.Size(105, 22);
			this.txtBoxBookName.TabIndex = 33;
			this.txtBoxBookName.TextChanged += new System.EventHandler(this.txtBoxBookName_TextChanged);
			// 
			// btnVoting
			// 
			this.btnVoting.Location = new System.Drawing.Point(339, 351);
			this.btnVoting.Name = "btnVoting";
			this.btnVoting.Size = new System.Drawing.Size(105, 23);
			this.btnVoting.TabIndex = 36;
			this.btnVoting.Text = "Puan Ver";
			this.btnVoting.UseVisualStyleBackColor = true;
			this.btnVoting.Click += new System.EventHandler(this.btnVoting_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
			this.panel1.Controls.Add(this.lblAdSoyad);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.p1);
			this.panel1.Controls.Add(this.btnTumKitap);
			this.panel1.Controls.Add(this.btnAlinan);
			this.panel1.Controls.Add(this.btnKitapVer);
			this.panel1.Controls.Add(this.btnKitapAl);
			this.panel1.Controls.Add(this.btnFotografSec);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(196, 459);
			this.panel1.TabIndex = 37;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			// 
			// lblAdSoyad
			// 
			this.lblAdSoyad.AutoSize = true;
			this.lblAdSoyad.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAdSoyad.Location = new System.Drawing.Point(9, 144);
			this.lblAdSoyad.Name = "lblAdSoyad";
			this.lblAdSoyad.Size = new System.Drawing.Size(79, 16);
			this.lblAdSoyad.TabIndex = 8;
			this.lblAdSoyad.Text = "AD SOYAD";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.pictureBox1.Location = new System.Drawing.Point(40, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(95, 95);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// p1
			// 
			this.p1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(137)))), ((int)(((byte)(130)))));
			this.p1.Location = new System.Drawing.Point(-1, 231);
			this.p1.Name = "p1";
			this.p1.Size = new System.Drawing.Size(10, 42);
			this.p1.TabIndex = 6;
			// 
			// btnTumKitap
			// 
			this.btnTumKitap.FlatAppearance.BorderSize = 0;
			this.btnTumKitap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTumKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnTumKitap.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnTumKitap.Location = new System.Drawing.Point(12, 370);
			this.btnTumKitap.Name = "btnTumKitap";
			this.btnTumKitap.Size = new System.Drawing.Size(180, 42);
			this.btnTumKitap.TabIndex = 3;
			this.btnTumKitap.Text = "Tüm Kitaplar";
			this.btnTumKitap.UseVisualStyleBackColor = true;
			this.btnTumKitap.Click += new System.EventHandler(this.btnTumKitap_Click);
			// 
			// btnAlinan
			// 
			this.btnAlinan.FlatAppearance.BorderSize = 0;
			this.btnAlinan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlinan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAlinan.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnAlinan.Location = new System.Drawing.Point(12, 323);
			this.btnAlinan.Name = "btnAlinan";
			this.btnAlinan.Size = new System.Drawing.Size(180, 43);
			this.btnAlinan.TabIndex = 2;
			this.btnAlinan.Text = "Alınan Kitaplar";
			this.btnAlinan.UseVisualStyleBackColor = true;
			this.btnAlinan.Click += new System.EventHandler(this.btnAlinan_Click);
			// 
			// btnKitapVer
			// 
			this.btnKitapVer.FlatAppearance.BorderSize = 0;
			this.btnKitapVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKitapVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKitapVer.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnKitapVer.Location = new System.Drawing.Point(12, 278);
			this.btnKitapVer.Name = "btnKitapVer";
			this.btnKitapVer.Size = new System.Drawing.Size(180, 39);
			this.btnKitapVer.TabIndex = 1;
			this.btnKitapVer.Text = "Kitap Ver";
			this.btnKitapVer.UseVisualStyleBackColor = true;
			this.btnKitapVer.Click += new System.EventHandler(this.btnKitapVer_Click);
			// 
			// btnKitapAl
			// 
			this.btnKitapAl.FlatAppearance.BorderSize = 0;
			this.btnKitapAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKitapAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKitapAl.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnKitapAl.Location = new System.Drawing.Point(13, 230);
			this.btnKitapAl.Name = "btnKitapAl";
			this.btnKitapAl.Size = new System.Drawing.Size(180, 42);
			this.btnKitapAl.TabIndex = 0;
			this.btnKitapAl.Text = "Kitap Al";
			this.btnKitapAl.UseVisualStyleBackColor = true;
			this.btnKitapAl.Click += new System.EventHandler(this.btnKitapAl_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeight = 30;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
			this.dataGridView1.Location = new System.Drawing.Point(232, 72);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(581, 170);
			this.dataGridView1.TabIndex = 38;
			this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter_1);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.button6);
			this.panel2.Controls.Add(this.button5);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(196, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(678, 30);
			this.panel2.TabIndex = 39;
			this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
			this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
			this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(137)))), ((int)(((byte)(130)))));
			this.button6.Dock = System.Windows.Forms.DockStyle.Right;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button6.Location = new System.Drawing.Point(613, 0);
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
			this.button5.Location = new System.Drawing.Point(646, 0);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(32, 30);
			this.button5.TabIndex = 5;
			this.button5.Text = "X";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(229, 290);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 16);
			this.label1.TabIndex = 40;
			this.label1.Text = "Aranan Kitap :";
			// 
			// txtBoxVote
			// 
			this.txtBoxVote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
			this.txtBoxVote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBoxVote.ForeColor = System.Drawing.SystemColors.Info;
			this.txtBoxVote.Location = new System.Drawing.Point(339, 323);
			this.txtBoxVote.Name = "txtBoxVote";
			this.txtBoxVote.Size = new System.Drawing.Size(105, 22);
			this.txtBoxVote.TabIndex = 41;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(282, 329);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 16);
			this.label2.TabIndex = 42;
			this.label2.Text = "Puan :";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(137)))), ((int)(((byte)(130)))));
			this.button1.Dock = System.Windows.Forms.DockStyle.Left;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(38, 30);
			this.button1.TabIndex = 27;
			this.button1.Text = "<=";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// User
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
			this.ClientSize = new System.Drawing.Size(874, 459);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtBoxVote);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnVoting);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtBoxBookName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "User";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Form3";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseUp);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnFotografSec;
		private System.Windows.Forms.TextBox txtBoxBookName;
		private System.Windows.Forms.Button btnVoting;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblAdSoyad;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel p1;
		private System.Windows.Forms.Button btnTumKitap;
		private System.Windows.Forms.Button btnAlinan;
		private System.Windows.Forms.Button btnKitapVer;
		private System.Windows.Forms.Button btnKitapAl;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBoxVote;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
	}
}