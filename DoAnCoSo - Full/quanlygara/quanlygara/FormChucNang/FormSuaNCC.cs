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
    public partial class FormSuaNCC : Form
    {
        public FormSuaNCC()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        public static String manhacc, tennhacc, sdtncc, diachincc, emailncc;

        private void FormSuaNCC_Load(object sender, EventArgs e)
        {
            textBoxTenNCC.Text = tennhacc;
            textBoxSDT.Text = sdtncc;
            textBoxDiaChi.Text = diachincc;
            textBoxEmail.Text = emailncc;
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
                String SqlUpdate = "UPDATE nhacungcap SET tennhacc=@tennhacc, sdtncc=@sdtncc, diachincc=@diachincc, emailncc=@emailncc WHERE manhacc=@manhacc";
                SqlCommand cmd = new SqlCommand(SqlUpdate, con);
                cmd.Parameters.AddWithValue("tennhacc", textBoxTenNCC.Text);
                cmd.Parameters.AddWithValue("sdtncc", textBoxSDT.Text);
                cmd.Parameters.AddWithValue("diachincc", textBoxDiaChi.Text);
                cmd.Parameters.AddWithValue("emailncc", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("manhacc", manhacc);
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
