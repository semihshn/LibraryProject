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
	public partial class UserRepair : Form
	{
		public UserRepair()
		{
			InitializeComponent();
		}

		KUTUPHANEEntities1 db = new KUTUPHANEEntities1();

		int mov;
		int movX;
		int movY;
		String TC;

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
			var YetkiID = txtBoxYetkiID.Text;
			var Username = txtBoxUserName.Text;
			var Password = txtBoxPassword.Text;
			var Name = txtBoxName.Text;
			var Surname = txtBoxSurname.Text;
			var errorMessage = "";
			var isError = false;
			if (string.IsNullOrEmpty(YetkiID))
			{
				errorMessage += "Yetki No Boş Geçemezsiniz!\r\n";
				isError = true;
			}
			if (string.IsNullOrEmpty(Username))
			{
				errorMessage += "Kullanıcı Adını Boş Geçemezsiniz!\r\n";
				isError = true;
			}
			if (string.IsNullOrEmpty(Password))
			{
				errorMessage += "Şifreyi Boş Geçemezsiniz!\r\n";
				isError = true;
			}
			if (string.IsNullOrEmpty(Name))
			{
				errorMessage += "İsim Kısmını Boş Geçemezsiniz!\r\n";
				isError = true;
			}
			if (string.IsNullOrEmpty(Surname))
			{
				errorMessage += "Soyadı Kısmını Boş Geçemezsiniz!\r\n";
				isError = true;
			}
			if (isError)
			{
				MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}

		public void KullanicilerList()
		{
			var query = from item in db.TBLUSER
						select new
						{
							YETKİ_NO = item.YetkiID,
							KULLANICI_AD = item.UserName,
							ŞİFRE = item.UserPassword,
							İSİM = item.Name,
							SOYİSİM = item.Surname,
							Tc = item.TC,
							AKTİFLİK = item.IsActive

						};
			dataGridView1.DataSource = query.ToList();
		}


		private void UserRepair_Load(object sender, EventArgs e)
		{
			KullanicilerList();
		}

		private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			txtBoxYetkiID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			txtBoxUserName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			txtBoxPassword.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			txtBoxName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			txtBoxSurname.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			txtBoxTC.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
			TC = dataGridView1.CurrentRow.Cells[5].Value.ToString();
			CheckedBoxIsActive.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[6].Value);
			lblWelcome.Text = txtBoxName.Text + " " + txtBoxSurname.Text;
			var TC_Kontrol = (from item in db.TBLUSER
							  where item.TC == txtBoxTC.Text
							  select item).FirstOrDefault();
			pictureBox1.ImageLocation = TC_Kontrol.Fotograf;


		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			int TC_HANESİ = txtBoxTC.Text.Length;

			position(btnAdd);
			active(btnAdd);
			bool sonuc = BosTextKontrol();
			int YetkiID = Convert.ToInt32(txtBoxYetkiID.Text);
			var Eklenmekİstenen = (from item in db.TBLUSER
								   where item.YetkiID == YetkiID &&
										 item.UserName == txtBoxUserName.Text &&
										 item.UserPassword == txtBoxPassword.Text &&
										 item.Name == txtBoxName.Text &&
										 item.Surname == txtBoxSurname.Text &&
										 item.TC == txtBoxTC.Text &&
										 item.IsActive == CheckedBoxIsActive.Checked
								   select item).FirstOrDefault();

			var TC_Kontrol = (from item in db.TBLUSER
							  where item.TC == txtBoxTC.Text
							  select item).FirstOrDefault();
			if (TC_HANESİ > 11 || TC_HANESİ < 11)
			{
				MessageBox.Show("TC 11 Haneli Olmalıdır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}else if (Eklenmekİstenen != null && sonuc)
				{
					MessageBox.Show("Bu Kullanıcı Zaten Var!");
					KullanicilerList();

				}
				else
				{
					if (TC_Kontrol == null)
					{
						TBLUSER usr = new TBLUSER();
						short YetkiID2 = short.Parse(txtBoxYetkiID.Text);
						usr.YetkiID = YetkiID2;
						usr.UserName = txtBoxUserName.Text;
						usr.UserPassword = txtBoxPassword.Text;
						usr.Name = txtBoxName.Text;
						usr.Surname = txtBoxSurname.Text;
						usr.TC = txtBoxTC.Text;
						usr.IsActive = CheckedBoxIsActive.Checked;
						db.TBLUSER.Add(usr);
						db.SaveChanges();
					}
					else
					{
						MessageBox.Show("Bu TC İle Kayıtlı Kullanıcı Zaten Var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

					KullanicilerList();
				}
			
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			position(btnUpdate);
			active(btnUpdate);
			bool Kontrol = BosTextKontrol();
			string TC2 = txtBoxTC.Text;
			if (TC!=TC2)
			{
				MessageBox.Show("Kullanıcı TC Güncellenemez Kullanıcıyı Silip Tekrar Yükleyiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}else if (Kontrol)
			{
				var usr = db.TBLUSER.Where(a => a.TC == txtBoxTC.Text).FirstOrDefault();
				usr.UserName = txtBoxUserName.Text;
				usr.UserPassword = txtBoxPassword.Text;
				usr.Name = txtBoxName.Text;
				usr.Surname = txtBoxSurname.Text;
				usr.IsActive = CheckedBoxIsActive.Checked;
				db.SaveChanges();
				KullanicilerList();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			position(btnDelete);
			active(btnDelete);
			var TC_Kontrol = (from item in db.TBLUSER
							  where item.TC == txtBoxTC.Text
							  select item).FirstOrDefault();

			var TBLAVER_NOTE = from item in db.TBLAVERAGE_NOTE
							   where item.UserID == TC_Kontrol.UserID
							   select item;
			foreach (var item in TBLAVER_NOTE)
			{
				db.TBLAVERAGE_NOTE.Remove(item);
			}

			var usr = db.TBLUSER.Where(a => a.TC == txtBoxTC.Text).FirstOrDefault();
			db.TBLUSER.Remove(usr);
			db.SaveChanges();

			KullanicilerList();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Application.Exit();
			this.Dispose();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
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

		private void UserRepair_MouseUp(object sender, MouseEventArgs e)
		{
			mov = 0;
		}

		private void UserRepair_MouseDown(object sender, MouseEventArgs e)
		{
			mov = 1;
			movX = e.X;
			movY = e.Y;
		}

		private void UserRepair_MouseMove(object sender, MouseEventArgs e)
		{
			if (mov == 1)
			{
				this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
			}
		}

		private void btnFotografSec_Click(object sender, EventArgs e)
		{
			var NameAndSurname = (from item in db.TBLUSER
								  where item.UserName == txtBoxUserName.Text&&
								  item.UserPassword==txtBoxPassword.Text
								  select item).FirstOrDefault();

			openFileDialog1.ShowDialog();
			NameAndSurname.Fotograf = openFileDialog1.FileName;

			db.SaveChanges();
			pictureBox1.ImageLocation = NameAndSurname.Fotograf;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			TumFormlar.FormCalis(5);
		}
	}
}
