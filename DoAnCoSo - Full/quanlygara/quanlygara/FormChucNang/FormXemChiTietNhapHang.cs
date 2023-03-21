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
    public partial class FormXemChiTietNhapHang : Form
    {
        public FormXemChiTietNhapHang()
        {
            InitializeComponent();
        }
        public static String manhaphang;
        String chuoikn = ClassConnection.ConnectionString;
        public String getIdNhaCungCap(String manhaphang)
        {
            try
            {
                String SQL = "select manhacc from nhaphang where manhaphang='"+ manhaphang + "'";
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                String kq = cmd.ExecuteScalar().ToString();
                con.Close();
                return kq;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.ToString());
                return "";
            }
        }
        public String getTenNhaCungCap(String id)
        {
            try
            {
                String SQL = "select tennhacc from nhacungcap where manhacc='" + id + "'";
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                String kq = cmd.ExecuteScalar().ToString();
                con.Close();
                return kq;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.ToString());
                return "";
            }
        }
        public String getIdNhanVien(String manhaphang)
        {
            try
            {
                String SQL = "select manv from nhaphang where manhaphang='" + manhaphang + "'";
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                String kq = cmd.ExecuteScalar().ToString();
                con.Close();
                return kq;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.ToString());
                return "";
            }
        }
        public String getTenNhanVien(String id)
        {
            try
            {
                String SQL = "select hotennv from nhanvien where manv='" + id + "'";
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                String kq = cmd.ExecuteScalar().ToString();
                con.Close();
                return kq;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.ToString());
                return "";
            }
        }
        public String getNgayNhapHang(String manhaphang)
        {
            try
            {
                String SQL = "select ngaynhaphang from nhaphang where manhaphang='" + manhaphang + "'";
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                String kq = cmd.ExecuteScalar().ToString();
                con.Close();
                return kq;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.ToString());
                return "";
            }
        }
        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void HienThiDuLieu02(DataGridView data, String manhaphang)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SQL = "select chitietnhaphang.mamathang, mathang.tenmathang,chitietnhaphang.soluong, dongianhap, (chitietnhaphang.soluong*dongianhap) as thanhtien from chitietnhaphang INNER JOIN mathang ON chitietnhaphang.mamathang=mathang.mamathang where manhaphang='"+manhaphang+"'";
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
        private void FormXemChiTietNhapHang_Load(object sender, EventArgs e)
        {
            String mancc = getIdNhaCungCap(manhaphang);
            String manv = getIdNhanVien(manhaphang);
            String ngaynhaphang = getNgayNhapHang(manhaphang);
            String TenNV = getTenNhanVien(manv);
            String TenNCC = getTenNhaCungCap(mancc);
            textBoxHoTenNV.Text = TenNV;
            textBoxNgayNhapHang.Text = ngaynhaphang;
            textBoxNCC.Text = TenNCC;
            HienThiDuLieu02(dataGridViewHoaDOn, manhaphang);
        }
    }
}
