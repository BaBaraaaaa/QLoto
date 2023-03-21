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
    public partial class FormSuaDichVu : Form
    {
        public FormSuaDichVu()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        public static String madichvu, tendichvu, giadichvu;

        private void FormSuaDichVu_Load(object sender, EventArgs e)
        {
            textBoxTenDV.Text = tendichvu;
            numericUpDownGia.Value = Convert.ToInt32(giadichvu);
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SqlUpdate = "UPDATE dichvu SET tendichvu=@tendichvu, giadichvu=@giadichvu WHERE madichvu=@madichvu";
                SqlCommand cmd = new SqlCommand(SqlUpdate, con);
                cmd.Parameters.AddWithValue("tendichvu", textBoxTenDV.Text);
                cmd.Parameters.AddWithValue("giadichvu", numericUpDownGia.Value);
                cmd.Parameters.AddWithValue("madichvu", madichvu);
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
    }
}
