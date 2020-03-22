using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KUTUPHANEPROJE_DENEMELER
{
	public partial class Manager : Form
	{
		public Manager()
		{
			InitializeComponent();
		}
		KUTUPHANEEntities1 db = new KUTUPHANEEntities1();
		int mov;
		int movX;
		int movY;

		private void position(Button b)
		{

			p1.Location = new Point(b.Location.X - p1.Width, b.Location.Y);
		}

		private void active(Button b)
		{
			foreach (Control ctr in panel1.Controls)
			{
				if (ctr.GetType() == typeof(Button))
				{
					if (ctr.Name == b.Name)
					{
						b.BackColor = Color.FromArgb(76, 76, 60);
						b.ForeColor = Color.FromArgb(242, 215, 213);
					}
					else
					{
						ctr.BackColor = Color.FromArgb(76, 86, 86);
						b.ForeColor = Color.White;
					}
				}
			}
		}

		private bool BosTextKontrol()
		{
			var BookName = txtBoxBookName.Text;
			var WriterName = txtBoxWriterName.Text;
			var Page = txtBoxPage.Text;
			var Published = txtBoxPublished.Text;
			var Barkod = txtBoxBarkod.Text;
			var errorMessage = "";
			var isError = false;
			if (string.IsNullOrEmpty(BookName))
			{
				errorMessage += "Kitap Adını Boş Geçemezsiniz!\r\n";
				isError = true;
			}
			if (string.IsNullOrEmpty(WriterName))
			{
				errorMessage += "Yazar Adını Boş Geçemezsiniz!\r\n";
				isError = true;
			}
			if (string.IsNullOrEmpty(Page))
			{
				errorMessage += "Sayfa Sayısını Boş Geçemezsiniz!\r\n";
				isError = true;
			}
			if (string.IsNullOrEmpty(Published))
			{
				errorMessage += "Yayın Evini Boş Geçemezsiniz!\r\n";
				isError = true;
			}
			if (string.IsNullOrEmpty(Barkod))
			{
				errorMessage += "Barkod Kısmını Boş Geçemezsiniz!\r\n";
				isError = true;
			}
			if (isError)
			{
				MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}

		private void ListBook()
		{
			var query = from d1 in db.TBLKİTAPLAR
						join d2 in db.TBLAVERAGE_SCORE
						on d1.ID equals d2.BookID
						select new
						{
							KİTAPAD = d1.BookName,
							YAZAR = d1.WriterName,
							SAYFA = d1.PageNumber,
							YAYINEVİ = d1.Publisher,
							BARKOD = d1.Barkod,
							KİTAP_ADED = d1.BookPiece,
							PUAN = d2.AverageStar,
							AKTİFLİK = d1.İsActivite
						};
			dataGridView1.DataSource = query.ToList();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			position(btnAdd);
			active(btnAdd);
			bool sonuc = BosTextKontrol();
			int PageNumber = Convert.ToInt32(txtBoxPage.Text);
			var Eklenmekİstenen = (from item in db.TBLKİTAPLAR
								   where item.BookName == txtBoxBookName.Text &&
										 item.PageNumber == PageNumber &&
										 item.Publisher == txtBoxPublished.Text &&
										 item.WriterName == txtBoxWriterName.Text &&
										 item.İsActivite == CheckedBoxIsActive.Checked &&
										 item.Barkod == txtBoxBarkod.Text
								   select item).FirstOrDefault();

			var BarkodKontrol = (from item in db.TBLKİTAPLAR
								 where item.Barkod == txtBoxBarkod.Text
								 select item).FirstOrDefault();

			if (Eklenmekİstenen != null && sonuc)
			{

				Eklenmekİstenen.BookPiece++;
				db.SaveChanges();
				ListBook();

			}
			else
			{
				if (BarkodKontrol == null)
				{
					TBLKİTAPLAR ktp = new TBLKİTAPLAR();
					ktp.BookName = txtBoxBookName.Text;
					ktp.PageNumber = Convert.ToInt32(txtBoxPage.Text);
					ktp.Publisher = txtBoxPublished.Text;
					ktp.WriterName = txtBoxWriterName.Text;
					ktp.İsActivite = CheckedBoxIsActive.Checked;
					ktp.Barkod = txtBoxBarkod.Text;
					ktp.BookPiece = 1;
					db.TBLKİTAPLAR.Add(ktp);
					db.SaveChanges();
					var ktp2= (from item in db.TBLKİTAPLAR
							   where item.Barkod == txtBoxBarkod.Text
							   select item).FirstOrDefault();
					TBLAVERAGE_SCORE avr = new TBLAVERAGE_SCORE();
					avr.BookID = ktp.ID;
					avr.AverageStar = 5;
					avr.VotePiece=0;
					db.TBLAVERAGE_SCORE.Add(avr);
					db.SaveChanges();
					MessageBox.Show("Kitap Eklendi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ListBook();
				}
				else
				{
					MessageBox.Show("Bu Barkod İle Kayıtlı Kitap Zaten Var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				ListBook();
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			position(btnUpdate);
			active(btnUpdate);
			bool Kontrol = BosTextKontrol();
			if (Kontrol)
			{
				var ktp = db.TBLKİTAPLAR.Where(a => a.Barkod == txtBoxBarkod.Text).FirstOrDefault();
				ktp.BookName = txtBoxBookName.Text;
				ktp.PageNumber = Convert.ToInt32(txtBoxPage.Text);
				ktp.Publisher = txtBoxPublished.Text;
				ktp.WriterName = txtBoxWriterName.Text;
				ktp.İsActivite = CheckedBoxIsActive.Checked;
				ktp.BookPiece = Convert.ToInt32(txtBoxBookPiece.Text);
				db.SaveChanges();
				ListBook();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			position(btnDelete);
			active(btnDelete);
			int PageNumber = Convert.ToInt32(txtBoxPage.Text);
			var ktp = db.TBLKİTAPLAR.Where(a => a.Barkod == txtBoxBarkod.Text).FirstOrDefault();
			var avr = (from item in db.TBLAVERAGE_SCORE
					   where item.BookID == ktp.ID
					   select item).FirstOrDefault();
			var TBLAVER_NOTE = from item in db.TBLAVERAGE_NOTE
							   where item.BookID == ktp.ID
							   select item;
			foreach (var item in TBLAVER_NOTE)
			{
				db.TBLAVERAGE_NOTE.Remove(item);
			}
			db.TBLAVERAGE_SCORE.Remove(avr);
			db.TBLKİTAPLAR.Remove(ktp);
			db.SaveChanges();
			db.SaveChanges();
			ListBook();
		}

		private void btnDuyuruEkle_Click(object sender, EventArgs e)
		{
			TBLDUYURU DuyuruNesne = new TBLDUYURU();
			DuyuruNesne.Duyuru = richTextBoxDuyuru.Text;
			string TarihBİlgi = DateTime.Now.ToString();
			DuyuruNesne.LastDate = Convert.ToDateTime(TarihBİlgi);
			db.TBLDUYURU.Add(DuyuruNesne);
			db.SaveChanges();
			MessageBox.Show("Duyuru Eklendi");
			richTextBoxDuyuru.Text = "";
		}

		private void Form4_Load(object sender, EventArgs e)
		{
			p1.Height = btnAdd.Height;
			position(btnAdd);
			active(btnAdd);
			this.Location = Screen.AllScreens[0].WorkingArea.Location;
			var NameAndSurname = (from item in db.TBLUSER
								  where item.UserName == TumFormlar.Username &&
								  item.UserPassword == TumFormlar.Password
								  select item).FirstOrDefault();
			lblWelcome.Text = "Admin : " + NameAndSurname.Name + " " + NameAndSurname.Surname;
			pictureBox1.ImageLocation = NameAndSurname.Fotograf;
			ListBook();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Application.Exit();
			this.Dispose();
		}

		private void btnFotografSec_Click(object sender, EventArgs e)
		{
			var NameAndSurname = (from item in db.TBLUSER
								  where item.UserName == TumFormlar.Username&&
								  item.UserPassword==TumFormlar.Password
								  select item).FirstOrDefault();

			openFileDialog1.ShowDialog();
			NameAndSurname.Fotograf = openFileDialog1.FileName;

			db.SaveChanges();
			pictureBox1.ImageLocation = NameAndSurname.Fotograf;
		}

		private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			txtBoxBookName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			txtBoxWriterName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			txtBoxPage.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			txtBoxPublished.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			txtBoxBarkod.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			txtBoxBookPiece.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
			txtBoxAverageStar.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
			CheckedBoxIsActive.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[7].Value);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void Manager_MouseUp(object sender, MouseEventArgs e)
		{
			mov = 0;
		}

		private void Manager_MouseDown(object sender, MouseEventArgs e)
		{
			mov = 1;
			movX = e.X;
			movY = e.Y;
		}

		private void Manager_MouseMove(object sender, MouseEventArgs e)
		{
			if (mov == 1)
			{
				this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
			}
		}

		private void panel2_MouseUp(object sender, MouseEventArgs e)
		{
			mov = 0;
		}

		private void panel2_MouseDown(object sender, MouseEventArgs e)
		{
			mov = 1;
			movX = e.X;
			movY = e.Y;
		}

		private void panel2_MouseMove(object sender, MouseEventArgs e)
		{
			if (mov == 1)
			{
				this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
			}
		}

		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			mov = 0;
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			mov = 1;
			movX = e.X;
			movY = e.Y;
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (mov == 1)
			{
				this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			TumFormlar.FormCalis(1);
		}
	}
}
