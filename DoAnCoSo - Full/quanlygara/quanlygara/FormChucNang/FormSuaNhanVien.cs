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
    public partial class FormSuaNhanVien : Form
    {
        public FormSuaNhanVien()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        public static String manv, hotennv, cccd, ngaysinh, gioitinh, sdt, email, diachi;

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SqlUpdate = "UPDATE nhanvien SET hotennv=@hotennv, cccd=@cccd, ngaysinh=@ngaysinh, gioitinh=@gioitinh, sdt=@sdt, email=@email, diachi=@diachi WHERE manv=@manv";
                SqlCommand cmd = new SqlCommand(SqlUpdate, con);
                cmd.Parameters.AddWithValue("manv", textBoxMaNV.Text);
                cmd.Parameters.AddWithValue("hotennv", textBoxHoTen.Text);
                cmd.Parameters.AddWithValue("cccd", textBoxCMNN.Text);
                cmd.Parameters.AddWithValue("ngaysinh", dateTimePickerNgaySinh.Value.Date);
                cmd.Parameters.AddWithValue("gioitinh", comboBoxGioiTinh.Text);
                cmd.Parameters.AddWithValue("sdt", textBoxSDT.Text);
                cmd.Parameters.AddWithValue("email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("diachi", textBoxDiachi.Text);
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

        private void FormSuaNhanVien_Load(object sender, EventArgs e)
        {
            textBoxMaNV.Text = manv;
            textBoxHoTen.Text = hotennv;
            textBoxCMNN.Text = cccd;
            dateTimePickerNgaySinh.Value = Convert.ToDateTime(ngaysinh);
            comboBoxGioiTinh.Text = gioitinh;
            textBoxSDT.Text = sdt;
            textBoxEmail.Text = email;
            textBoxDiachi.Text = diachi;
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
