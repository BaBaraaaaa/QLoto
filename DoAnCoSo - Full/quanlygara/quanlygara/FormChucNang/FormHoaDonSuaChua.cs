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
    public partial class FormHoaDonSuaChua : Form
    {
        public FormHoaDonSuaChua()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
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
        private void FormHoaDonSuaChua_Load(object sender, EventArgs e)
        {
            loadcombobox("dichvu", "madichvu", "tendichvu",comboBoxDichVu);
            loadcombobox("mathang", "mamathang", "tenmathang", comboBoxMatHang);
            textBoxHoTenNV.Text = Form1.manv + "-" + getTenNhanVien(Form1.manv);
            dateTimePickerNgayLapHD.Value = Convert.ToDateTime(DateTime.Now.ToString());
        }
        List<DichVu> ListdichVus = new List<DichVu>();
        public String getGiaDichVu(String madichvu)
        {
            try
            {
                String SQL = "select giadichvu from dichvu where madichvu='" + madichvu + "'";
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
        public String getGiaHangHoa(String mamathang)
        {
            try
            {
                String SQL = "select giaban from mathang where mamathang='" + mamathang + "'";
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
        private void buttonThemDichVu_Click(object sender, EventArgs e)
        {
            String madichvu = comboBoxDichVu.SelectedValue.ToString();
            String tendichvu = comboBoxDichVu.Text;
            double giadichvu = Convert.ToDouble(getGiaDichVu(madichvu));
            if (ListdichVus.Count != 0) {
                for (int i = 0; i < ListdichVus.Count; i++)
                {
                    if (ListdichVus[i].Madichvu.Equals(madichvu))
                    {
                        MessageBox.Show("Đã thêm dịch vụ này rồi, vui lòng chọn dịch vụ khác !!!");
                        return;
                    }
                }
                DichVu dichVu = new DichVu(madichvu, tendichvu, giadichvu);
                ListdichVus.Add(dichVu);
            }
            else
            {
                DichVu dichVu = new DichVu(madichvu, tendichvu, giadichvu);
                ListdichVus.Add(dichVu);
            }
            dataGridViewDichVu.DataSource = null;
            dataGridViewDichVu.DataSource = ListdichVus;
            textBoxThanhTien.Text = tinhtongtien().ToString();
        }

        private void dataGridViewDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String madichvu = "" + dataGridViewDichVu.SelectedCells[0].OwningRow.Cells["madichvu"].Value;
            //if click is on new row or header row
            if (e.RowIndex == dataGridViewDichVu.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            if (e.ColumnIndex == dataGridViewDichVu.Columns["XoaDichVu"].Index)
            {
                for (int i = 0; i < ListdichVus.Count; i++)
                {
                    if (ListdichVus[i].Madichvu.Equals(madichvu))
                    {
                        ListdichVus.RemoveAt(i);
                        dataGridViewDichVu.DataSource = null;
                        dataGridViewDichVu.DataSource = ListdichVus;
                    }
                }
                textBoxThanhTien.Text = tinhtongtien().ToString();
            }
        }
        List<HoaDon> hd = new List<HoaDon>();
        private void buttonThemMH_Click(object sender, EventArgs e)
        {
            String mamh = comboBoxMatHang.SelectedValue.ToString();
            String tenmh = comboBoxMatHang.Text;
            int soluong = Convert.ToInt32(numericUpDownSoLuongMH.Value);
            double dongianhap = Convert.ToDouble(getGiaHangHoa(mamh));
            double thanhtien = soluong * dongianhap;
            if (hd.Count != 0)
            {
                for (int i = 0; i < hd.Count; i++)
                {
                    if (hd[i].Mamathang.Equals(mamh))
                    {
                        hd[i].Soluong += soluong;
                        hd[i].Dongianhap = dongianhap;
                        hd[i].Thanhtien = hd[i].Soluong * hd[i].Dongianhap;
                        dataGridViewMatHang.DataSource = null;
                        dataGridViewMatHang.DataSource = hd;
                        return;
                    }
                }
                HoaDon hoaDon = new HoaDon(mamh, tenmh, dongianhap, soluong, thanhtien);
                hd.Add(hoaDon);
                dataGridViewMatHang.DataSource = null;
                dataGridViewMatHang.DataSource = hd;
            }
            else
            {
                HoaDon hoaDon = new HoaDon(mamh, tenmh, dongianhap, soluong, thanhtien);
                hd.Add(hoaDon);
                dataGridViewMatHang.DataSource = null;
                dataGridViewMatHang.DataSource = hd;
            }
            textBoxThanhTien.Text = tinhtongtien().ToString();
        }

        private void dataGridViewMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String mamathang = "" + dataGridViewMatHang.SelectedCells[0].OwningRow.Cells["mamathang"].Value;
            //if click is on new row or header row
            if (e.RowIndex == dataGridViewMatHang.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            if (e.ColumnIndex == dataGridViewMatHang.Columns["xoaMh"].Index)
            {
                for (int i = 0; i < hd.Count; i++)
                {
                    if (hd[i].Mamathang.Equals(mamathang))
                    {
                        hd.RemoveAt(i);
                        dataGridViewMatHang.DataSource = null;
                        dataGridViewMatHang.DataSource = hd;
                    }
                }
                textBoxThanhTien.Text = tinhtongtien().ToString();
            }
        }
        public double tinhtongtien()
        {
            double tong = 0;
            for (int i = 0; i < ListdichVus.Count; i++)
            {
                String madichvu = ListdichVus[i].Madichvu;
                double giadichvu = Convert.ToDouble(getGiaDichVu(madichvu));
                tong += giadichvu;
            }
            for (int i = 0; i < hd.Count; i++)
            {
                String mamh = hd[i].Mamathang;
                int soluong = hd[i].Soluong;
                double dongianhap = Convert.ToDouble(getGiaHangHoa(mamh));
                double thanhtien = soluong * dongianhap;
                tong += thanhtien;
            }
            return tong;
        }
        public String getTenNhanVien(String manv)
        {
            try
            {
                String SQL = "select hotennv from nhanvien where manv='" + manv + "'";
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                string kq =(string) cmd.ExecuteScalar();
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
        public String getMaHoaDonMoiNhat()
        {
            try
            {
                String SQL = "select max(mahoadon) from hoadon";
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
        private void buttonLapHD_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SqlInsert = "INSERT INTO hoadon VALUES(@tenkhachhang,@sdt,@manv,@ngaylaphd,@biensoxe,@ghichu)";
                SqlCommand cmd = new SqlCommand(SqlInsert, con);
                cmd.Parameters.AddWithValue("tenkhachhang", textBoxHoTenKH.Text);
                cmd.Parameters.AddWithValue("sdt", textBoxSDT.Text);
                cmd.Parameters.AddWithValue("manv", Form1.manv);
                cmd.Parameters.AddWithValue("ngaylaphd", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("biensoxe", textBoxbiensoxe.Text);
                cmd.Parameters.AddWithValue("ghichu", textBoxghichu.Text);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Thêm dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm đơn nhập hàng: " + ex.Message);
            }
            String mahoadon = getMaHoaDonMoiNhat();
            for (int i = 0; i < hd.Count; i++)
            {
                String mamathang = hd[i].Mamathang;
                int soluong = hd[i].Soluong;
                double dongianhap = hd[i].Dongianhap;
                try
                {
                    SqlConnection con = new SqlConnection(chuoikn);
                    con.Open();
                    String SqlInsert = "INSERT INTO chitiethdMatHang VALUES(@mahoadon,@mamathang,@giamathang,@soluong)";
                    SqlCommand cmd = new SqlCommand(SqlInsert, con);
                    cmd.Parameters.AddWithValue("mahoadon", mahoadon);
                    cmd.Parameters.AddWithValue("mamathang", mamathang);
                    cmd.Parameters.AddWithValue("soluong", soluong);
                    cmd.Parameters.AddWithValue("giamathang", dongianhap);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Thêm dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    //updateSoLuongSPSauKhiNhapHang(mamathang, soluong);
                    //this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm chi tiết hóa đơn: " + ex.Message);
                }
            }
            for (int i = 0; i < ListdichVus.Count; i++)
            {
                String madichvu = ListdichVus[i].Madichvu;
                double giadichvu = Convert.ToDouble(getGiaDichVu(madichvu));
                try
                {
                    SqlConnection con = new SqlConnection(chuoikn);
                    con.Open();
                    String SqlInsert = "INSERT INTO chitiethdDichVu VALUES(@mahoadon,@madichvu,@giadichvu)";
                    SqlCommand cmd = new SqlCommand(SqlInsert, con);
                    cmd.Parameters.AddWithValue("mahoadon", mahoadon);
                    cmd.Parameters.AddWithValue("madichvu", madichvu);
                    cmd.Parameters.AddWithValue("giadichvu", giadichvu);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //updateSoLuongSPSauKhiNhapHang(mamathang, soluong);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm chi tiết hóa đơn: " + ex.Message);
                }
            }
            //UserControlQuanLyKho.check = true;
            MessageBox.Show("Lập phiếu nhập hàng thành công !");
            UserControlSuaChua.check = true;
            this.Close();

        }
        public String getTenKhachByBienSO(String biensoxe)
        {
            try
            {
                String SQL = "select tenkhachhang from hoadon where biensoxe=N'"+biensoxe+"'";
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                string kq =(string) cmd.ExecuteScalar();
                con.Close();
                return kq;
            }
            catch (Exception ex)
            {
                return ""+ex.Message;
            }
        }
        public String getsdtByBienSO(String biensoxe)
        {
            try
            {
                String SQL = "select sdt from hoadon where biensoxe=N'" + biensoxe + "'";
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                string kq = (string)cmd.ExecuteScalar();
                con.Close();
                return kq;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBoxbiensoxe_TextChanged(object sender, EventArgs e)
        {
            String tenkhachhang = getTenKhachByBienSO(textBoxbiensoxe.Text);
            String sdt = getsdtByBienSO(textBoxbiensoxe.Text);
            textBoxHoTenKH.Text = tenkhachhang;
            textBoxSDT.Text = sdt;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
