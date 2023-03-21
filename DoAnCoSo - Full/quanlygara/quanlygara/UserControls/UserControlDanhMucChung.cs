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
    public partial class UserControlDanhMucChung : UserControl
    {
        public UserControlDanhMucChung()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
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
        public void timkiemloaihang(String search)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                string sqlselect = "SELECT *FROM loaihang where maloaihang like '%"+search+ "%' or tenloaihang like N'%"+search+"%'";
                SqlCommand CMD = new SqlCommand(sqlselect, con);
                SqlDataReader read = CMD.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(read);
                dataGridView_LoaiHang.DataSource = dt;
                con.Close();
                read.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Lỗi: " + ex2.Message);
            }
        }
        //load dữ liệu mặt hàng
        public void loadmathang()
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                string sqlselect = "select mamathang,tenmathang,loaihang.tenloaihang,hangsx.tenhangsx,hinhanh,giaban,soluong,mota from mathang INNER JOIN loaihang ON mathang.maloaihang = loaihang.maloaihang INNER JOIN hangsx ON mathang.mahangsx = hangsx.mahangsx" ;
                SqlCommand CMD = new SqlCommand(sqlselect, con);
                SqlDataReader read = CMD.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(read);
                dataGridViewMatHang.DataSource = dt;
                con.Close();
                read.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Lỗi: " + ex2.Message);
            }
        }
        //load
        public void load()
        {
            HienThiDuLieu("loaihang", dataGridView_LoaiHang);
            HienThiDuLieu("hangsx", dataGridViewHangSX);
            loadmathang();
            HienThiDuLieu("nhacungcap", dataGridViewNCC);
            HienThiDuLieu("dichvu", dataGridViewDV);
            HienThiDuLieu("nhanvien", dataGridViewNV);
            HienThiDuLieu("dangnhap", dataGridViewNguoiDungHTT);
        }
        //thêm loại hàng
        private void buttonThemLoaiHang_Click(object sender, EventArgs e)
        {
            FormThemLoaiHang themLoaiHang = new FormThemLoaiHang();
            themLoaiHang.ShowDialog();
        }
        //load tất cả thông tin lên form
        private void UserControlDanhMucChung_Load(object sender, EventArgs e)
        {
            load();
        }
        public static bool checkdataChange = false;
        //kiểm tra sự thay đổi của dữ liệu khi thêm xóa sửa. Nếu có thay đổi =>> cập nhật lại UI
        private void timerCheckDataUpdate_Tick(object sender, EventArgs e)
        {
            if (checkdataChange == true)
            {
                checkdataChange = false;
                load();
            }
        }
        //xử lý sự kiện click button xóa sửa của dataGridView_LoaiHang
        private void dataGridView_LoaiHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String maloaihang = "" + dataGridView_LoaiHang.SelectedCells[0].OwningRow.Cells["maloaihang"].Value;
            String tenloaihang = "" + dataGridView_LoaiHang.SelectedCells[0].OwningRow.Cells["tenloaihang"].Value;
            //if click is on new row or header row
            if (e.RowIndex == dataGridView_LoaiHang.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            //xử lý sự kiện khi nhấn nút xóa loại hàng
            if (e.ColumnIndex == dataGridView_LoaiHang.Columns["XoaLoaiHang"].Index)
            {
                if(MessageBox.Show("Bạn có chắc chắn muốn xóa "+tenloaihang+" hay không ???","???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(chuoikn);
                        con.Open();
                        String SqlDelete = "DELETE FROM loaihang WHERE maloaihang=@maloaihang";
                        SqlCommand cmd = new SqlCommand(SqlDelete, con);
                        cmd.Parameters.AddWithValue("maloaihang", maloaihang);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        load();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            //xử lý sự kiện khi nhấn nút sửa loại hàng
            if (e.ColumnIndex == dataGridView_LoaiHang.Columns["SuaLoaiHang"].Index)
            {
                FormSuaLoaiHang.tenloaihang = tenloaihang;
                FormSuaLoaiHang.maloaihang = maloaihang;
                FormSuaLoaiHang f = new FormSuaLoaiHang();
                f.ShowDialog();
            }
        }
        //thêm hãng sản xuất
        private void buttonHangSX_Click(object sender, EventArgs e)
        {
            FormThemHangSX f = new FormThemHangSX();
            f.ShowDialog();
        }
        //xử lý sự kiện click button xóa sửa của  dataGridViewHangSX
        private void dataGridViewHangSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String mahangsx = "" + dataGridViewHangSX.SelectedCells[0].OwningRow.Cells["mahangsx"].Value;
            String tenhangsx = "" + dataGridViewHangSX.SelectedCells[0].OwningRow.Cells["tenhangsx"].Value;
            //if click is on new row or header row
            if (e.RowIndex == dataGridViewHangSX.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            //xử lý sự kiện khi nhấn nút xóa
            if (e.ColumnIndex == dataGridViewHangSX.Columns["XoaHangSX"].Index)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + tenhangsx + " hay không ???", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(chuoikn);
                        con.Open();
                        String SqlDelete = "DELETE FROM hangsx WHERE mahangsx=@mahangsx";
                        SqlCommand cmd = new SqlCommand(SqlDelete, con);
                        cmd.Parameters.AddWithValue("mahangsx", mahangsx);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        load();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            //xử lý sự kiện khi nhấn nút sửa
            if (e.ColumnIndex == dataGridViewHangSX.Columns["SuaHangSX"].Index)
            {
                FormSuaHangSX.tenhangsx = tenhangsx;
                FormSuaHangSX.mahangsx = mahangsx;
                FormSuaHangSX f = new FormSuaHangSX();
                f.ShowDialog();
            }
        }
        //Thêm mặt hàng
        private void buttonThemMatHang_Click(object sender, EventArgs e)
        {
            FormThemMatHang f = new FormThemMatHang();
            f.ShowDialog();
        }
        //xử lý xóa sửa mặt hàng
        private void dataGridViewMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String mamathang= "" + dataGridViewMatHang.SelectedCells[0].OwningRow.Cells["mamathang"].Value;
            String tenmathang = "" + dataGridViewMatHang.SelectedCells[0].OwningRow.Cells["tenmathang"].Value;
            String maloaihang= "" + dataGridViewMatHang.SelectedCells[0].OwningRow.Cells["tenloaihang_mh"].Value;
            String mahangsx= "" + dataGridViewMatHang.SelectedCells[0].OwningRow.Cells["tenhangsx_mh"].Value;
            String hinhanh= "" + dataGridViewMatHang.SelectedCells[0].OwningRow.Cells["hinhanh"].Value;
            String giaban= "" + dataGridViewMatHang.SelectedCells[0].OwningRow.Cells["giaban"].Value;
            String soluong= "" + dataGridViewMatHang.SelectedCells[0].OwningRow.Cells["soluong"].Value;
            String mota= "" + dataGridViewMatHang.SelectedCells[0].OwningRow.Cells["mota"].Value;
            //if click is on new row or header row
            if (e.RowIndex == dataGridViewMatHang.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            //xử lý sự kiện khi nhấn nút xóa
            if (e.ColumnIndex == dataGridViewMatHang.Columns["XoaMatHang"].Index)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + tenmathang + " hay không ???", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(chuoikn);
                        con.Open();
                        String SqlDelete = "DELETE FROM mathang WHERE mamathang=@mamathang";
                        SqlCommand cmd = new SqlCommand(SqlDelete, con);
                        cmd.Parameters.AddWithValue("mamathang", mamathang);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        load();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            //xử lý sự kiện khi nhấn nút sửa
            if (e.ColumnIndex == dataGridViewMatHang.Columns["SuaMatHang"].Index)
            {
                FormSuaMatHang.mamathang = mamathang;
                FormSuaMatHang.tenmathang = tenmathang;
                FormSuaMatHang.maloaihang = maloaihang;
                FormSuaMatHang.mahangsx = mahangsx;
                FormSuaMatHang.hinhanh = hinhanh;
                FormSuaMatHang.giaban = giaban;
                FormSuaMatHang.soluong = soluong;
                FormSuaMatHang.mota = mota;
                FormSuaMatHang f = new FormSuaMatHang();
                f.ShowDialog();
            }
        }

        private void buttonThemNCC_Click(object sender, EventArgs e)
        {
            FormThemNCC f = new FormThemNCC();
            f.ShowDialog();
        }

        private void dataGridViewNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String manhacc = "" + dataGridViewNCC.SelectedCells[0].OwningRow.Cells["manhacc"].Value;
            String tennhacc = "" + dataGridViewNCC.SelectedCells[0].OwningRow.Cells["tennhacc"].Value;
            String sdtncc = "" + dataGridViewNCC.SelectedCells[0].OwningRow.Cells["sdtncc"].Value;
            String diachincc = "" + dataGridViewNCC.SelectedCells[0].OwningRow.Cells["diachincc"].Value;
            String emailncc = "" + dataGridViewNCC.SelectedCells[0].OwningRow.Cells["emailncc"].Value;
            //if click is on new row or header row
            if (e.RowIndex == dataGridViewNCC.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            //xử lý sự kiện khi nhấn nút xóa
            if (e.ColumnIndex == dataGridViewNCC.Columns["XoaNCC"].Index)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + tennhacc + " hay không ???", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(chuoikn);
                        con.Open();
                        String SqlDelete = "DELETE FROM nhacungcap WHERE manhacc=@manhacc";
                        SqlCommand cmd = new SqlCommand(SqlDelete, con);
                        cmd.Parameters.AddWithValue("manhacc", manhacc);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        load();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            //xử lý sự kiện khi nhấn nút sửa
            if (e.ColumnIndex == dataGridViewNCC.Columns["SuaNCC"].Index)
            {
                FormSuaNCC.manhacc = manhacc;
                FormSuaNCC.tennhacc = tennhacc;
                FormSuaNCC.sdtncc = sdtncc;
                FormSuaNCC.diachincc = diachincc;
                FormSuaNCC.emailncc = emailncc;
                FormSuaNCC f = new FormSuaNCC();
                f.ShowDialog();
            }
        }

        private void buttonThemDV_Click(object sender, EventArgs e)
        {
            FormThemDichVU f = new FormThemDichVU();
            f.ShowDialog();
        }

        private void dataGridViewDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String madichvu= "" + dataGridViewDV.SelectedCells[0].OwningRow.Cells["madichvu"].Value;
            String tendichvu = "" + dataGridViewDV.SelectedCells[0].OwningRow.Cells["tendichvu"].Value;
            String giadichvu = "" + dataGridViewDV.SelectedCells[0].OwningRow.Cells["giadichvu"].Value;
            //if click is on new row or header row
            if (e.RowIndex == dataGridViewDV.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            //xử lý sự kiện khi nhấn nút xóa
            if (e.ColumnIndex == dataGridViewDV.Columns["XoaDV"].Index)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + tendichvu + " hay không ???", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(chuoikn);
                        con.Open();
                        String SqlDelete = "DELETE FROM dichvu WHERE madichvu=@madichvu";
                        SqlCommand cmd = new SqlCommand(SqlDelete, con);
                        cmd.Parameters.AddWithValue("madichvu", madichvu);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        load();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            //xử lý sự kiện khi nhấn nút sửa
            if (e.ColumnIndex == dataGridViewDV.Columns["SuaDV"].Index)
            {
                FormSuaDichVu.madichvu = madichvu;
                FormSuaDichVu.tendichvu = tendichvu;
                FormSuaDichVu.giadichvu = giadichvu;
                FormSuaDichVu f = new FormSuaDichVu();
                f.ShowDialog();
            }
        }
        //Thêm nhân viên
        private void buttonThemNhanVien_Click(object sender, EventArgs e)
        {
            FormThemNhanVien f = new FormThemNhanVien();
            f.ShowDialog();
        }

        private void dataGridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String manv = "" + dataGridViewNV.SelectedCells[0].OwningRow.Cells["manv"].Value;
            String hotennv = "" + dataGridViewNV.SelectedCells[0].OwningRow.Cells["hotennv"].Value;
            String cccd = "" + dataGridViewNV.SelectedCells[0].OwningRow.Cells["cccd"].Value;
            String ngaysinh = "" + dataGridViewNV.SelectedCells[0].OwningRow.Cells["ngaysinh"].Value;
            String gioitinh = "" + dataGridViewNV.SelectedCells[0].OwningRow.Cells["gioitinh"].Value;
            String email = "" + dataGridViewNV.SelectedCells[0].OwningRow.Cells["email"].Value;
            String sdt = "" + dataGridViewNV.SelectedCells[0].OwningRow.Cells["sdt"].Value;
            String diachi = "" + dataGridViewNV.SelectedCells[0].OwningRow.Cells["diachi"].Value;
            //if click is on new row or header row
            if (e.RowIndex == dataGridViewNV.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            //xử lý sự kiện khi nhấn nút xóa
            if (e.ColumnIndex == dataGridViewNV.Columns["XoaNV"].Index)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + hotennv + " hay không ???", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(chuoikn);
                        con.Open();
                        String SqlDelete = "DELETE FROM nhanvien WHERE manv=@manv";
                        SqlCommand cmd = new SqlCommand(SqlDelete, con);
                        cmd.Parameters.AddWithValue("manv", manv);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        load();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            //xử lý sự kiện khi nhấn nút sửa
            if (e.ColumnIndex == dataGridViewNV.Columns["SuaNV"].Index)
            {
                FormSuaNhanVien.manv = manv;
                FormSuaNhanVien.hotennv = hotennv;
                FormSuaNhanVien.cccd = cccd;
                FormSuaNhanVien.ngaysinh = ngaysinh;
                FormSuaNhanVien.gioitinh = gioitinh;
                FormSuaNhanVien.sdt = sdt;
                FormSuaNhanVien.email = email;
                FormSuaNhanVien.diachi = diachi;
                FormSuaNhanVien f = new FormSuaNhanVien();
                f.ShowDialog();
            }
        }

        private void dataGridViewNguoiDungHTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String tendangnhap = "" + dataGridViewNguoiDungHTT.SelectedCells[0].OwningRow.Cells["tendangnhap"].Value;
            String matkhau = "" + dataGridViewNguoiDungHTT.SelectedCells[0].OwningRow.Cells["matkhau"].Value;
            String quyen = "" + dataGridViewNguoiDungHTT.SelectedCells[0].OwningRow.Cells["quyen"].Value;
            String active = "" + dataGridViewNguoiDungHTT.SelectedCells[0].OwningRow.Cells["active"].Value;
            //if click is on new row or header row
            if (e.RowIndex == dataGridViewNguoiDungHTT.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            //xử lý sự kiện khi nhấn nút sửa
            if (e.ColumnIndex == dataGridViewNguoiDungHTT.Columns["SuaDN"].Index)
            {
                FormSuaPhanQuyen.tendangnhap = tendangnhap;
                FormSuaPhanQuyen.matkhau = matkhau;
                FormSuaPhanQuyen.quyen = quyen;
                FormSuaPhanQuyen.active = active;
                FormSuaPhanQuyen f = new FormSuaPhanQuyen();
                f.ShowDialog();
            }
        }

        private void button_TKTheLoai_Click(object sender, EventArgs e)
        {
            timkiemloaihang(textBox_TKLoaiHang.Text);
        }

        private void textBox_TKLoaiHang_TextChanged(object sender, EventArgs e)
        {
            button_TKTheLoai.PerformClick();
        }
        public void timkiemhsx(String search)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                string sqlselect = "SELECT *FROM hangsx where mahangsx like '%" + search + "%' or tenhangsx like N'%" + search + "%'";
                SqlCommand CMD = new SqlCommand(sqlselect, con);
                SqlDataReader read = CMD.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(read);
                dataGridViewHangSX.DataSource = dt;
                con.Close();
                read.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Lỗi: " + ex2.Message);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            timkiemhsx(textBoxhsxxxx.Text);
        }

        private void textBoxhsxxxx_TextChanged(object sender, EventArgs e)
        {
            button5.PerformClick();
        }
        public void timkiemhmathang(String search)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                string sqlselect = "SELECT *FROM mathang where mamathang like '%" + search + "%' or tenmathang like N'%" + search + "%'";
                SqlCommand CMD = new SqlCommand(sqlselect, con);
                SqlDataReader read = CMD.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(read);
                dataGridViewMatHang.DataSource = dt;
                con.Close();
                read.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Lỗi: " + ex2.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timkiemhmathang(textBoxTkmathanggg.Text);
        }

        private void textBoxTkmathanggg_TextChanged(object sender, EventArgs e)
        {
            button6.PerformClick();
        }
        public void tknhacungcap(String search)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                string sqlselect = "SELECT *FROM nhacungcap where manhacc like '%" + search + "%' or tennhacc like N'%" + search + "%'";
                SqlCommand CMD = new SqlCommand(sqlselect, con);
                SqlDataReader read = CMD.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(read);
                dataGridViewNCC.DataSource = dt;
                con.Close();
                read.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Lỗi: " + ex2.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tknhacungcap(textBoxnccc.Text);
        }

        private void textBoxnccc_TextChanged(object sender, EventArgs e)
        {
            button7.PerformClick();
        }
        public void tkdichvu(String search)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                string sqlselect = "SELECT *FROM dichvu where madichvu like '%" + search + "%' or tendichvu like N'%" + search + "%'";
                SqlCommand CMD = new SqlCommand(sqlselect, con);
                SqlDataReader read = CMD.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(read);
                dataGridViewDV.DataSource = dt;
                con.Close();
                read.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Lỗi: " + ex2.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tkdichvu(textBoxTKdv.Text);
        }

        private void textBoxTKdv_TextChanged(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
        public void tknhanvien(String search)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                string sqlselect = "SELECT *FROM nhanvien where manv like '%" + search + "%' or hotennv like N'%" + search + "%'";
                SqlCommand CMD = new SqlCommand(sqlselect, con);
                SqlDataReader read = CMD.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(read);
                dataGridViewNV.DataSource = dt;
                con.Close();
                read.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Lỗi: " + ex2.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tknhanvien(textBoxtknv.Text);
        }

        private void textBoxtknv_TextChanged(object sender, EventArgs e)
        {
            button3.PerformClick();
        }
        public void tknguoidung(String search)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                string sqlselect = "SELECT *FROM dangnhap where tendangnhap like '%" + search + "%'";
                SqlCommand CMD = new SqlCommand(sqlselect, con);
                SqlDataReader read = CMD.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(read);
                dataGridViewNguoiDungHTT.DataSource = dt;
                con.Close();
                read.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Lỗi: " + ex2.Message);
            }
        }
        private void textBoxnguoidunggg_TextChanged(object sender, EventArgs e)
        {
            button4.PerformClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tknguoidung(textBoxnguoidunggg.Text);
        }
    }
}
