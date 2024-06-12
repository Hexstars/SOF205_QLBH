using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using _2_BUS_QLBH;

namespace _1_GUI_QLBH
{
    public partial class frmCapNhatMK : Form
    {
        public frmCapNhatMK()
        {
            InitializeComponent();
        }
        frmDangNhap quenMk = new frmDangNhap();

        private void frmCapNhatMK_Load(object sender, EventArgs e)
        {
        }
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            if (lowerCase)
            {
                return builder.ToString().ToLower();
            }
            return builder.ToString();
        }

        //Tao so ngau nhien
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public void SendMail(string email, string maxacnhan)
        {
            try
            {
                //Now we must create a new Smtp client to send our email.
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //smtp.gmail.com // For Gmail //Authentication.
                                                                           //This is where the valid email account comes into play. You must have a valid email //account (with password) to give our program a place to send the mail from.
                NetworkCredential cred = new NetworkCredential("baotncps40789@gmail.com", "jflb jhdg dqht lwra");
                //To send an email we must first create a new mailMessage (an email) to send. 
                MailMessage Msg = new MailMessage();
                // Sender e-mail address.
                Msg.From = new MailAddress("baotncps40789@gmail.com"); //Nothing But Above Credentials or your credentials (*******@gmail.com) // Recipient e-mail address.
                Msg.To.Add(email);
                // Assign the subject of our message.
                Msg.Subject = "Anh/chị đã sử dụng tính năng quên mật khẩu";
                // Create the content (body) of our message.
                Msg.Body = "Chào anh/chị. Mã xác nhận là: " + maxacnhan;
                // Send our account login details to the client.
                client.Credentials = cred;
                //Enabling SSL (Secure Sockets Layer, encyription) is reqiured by most email providers to send mail
                client.EnableSsl = true;
                client.Send(Msg); // Send our email.
            }
            catch (Exception)
            {
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Hãy nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            else if (txtMaXN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Hãy nhập mã xác nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaXN.Focus();
                return;
            }
            else if (txtMKmoi1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Hãy nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMKmoi1.Focus();
                return;
            }
            else if (txtMKmoi1.Text.Trim().Length < 7)
            {
                MessageBox.Show("Mật khẩu mới phải dài hơn 7 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMKmoi1.Focus();
                return;
            }
            else if (txtMKmoi2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Hãy nhập lại mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMKmoi2.Focus();
                return;
            }
            else
            {
                if (txtMaXN.Text != maXacNhan)
                {
                    MessageBox.Show("Mã xác nhận không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaXN.Focus();
                    return;
                }
                else if (txtMKmoi2.Text != txtMKmoi1.Text)
                {
                    MessageBox.Show("Mật khẩu không giống nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMKmoi2.Focus();
                    return;
                }
                else
                {
                    BUS_NhanVien busNhanVien = new BUS_NhanVien();
                    string EmailNV = txtEmail.Text;
                    string MatKhauMoi = busNhanVien.encryption(txtMKmoi1.Text);

                    if (busNhanVien.CapNhatMK(EmailNV, MatKhauMoi))//cap nhat mat khau thanh cong
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        maXacNhan = null;

                        txtEmail.Clear();
                        txtMaXN.Clear();
                        txtMKmoi1.Clear();
                        txtMKmoi2.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        BUS_NhanVien busNV = new BUS_NhanVien();

        string maXacNhan;
        private void btnGuiMa_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "")
            {
                if (busNV.NhanVienQuenMK(txtEmail.Text))
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(RandomString(4, true));
                    builder.Append(RandomNumber(1000, 9999));
                    builder.Append(RandomString(2, false));

                    maXacNhan = builder.ToString();

                    SendMail(txtEmail.Text, maXacNhan);

                    MessageBox.Show($"Mã xác nhận đã được gửi về {txtEmail.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaXN.Focus();
                }
                else
                {
                    MessageBox.Show("Email không tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
        }
    }
}
