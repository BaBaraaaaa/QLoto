using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanlygara.FormChucNang;
using System.Data.SqlClient;

namespace quanlygara.UserControls
{
    public partial class UserControlSuaChua : UserControl
    {
        public UserControlSuaChua()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        public void HienThiDuLieu02(DataGridView data)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SQL = "select mahoadon,biensoxe,tenkhachhang,hoadon.sdt,nhanvien.hotennv,ngaylaphd,dbo.tongtienHoaDOn(mahoadon) as tongthanhtien,ghichu from hoadon INNER JOIN nhanvien ON hoadon.manv=nhanvien.manv";
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
        private void buttonThemSP_Click(object sender, EventArgs e)
        {
            FormHoaDonSuaChua f = new FormHoaDonSuaChua();
            f.ShowDialog();
        }

        private void UserControlSuaChua_Load(object sender, EventArgs e)
        {
            HienThiDuLieu02(dataGridViewHoaDon);
        }
        public static bool check;
        private void timerCheck_Tick(object sender, EventArgs e)
        {
            if (check == true)
            {
                check = false;
                HienThiDuLieu02(dataGridViewHoaDon);
            }
        }

        private void dataGridViewHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String mahoadon = "" + dataGridViewHoaDon.SelectedCells[0].OwningRow.Cells["mahoadon"].Value;
            String tenkhachhang = "" + dataGridViewHoaDon.SelectedCells[0].OwningRow.Cells["tenkhachhang"].Value;
            String sdt = "" + dataGridViewHoaDon.SelectedCells[0].OwningRow.Cells["sdt"].Value;
            String hotennv = "" + dataGridViewHoaDon.SelectedCells[0].OwningRow.Cells["hotennv"].Value;
            String ngaylaphd = "" + dataGridViewHoaDon.SelectedCells[0].OwningRow.Cells["ngaylaphd"].Value;
            String tongthanhtien = "" + dataGridViewHoaDon.SelectedCells[0].OwningRow.Cells["tongthanhtien"].Value;
            String biensoxe = "" + dataGridViewHoaDon.SelectedCells[0].OwningRow.Cells["biensoxe"].Value;
            String ghichu = "" + dataGridViewHoaDon.SelectedCells[0].OwningRow.Cells["ghichu"].Value;
            //if click is on new row or header row
            if (e.RowIndex == dataGridViewHoaDon.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            //xử lý sự kiện khi nhấn nút xóa 
            if (e.ColumnIndex == dataGridViewHoaDon.Columns["XoaHD"].Index)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn " + mahoadon + " hay không ???", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(chuoikn);
                        con.Open();
                        String SqlDelete = "DELETE FROM hoadon WHERE mahoadon=@mahoadon";
                        SqlCommand cmd = new SqlCommand(SqlDelete, con);
                        cmd.Parameters.AddWithValue("mahoadon", mahoadon);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        HienThiDuLieu02(dataGridViewHoaDon);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            //xử lý sự kiện khi nhấn nút sửa loại hàng
            if (e.ColumnIndex == dataGridViewHoaDon.Columns["XemChiTietNhap"].Index)
            {
                FormXemChiTietHDSuaChua.mahoadon=mahoadon;
                FormXemChiTietHDSuaChua.biensoxe = biensoxe;
                FormXemChiTietHDSuaChua.tenkh = tenkhachhang;
                FormXemChiTietHDSuaChua.sdt = sdt;
                FormXemChiTietHDSuaChua.ngaylap = ngaylaphd;
                FormXemChiTietHDSuaChua.nvlap = hotennv;
                FormXemChiTietHDSuaChua.ghichu = ghichu;
                FormXemChiTietHDSuaChua.tongthanhtien = tongthanhtien;
                FormXemChiTietHDSuaChua f = new FormXemChiTietHDSuaChua();
                f.ShowDialog();
            }
        }
        public void HienThiDuLieu02bysearch(DataGridView data,String search)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SQL = "select mahoadon,biensoxe,tenkhachhang,hoadon.sdt,nhanvien.hotennv,ngaylaphd,dbo.tongtienHoaDOn(mahoadon) as tongthanhtien,ghichu from hoadon INNER JOIN nhanvien ON hoadon.manv=nhanvien.manv where tenkhachhang like N'%" + search+"%'";
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
        private void textBox_TKsuachua_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_TKsuachuaaaa_Click(object sender, EventArgs e)
        {
            HienThiDuLieu02bysearch(dataGridViewHoaDon, textBox_TKsuachua.Text);
        }
    }
}
