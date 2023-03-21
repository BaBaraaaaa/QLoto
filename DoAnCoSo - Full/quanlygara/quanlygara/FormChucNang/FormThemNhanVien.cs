using quanlygara.UserControls;
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

namespace quanlygara.FormChucNang
{
    public partial class FormThemNhanVien : Form
    {
        public FormThemNhanVien()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SqlInsert = "INSERT INTO nhanvien VALUES(@manv, @hotennv,@cccd,@ngaysinh,@gioitinh,@sdt,@email,@diachi)";
                SqlCommand cmd = new SqlCommand(SqlInsert, con);
                cmd.Parameters.AddWithValue("manv", textBoxMaNV.Text);
                cmd.Parameters.AddWithValue("hotennv", textBoxHoTen.Text);
                cmd.Parameters.AddWithValue("cccd", textBoxCMNN.Text);
                cmd.Parameters.AddWithValue("ngaysinh", dateTimePickerNgaySinh.Value.Date);
                cmd.Parameters.AddWithValue("gioitinh", comboBoxGioiTinh.Text);
                cmd.Parameters.AddWithValue("sdt", textBoxSDT.Text);
                cmd.Parameters.AddWithValue("email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("diachi", textBoxDiachi.Text);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Thêm dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                SqlConnection con2 = new SqlConnection(chuoikn);
                con2.Open();
                String SqlInsert2 = "INSERT INTO dangnhap VALUES(@tendangnhap, @matkhau,@quyen,@active)";
                SqlCommand cmd2 = new SqlCommand(SqlInsert2, con2);
                cmd2.Parameters.AddWithValue("tendangnhap", textBoxMaNV.Text);
                cmd2.Parameters.AddWithValue("matkhau", CreateMD5("12345"));//mật định 12345 =>> người dùng có thể tự đổi lại sau khi đăng nhập
                cmd2.Parameters.AddWithValue("quyen", "Chưa phân quyền");
                cmd2.Parameters.AddWithValue("active",0);
                cmd2.ExecuteNonQuery();
                //MessageBox.Show("Thêm dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con2.Close();

                UserControlDanhMucChung.checkdataChange = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm nhân viên: " + ex.ToString());
            }
        }
    }
}
