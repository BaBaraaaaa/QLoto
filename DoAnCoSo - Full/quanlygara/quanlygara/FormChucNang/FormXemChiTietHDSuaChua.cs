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
    public partial class FormXemChiTietHDSuaChua : Form
    {
        public FormXemChiTietHDSuaChua()
        {
            InitializeComponent();
        }
        public static String mahoadon;
        public static String tenkh;
        public static String sdt;
        public static String ngaylap;
        public static String nvlap;
        public static String tongthanhtien;
        public static String biensoxe;
        public static String ghichu;
        String chuoikn = ClassConnection.ConnectionString;
        public void HienThiDuLieu02(DataGridView data, String mahd)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SQL = "select chitiethdMatHang.mamathang,mathang.tenmathang,chitiethdMatHang.soluong,chitiethdMatHang.giamathang,chitiethdMatHang.soluong*chitiethdMatHang.giamathang as tongthanhtien from chitiethdMatHang INNER JOIN mathang ON chitiethdMatHang.mamathang = mathang.mamathang where mahoadon='" + mahd+"'";
                SqlCommand CMD = new SqlCommand(SQL, con);
                SqlDataReader read = CMD.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(read);
                data.DataSource = dt;
                con.Close();
                read.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Lỗi: " + ex2.Message);
            }
        }
        public void HienThiDuLieu03(DataGridView data, String mahd)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SQL = "select chitiethdDichVu.madichvu,dichvu.tendichvu,chitiethdDichVu.giadichvu from chitiethdDichVu INNER JOIN dichvu ON chitiethdDichVu.madichvu=dichvu.madichvu where mahoadon='" + mahd + "'";
                SqlCommand CMD = new SqlCommand(SQL, con);
                SqlDataReader read = CMD.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(read);
                data.DataSource = dt;
                con.Close();
                read.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Lỗi: " + ex2.Message);
            }
        }
        private void FormXemChiTietHDSuaChua_Load(object sender, EventArgs e)
        {
            textBoxHoTenKH.Text = tenkh;
            textBoxbiensoxe.Text = biensoxe;
            textBoxghichu.Text = ghichu;
            textBoxSDT.Text = sdt;
            textBoxNgayLapHD.Text = ngaylap;
            textBoxHoTenNV.Text = nvlap;
            textBoxThanhTien.Text = tongthanhtien;
            HienThiDuLieu02(dataGridViewMatHang, mahoadon);
            HienThiDuLieu03(dataGridViewDichVu, mahoadon);
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBoxghichu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
