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
    public partial class FormSuaLoaiHang : Form
    {
        public FormSuaLoaiHang()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        public static String tenloaihang = "";
        public static String maloaihang = "";
        private void FormSuaLoaiHang_Load(object sender, EventArgs e)
        {
            textBoxLoaiHang.Text = tenloaihang;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SqlUpdate = "UPDATE loaihang SET tenloaihang=@tenloaihang WHERE maloaihang=@maloaihang";
                SqlCommand cmd = new SqlCommand(SqlUpdate, con);
                cmd.Parameters.AddWithValue("tenloaihang", textBoxLoaiHang.Text);
                cmd.Parameters.AddWithValue("maloaihang", maloaihang);
                cmd.ExecuteNonQuery();
                UserControlDanhMucChung.checkdataChange = true;
                con.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa đổi dữ liệu thất bại ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
