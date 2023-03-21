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
    public partial class FormSuaHangSX : Form
    {
        public FormSuaHangSX()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        public static String tenhangsx = "";
        public static String mahangsx = "";
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
                String SqlUpdate = "UPDATE hangsx SET tenhangsx=@tenhangsx WHERE mahangsx=@mahangsx";
                SqlCommand cmd = new SqlCommand(SqlUpdate, con);
                cmd.Parameters.AddWithValue("tenhangsx", textBoxTenHangSX.Text);
                cmd.Parameters.AddWithValue("mahangsx", mahangsx);
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

        private void FormSuaHangSX_Load(object sender, EventArgs e)
        {
            textBoxTenHangSX.Text = tenhangsx;
        }
    }
}
