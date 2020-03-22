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
	public partial class User : Form
	{
		public User()
		{
			InitializeComponent();
		}
		KUTUPHANEEntities1 db = new KUTUPHANEEntities1();
		string KitapAd, Yazar, YayinEv;
		int Sayfa;
		int mov;
		int movX;
		int movY;

		public void AllListele()
		{
			var query = from d1 in db.TBLKİTAPLAR
						join d2 in db.TBLAVERAGE_SCORE on d1.ID equals d2.BookID
						where d1.İsActivite == true
						select new
						{
							KİTAPAD = d1.BookName,
							YAZAR = d1.WriterName,
							SAYFA = d1.PageNumber,
							YAYINEVİ = d1.Publisher,
							PUAN = d2.AverageStar
						};
			dataGridView1.DataSource = query.ToList();
		}

		public void AlinanListele()
		{
			var sorgu = from d1 in db.TBLKİTAPLAR
						join d2 in db.TBLAVERAGE_SCORE on d1.ID equals d2.BookID
						join d3 in db.TBLSECİLEN_KİTAPLAR on d1.ID equals d3.BookID
						join d4 in db.TBLUSER on d3.UserID equals d4.UserID
						where d4.UserName == TumFormlar.Username && d4.UserPassword == TumFormlar.Password
						select new
						{
							KİTAPAD = d1.BookName,
							YAZAR = d1.WriterName,
							SAYFA = d1.PageNumber,
							YAYINEVİ = d1.Publisher,
							PUAN = d2.AverageStar
						};
			dataGridView1.DataSource = sorgu.ToList();
		}

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

		private void Form3_Load(object sender, EventArgs e)
		{
			p1.Height = btnKitapAl.Height;
			position(btnKitapAl);
			active(btnKitapAl);
			this.Location = Screen.AllScreens[0].WorkingArea.Location;
			var NameAndSurname = (from item in db.TBLUSER
								  where item.UserName == TumFormlar.Username &&
								  item.UserPassword == TumFormlar.Password
								  select item).FirstOrDefault();
			lblAdSoyad.Text = "KULLANICI " + NameAndSurname.Name + " " + NameAndSurname.Surname;
			pictureBox1.ImageLocation = NameAndSurname.Fotograf;
			AllListele();
		}

		private void btnVoting_Click(object sender, EventArgs e)
		{
			var SECİLEN = (from item in db.TBLKİTAPLAR
						   where item.BookName == KitapAd && 
								 item.WriterName == Yazar &&
								 item.PageNumber == Sayfa &&
								 item.Publisher == YayinEv
						   select item).FirstOrDefault();

			var SECİLEN_TBLORTALAMA = (from item in db.TBLAVERAGE_SCORE
						   where item.BookID==SECİLEN.ID
						   select item).FirstOrDefault();

			var PUANSIZ= (from item in db.TBLAVERAGE_SCORE
						  where item.BookID == SECİLEN.ID&&
						  item.VotePiece==0
						  select item).FirstOrDefault();

			var NameAndSurname = (from item in db.TBLUSER
								  where item.UserName == TumFormlar.Username &&
								  item.UserPassword == TumFormlar.Password
								  select item).FirstOrDefault();

			var ONCEDEN_VERİLEN_OY_KONTROL= (from item in db.TBLAVERAGE_NOTE
											 where item.BookID==SECİLEN.ID &&
											 item.UserID==NameAndSurname.UserID
											 select item).FirstOrDefault();

			var errorMessage = "";
			var isError = false;
			int PUAN = Convert.ToInt32(txtBoxVote.Text);

			if (PUAN > 5 || PUAN < 0)
			{
				errorMessage += "0-5 Arasında Puan Verebilirsiniz!\r\n";
				isError = true;
			}
			if (txtBoxVote.Text == null)
			{
				errorMessage += "Puanını Belirtmedin!\r\n";
				isError = true;
			}
			if (ONCEDEN_VERİLEN_OY_KONTROL != null)
			{
				errorMessage += "Bu Kitaba Daha Önce Oy Vermişsiniz!\r\n";
				isError = true;
			}
			if (isError)
			{
				MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (isError == false)
			{

				try
				{
					if (PUANSIZ != null)
					{
						var PuanEkle = (from item in db.TBLAVERAGE_SCORE
										where item.BookID == SECİLEN.ID
										select item).FirstOrDefault();
						PuanEkle.AverageStar = Convert.ToDecimal(txtBoxVote.Text);
						PuanEkle.VotePiece = 1;
						db.SaveChanges();

						TBLAVERAGE_NOTE Biri = new TBLAVERAGE_NOTE();
						Biri.BookID = SECİLEN.ID;
						Biri.Point = Convert.ToDecimal(txtBoxVote.Text);
						Biri.UserID = NameAndSurname.UserID;
						db.TBLAVERAGE_NOTE.Add(Biri);
						db.SaveChanges();

						AllListele();
						MessageBox.Show("Oy Verdiğiniz İçin Teşekkürler", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						decimal Ortalama = SECİLEN_TBLORTALAMA.AverageStar;
						int OySayisi = SECİLEN_TBLORTALAMA.VotePiece;
						double NetOrt = Convert.ToDouble(Ortalama * OySayisi);
						double EklenecekDeger = Convert.ToDouble(txtBoxVote.Text);
						double Sonuc = Convert.ToDouble(NetOrt) + Convert.ToDouble(EklenecekDeger);
						Sonuc /= (OySayisi + 1);
						SECİLEN_TBLORTALAMA.VotePiece++;
						SECİLEN_TBLORTALAMA.AverageStar = Convert.ToDecimal(Sonuc);
						TBLAVERAGE_NOTE Biri = new TBLAVERAGE_NOTE();
						Biri.BookID = SECİLEN.ID;
						Biri.Point = Convert.ToDecimal(txtBoxVote.Text);
						Biri.UserID = NameAndSurname.UserID;
						db.TBLAVERAGE_NOTE.Add(Biri);
						db.SaveChanges();
						AllListele();
						MessageBox.Show("Oy Verdiğiniz İçin Teşekkürler", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				catch (Exception hata)
				{
					TBLHATA ht = new TBLHATA();
					ht.Message = hata.ToString();
					ht.LastDate = Convert.ToDateTime(DateTime.Now.ToString());
					db.TBLHATA.Add(ht);
					db.SaveChanges();
					MessageBox.Show("Oy İşlemi Gerçekleştirilemedi Daha Sonra Tekrar Deneyiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
				

		}

		private void btnKitapAl_Click(object sender, EventArgs e)
		{
			var SECİLEN = (from item in db.TBLKİTAPLAR
						   where item.BookName == KitapAd &&
						   item.WriterName == Yazar &&
						   item.Publisher == YayinEv
						   select item).FirstOrDefault();

			var ALİNAN_SECİLEN = (from item in db.TBLSECİLEN_KİTAPLAR
								  where item.BookID == SECİLEN.ID
								  select item).FirstOrDefault();


			
				if (SECİLEN == null)
				{
					MessageBox.Show("Kitap Seçmediniz!");
				}
				else if (ALİNAN_SECİLEN != null)
				{
					MessageBox.Show("Bu Kitabı Zaten Almışsınız!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					DialogResult secenek = MessageBox.Show(SECİLEN.BookName + " Kitabını Almak İstiyor musunuz?", "Onay Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if (secenek == DialogResult.Yes)
					{
					TBLSECİLEN_KİTAPLAR sclnktp = new TBLSECİLEN_KİTAPLAR();
					var NameAndSurname = (from item in db.TBLUSER
										  where item.UserName == TumFormlar.Username &&
										  item.UserPassword == TumFormlar.Password
										  select item).FirstOrDefault();
					sclnktp.BookID = SECİLEN.ID;
					sclnktp.UserID = NameAndSurname.UserID;
					SECİLEN.İsActivite = false;
					db.TBLSECİLEN_KİTAPLAR.Add(sclnktp);
					db.SaveChanges();
					AllListele();
					}
				}
			
			
		}

		private void btnKitapVer_Click(object sender, EventArgs e)
		{
			position(btnKitapVer);
			active(btnKitapVer);
			var SECİLEN = (from item in db.TBLKİTAPLAR
						   where item.BookName == KitapAd &&
						   item.WriterName == Yazar &&
						   item.Publisher == YayinEv &&
						   item.İsActivite == false
						   select item).FirstOrDefault();
			if (SECİLEN == null)
			{
				MessageBox.Show("Kitap Seçmediniz!");
			}
			else
			{
				TBLSECİLEN_KİTAPLAR sclnktp = new TBLSECİLEN_KİTAPLAR();
				var NameAndSurname = (from item in db.TBLUSER
									  where item.UserName == TumFormlar.Username &&
									  item.UserPassword == TumFormlar.Password
									  select item).FirstOrDefault();
				sclnktp = (from item in db.TBLSECİLEN_KİTAPLAR
						   where item.BookID == SECİLEN.ID &&
						   item.UserID == NameAndSurname.UserID
						   select item).FirstOrDefault();
				SECİLEN.İsActivite = true;
				db.TBLSECİLEN_KİTAPLAR.Remove(sclnktp);
				db.SaveChanges();
				AlinanListele();
			}
		}

		private void btnAlinan_Click(object sender, EventArgs e)
		{
			position(btnAlinan);
			active(btnAlinan);
			AlinanListele();
		}

		private void btnTumKitap_Click(object sender, EventArgs e)
		{
			position(btnTumKitap);
			active(btnTumKitap);
			AllListele();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Application.Exit();
			this.Dispose();
		}

		private void Form3_MouseMove(object sender, MouseEventArgs e)
		{
			if (mov == 1)
			{
				this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
			}
		}

		private void Form3_MouseUp(object sender, MouseEventArgs e)
		{
			mov = 0;
		}

		private void Form3_MouseDown(object sender, MouseEventArgs e)
		{
			mov = 1;
			movX = e.X;
			movY = e.Y;
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

		private void panel1_MouseUp(object sender, MouseEventArgs e)
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

		private void panel2_MouseUp(object sender, MouseEventArgs e)
		{
			mov = 0;
		}

		private void txtBoxBookName_TextChanged(object sender, EventArgs e)
		{
			string Aranan = txtBoxBookName.Text;
			var Degerler = from d1 in db.TBLKİTAPLAR
						   join d2 in db.TBLAVERAGE_SCORE
						   on d1.ID equals d2.BookID
						   where d1.BookName.Contains(Aranan)
							   select new { KİTAPAD = d1.BookName,
								   YAZAR = d1.WriterName,
								   SAYFA = d1.PageNumber,
								   YAYINEVİ = d1.Publisher,
								   PUAN = d2.AverageStar};
				dataGridView1.DataSource = Degerler.ToList();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			TumFormlar.FormCalis(1);
		}

		private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
		{
			KitapAd = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			Yazar = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			Sayfa = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
			YayinEv = dataGridView1.CurrentRow.Cells[3].Value.ToString();
		}

		private void btnFotografSec_Click(object sender, EventArgs e)
		{
			KUTUPHANEEntities1 db = new KUTUPHANEEntities1();
			var NameAndSurname = (from item in db.TBLUSER
								  where item.UserName == TumFormlar.Username&&
								  item.UserPassword==TumFormlar.Password
								  select item).FirstOrDefault();
			openFileDialog1.ShowDialog();
			NameAndSurname.Fotograf = openFileDialog1.FileName;
			db.SaveChanges();
			pictureBox1.ImageLocation = NameAndSurname.Fotograf;

		}
	}
}
