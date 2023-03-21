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
    public partial class FormSuaMatHang : Form
    {
        public FormSuaMatHang()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        public static String mamathang = "";
        public static String tenmathang, maloaihang, mahangsx, hinhanh, giaban,soluong, mota;

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SqlUpdate = "UPDATE mathang SET tenmathang=@tenmathang, maloaihang=@maloaihang, mahangsx=@mahangsx, hinhanh=@hinhanh, giaban=@giaban, soluong=@soluong, mota=@mota WHERE mamathang=@mamathang";
                SqlCommand cmd = new SqlCommand(SqlUpdate, con);
                cmd.Parameters.AddWithValue("tenmathang", textBoxTenMatHang.Text);
                cmd.Parameters.AddWithValue("maloaihang", comboBoxLoaiHang.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("mahangsx", comboBoxHangSX.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("hinhanh", pathFile);
                cmd.Parameters.AddWithValue("giaban", numericUpDownGiaBan.Value.ToString());
                cmd.Parameters.AddWithValue("soluong", numericUpDownSoLuong.Value.ToString());
                cmd.Parameters.AddWithValue("mota", richTextBoxMoTa.Text);
                cmd.Parameters.AddWithValue("mamathang", mamathang);
                cmd.ExecuteNonQuery();
                con.Close();
                UserControlDanhMucChung.checkdataChange = true;
                UserControlQuanLyKho.check = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa đổi dữ liệu thất bại ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
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
                pathFile = open.FileName;
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
        private void FormSuaMatHang_Load(object sender, EventArgs e)
        {
            pathFile = hinhanh;
            try
            {
                loadcombobox("loaihang", "maloaihang", "tenloaihang", comboBoxLoaiHang);
                loadcombobox("hangsx", "mahangsx", "tenhangsx", comboBoxHangSX);
                textBoxTenMatHang.Text = tenmathang;
                pictureBoxAnh.Image = new Bitmap(hinhanh);
                numericUpDownGiaBan.Value = Convert.ToInt32(giaban);
                numericUpDownSoLuong.Value = Convert.ToInt32(soluong);
                richTextBoxMoTa.Text = mota;
                comboBoxLoaiHang.Text = maloaihang;
                comboBoxHangSX.Text = mahangsx;
            }
            catch(Exception ex)
            {
                loadcombobox("loaihang", "maloaihang", "tenloaihang", comboBoxLoaiHang);
                loadcombobox("hangsx", "mahangsx", "tenhangsx", comboBoxHangSX);
                textBoxTenMatHang.Text = tenmathang;
                numericUpDownGiaBan.Value = Convert.ToInt32(giaban);
                numericUpDownSoLuong.Value = Convert.ToInt32(soluong);
                richTextBoxMoTa.Text = mota;
                comboBoxLoaiHang.Text = maloaihang;
                comboBoxHangSX.Text = mahangsx;
            }
        }
    }
}
