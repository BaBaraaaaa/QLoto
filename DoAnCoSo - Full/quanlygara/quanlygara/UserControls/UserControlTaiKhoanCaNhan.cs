using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlygara.UserControls
{
    public partial class UserControlTaiKhoanCaNhan : UserControl
    {
        public UserControlTaiKhoanCaNhan()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        String hotennv, cccd, gioitinh, sdt, email, diachi;

        private void button_TruocKhiDoiMatKhau_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau f = new FormDoiMatKhau();
            f.ShowDialog();
        }

        DateTime ngaysinh;
        private void UserControlTaiKhoanCaNhan_Load(object sender, EventArgs e)
        {
            getThongtinByID(Form1.manv);
            textBox_TenNV.Text = hotennv;
            textBox_Manv.Text = Form1.manv;
            textBoxCNND.Text = cccd;
            textBoxGioiTinh.Text = gioitinh;
            textBoxSDT.Text = sdt;
            textBoxEmail.Text = email;
            textBoxDiaChi.Text = diachi;
        }
        public void getThongtinByID(String id)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SqlSelect = "select *from nhanvien where manv='" + id + "'";
                SqlCommand cmd = new SqlCommand(SqlSelect, con);
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    hotennv = data.GetString(1);
                    cccd = data.GetString(2);
                    ngaysinh =Convert.ToDateTime(data.GetDateTime(3).ToString());
                    gioitinh = data.GetString(4);
                    sdt = data.GetString(5);
                    email = data.GetString(6);
                    diachi = data.GetString(7);
                }
                con.Close();
                data.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy thông tin admin " + ex.Message);
            }
        }
        private void button_DangXuat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
