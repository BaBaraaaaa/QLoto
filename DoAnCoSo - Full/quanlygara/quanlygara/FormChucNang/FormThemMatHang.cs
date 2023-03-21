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
    public partial class FormThemMatHang : Form
    {
        public FormThemMatHang()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        //load combobox 
        public void loadcombobox(string TenBangSQL, String ValueMenber, String DisplayMenber, ComboBox data)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                string sqlselect = "SELECT *FROM " + TenBangSQL;
                SqlCommand CMD = new SqlCommand(sqlselect, con);
                SqlDataReader read = CMD.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(read);
                data.DataSource = dt;
                data.ValueMember = ValueMenber;
                data.DisplayMember = DisplayMenber;
                con.Close();
                read.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Lỗi: " + ex2.Message);
            }
        }
        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormThemMatHang_Load(object sender, EventArgs e)
        {
            loadcombobox("loaihang", "maloaihang", "tenloaihang", comboBoxLoaiHang);
            loadcombobox("hangsx", "mahangsx", "tenhangsx", comboBoxHangSX);
        }
        //chọn ảnh
        String pathFile = "";
        private void buttonChonAnh_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBoxAnh.Image = new Bitmap(open.FileName);
                // image file path 
                pathFile= open.FileName;
            }
        }
        //thêm mặt hàng
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SqlInsert = "INSERT INTO mathang VALUES(@tenmathang, @maloaihang,@mahangsx,@hinhanh,@giaban,@soluong,@mota)";
                SqlCommand cmd = new SqlCommand(SqlInsert, con);
                cmd.Parameters.AddWithValue("tenmathang", textBoxTenMatHang.Text);
                cmd.Parameters.AddWithValue("maloaihang", comboBoxLoaiHang.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("mahangsx", comboBoxHangSX.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("hinhanh",pathFile);
                cmd.Parameters.AddWithValue("giaban", numericUpDownGiaBan.Value.ToString());
                cmd.Parameters.AddWithValue("soluong", numericUpDownSoLuong.Value.ToString());
                cmd.Parameters.AddWithValue("mota", richTextBoxMoTa.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                UserControlDanhMucChung.checkdataChange = true;
                UserControlQuanLyKho.check = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm mặt hàng: " + ex.ToString());
            }
        }
    }
}
