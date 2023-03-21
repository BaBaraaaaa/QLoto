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
    public partial class FormSuaPhanQuyen : Form
    {
        public FormSuaPhanQuyen()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        public static String tendangnhap, matkhau, quyen, active;
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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn khôi phục lại mật khẩu cho tài khoản này ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection con = new SqlConnection(chuoikn);
                    con.Open();
                    String SqlUpdate = "UPDATE dangnhap SET matkhau=@matkhau WHERE tendangnhap=@tendangnhap";
                    SqlCommand cmd = new SqlCommand(SqlUpdate, con);
                    cmd.Parameters.AddWithValue("matkhau", CreateMD5("12345"));
                    cmd.Parameters.AddWithValue("tendangnhap", tendangnhap);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    textBoxMatKhau.Text = CreateMD5("12345");
                    UserControlDanhMucChung.checkdataChange = true;
                    MessageBox.Show("Mật khẩu đã được khôi phục về mật định");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa đổi dữ liệu thất bại ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void radioButtonChan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SqlUpdate = "UPDATE dangnhap SET matkhau=@matkhau, quyen=@quyen, active=@active WHERE tendangnhap=@tendangnhap";
                SqlCommand cmd = new SqlCommand(SqlUpdate, con);
                cmd.Parameters.AddWithValue("matkhau", textBoxMatKhau.Text);
                cmd.Parameters.AddWithValue("quyen", comboBoxQuyenDangNhap.Text);
                if (radioButtonChoPhep.Checked == true)
                {
                    cmd.Parameters.AddWithValue("active", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("active", 0);
                }
                cmd.Parameters.AddWithValue("tendangnhap", tendangnhap);
                cmd.ExecuteNonQuery();
                con.Close();
                UserControlDanhMucChung.checkdataChange = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa đổi dữ liệu thất bại ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void FormSuaPhanQuyen_Load(object sender, EventArgs e)
        {
            textBoxMaNV.Text = tendangnhap;
            textBoxMatKhau.Text = matkhau;
            comboBoxQuyenDangNhap.Text = quyen;
            if (Convert.ToInt32(active) == 0)
            {
                radioButtonChan.Checked = true;
            }
            else
            {
                radioButtonChoPhep.Checked = true;
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
