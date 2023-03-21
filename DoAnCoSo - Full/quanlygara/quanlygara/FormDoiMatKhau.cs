using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlygara
{
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        public static String matkhau;
        public string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBoxMatkhauCu.Text.Equals(matkhau))
            {
                MessageBox.Show("Mật khẩu cũ không đúng, vui lòng thử lại");
                return;
            }
            if (textBoxMoi.Text.Equals(textBoxXacNhanMK.Text))
            {
                try
                {
                    SqlConnection con = new SqlConnection(chuoikn);
                    con.Open();
                    String SqlUpdate = "UPDATE dangnhap SET matkhau=@matkhau WHERE tendangnhap=@tendangnhap";
                    SqlCommand cmd = new SqlCommand(SqlUpdate, con);
                    cmd.Parameters.AddWithValue("matkhau", CreateMD5(textBoxMoi.Text));
                    cmd.Parameters.AddWithValue("tendangnhap", Form1.manv);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Đổi mật khẩu thành công, vui lòng đăng nhập lại");
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa đổi dữ liệu thất bại ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu xác nhận không trùng khớp");
            }
        }
    }
}
