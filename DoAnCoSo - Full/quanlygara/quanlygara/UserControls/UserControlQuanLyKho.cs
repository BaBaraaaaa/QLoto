using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using quanlygara.FormChucNang;

namespace quanlygara.UserControls
{
    public partial class UserControlQuanLyKho : UserControl
    {
        public UserControlQuanLyKho()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        public static bool check;
        public void loadAllProDuct()
        {
            SqlConnection con = new SqlConnection(chuoikn);
            con.Open();
            string sqlselect = "SELECT *FROM mathang";
            SqlCommand CMD = new SqlCommand(sqlselect, con);
            SqlDataReader read = CMD.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(read);
            con.Close();
            read.Close();
            foreach (DataRow item in dt.Rows)
            {
                CardProduct product = new CardProduct();
                product.Tensp = item["tenmathang"].ToString();
                product.Hinhanh= item["hinhanh"].ToString();
                product.Soluong =item["soluong"].ToString();
                product.Gia =item["giaban"].ToString();
                product.MaSP1= item["mamathang"].ToString();
                product.Maloaihang = item["maloaihang"].ToString();
                product.Mahangsx = item["mahangsx"].ToString();
                product.Mota = item["mota"].ToString();
                flowLayoutPanelChuaSP.Controls.Add(product);
            }
        }
        public void HienThiDuLieu02(DataGridView data)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SQL = "select manhaphang, nhacungcap.tennhacc,nhanvien.hotennv,ngaynhaphang,dbo.tongtienNhapHang(manhaphang) as tongthanhtien from nhaphang INNER JOIN nhacungcap ON nhaphang.manhacc=nhacungcap.manhacc INNER JOIN nhanvien ON nhaphang.manv=nhanvien.manv";
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
        private void UserControlQuanLyKho_Load(object sender, EventArgs e)
        {
            loadAllProDuct();
            HienThiDuLieu02(dataGridViewMatHang);
        }

        private void buttonThemSP_Click(object sender, EventArgs e)
        {
            FormThemMatHang f = new FormThemMatHang();
            f.ShowDialog();
        }
        //Hàm hiển thị dữ liệu lên datagidview
        public void HienThiDuLieu(string TenBangSQL, DataGridView data)
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
                con.Close();
                read.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Lỗi: " + ex2.Message);
            }
        }
        private void timerCheckChange_Tick(object sender, EventArgs e)
        {
            if (check == true)
            {
                check = false;
                flowLayoutPanelChuaSP.Controls.Clear();
                loadAllProDuct();
                HienThiDuLieu02(dataGridViewMatHang);
            }
        }

        private void buttonLapHoaDonNhapHang_Click(object sender, EventArgs e)
        {
            FormHoaDonNhapHang f = new FormHoaDonNhapHang();
            f.ShowDialog();
        }

        private void dataGridViewMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String manhaphang = "" + dataGridViewMatHang.SelectedCells[0].OwningRow.Cells["manhaphang"].Value;
            //if click is on new row or header row
            if (e.RowIndex == dataGridViewMatHang.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            //xử lý sự kiện khi nhấn nút xóa 
            if (e.ColumnIndex == dataGridViewMatHang.Columns["XoaHDNhap"].Index)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + manhaphang + " hay không ???", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(chuoikn);
                        con.Open();
                        String SqlDelete = "DELETE FROM nhaphang WHERE manhaphang=@manhaphang";
                        SqlCommand cmd = new SqlCommand(SqlDelete, con);
                        cmd.Parameters.AddWithValue("manhaphang", manhaphang);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        HienThiDuLieu02(dataGridViewMatHang);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            //xử lý sự kiện khi nhấn nút sửa loại hàng
            if (e.ColumnIndex == dataGridViewMatHang.Columns["XemChiTietNhap"].Index)
            {
                FormXemChiTietNhapHang.manhaphang = manhaphang;
                FormXemChiTietNhapHang f = new FormXemChiTietNhapHang();
                f.ShowDialog();
            }
        }
        public void loadAllProDuctBySearch(String search)
        {
            SqlConnection con = new SqlConnection(chuoikn);
            con.Open();
            string sqlselect = "SELECT *FROM mathang where tenmathang like N'%"+search+"%'";
            SqlCommand CMD = new SqlCommand(sqlselect, con);
            SqlDataReader read = CMD.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(read);
            con.Close();
            read.Close();
            foreach (DataRow item in dt.Rows)
            {
                CardProduct product = new CardProduct();
                product.Tensp = item["tenmathang"].ToString();
                product.Hinhanh = item["hinhanh"].ToString();
                product.Soluong = item["soluong"].ToString();
                product.Gia = item["giaban"].ToString();
                product.MaSP1 = item["mamathang"].ToString();
                product.Maloaihang = item["maloaihang"].ToString();
                product.Mahangsx = item["mahangsx"].ToString();
                product.Mota = item["mota"].ToString();
                flowLayoutPanelChuaSP.Controls.Add(product);
            }
        }
        private void button_TKsp_Click(object sender, EventArgs e)
        {
            flowLayoutPanelChuaSP.Controls.Clear();
            loadAllProDuctBySearch(textBox_TKspppp.Text);

        }

        private void textBox_TKspppp_TextChanged(object sender, EventArgs e)
        {
            button_TKsp.PerformClick();
        }
    }
}
