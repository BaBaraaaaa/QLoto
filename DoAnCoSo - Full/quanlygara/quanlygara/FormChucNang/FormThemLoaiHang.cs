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
    public partial class FormThemLoaiHang : Form
    {
        public FormThemLoaiHang()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
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
                String SqlInsert = "INSERT INTO loaihang VALUES(@tenloaihang)";
                SqlCommand cmd = new SqlCommand(SqlInsert, con);
                cmd.Parameters.AddWithValue("tenloaihang", textBoxLoaiHang.Text);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Thêm dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                UserControlDanhMucChung.checkdataChange = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm loại hàng: " + ex.Message);
            }
        }
    }
}
