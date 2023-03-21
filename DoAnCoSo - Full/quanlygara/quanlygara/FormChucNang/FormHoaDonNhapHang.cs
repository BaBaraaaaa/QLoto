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
    public partial class FormHoaDonNhapHang : Form
    {
        public FormHoaDonNhapHang()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        List<HoaDon> hd = new List<HoaDon>();
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
        private void buttonThemHoaDOn_Click(object sender, EventArgs e)
        {
            String mamh = comboBoxMatHang.SelectedValue.ToString();
            String tenmh = comboBoxMatHang.Text;
            int soluong =Convert.ToInt32(numericUpDownSoluong.Value);
            double dongianhap = (double)numericUpDownDonGia.Value;
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
                        load();
                        return;
                    }
                }
                HoaDon hoaDon = new HoaDon(mamh, tenmh, dongianhap, soluong, thanhtien);
                hd.Add(hoaDon);
                load();
            }
            else
            {
                HoaDon hoaDon = new HoaDon(mamh, tenmh, dongianhap, soluong, thanhtien);
                hd.Add(hoaDon);
                load();
            }
            
        }
        public String getTenNhanVien(String manv)
        {
            try
            {
                String SQL = "select hotennv from nhanvien where manv='" + manv + "'";
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
        private void FormHoaDonNhapHang_Load(object sender, EventArgs e)
        {
            textBoxHoTenNV.Text = Form1.manv + "-" + getTenNhanVien(Form1.manv);
            dateTimePickerNgayNhapHang.Value =Convert.ToDateTime(DateTime.Now.ToString());
            loadcombobox("nhacungcap", "manhacc", "tennhacc", comboBoxNCC);
            loadcombobox("mathang", "mamathang", "tenmathang", comboBoxMatHang);
        }
        public void load()
        {
            dataGridViewHoaDOn.DataSource=null;
            dataGridViewHoaDOn.DataSource = hd;

        }
        public String getMaNhapHangMoiNhat()
        {
            try
            {
                String SQL = "select max(manhaphang) from nhaphang";
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
        public void  updateSoLuongSPSauKhiNhapHang(String masp, int soluong)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SqlUpdate = "UPDATE mathang SET soluong=soluong+"+soluong+" WHERE mamathang=@mamathang";
                SqlCommand cmd = new SqlCommand(SqlUpdate, con);
                cmd.Parameters.AddWithValue("mamathang", masp);
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
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SqlInsert = "INSERT INTO nhaphang VALUES(@manhacc,@manv,@ngaynhaphang)";
                SqlCommand cmd = new SqlCommand(SqlInsert, con);
                cmd.Parameters.AddWithValue("manhacc", comboBoxNCC.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("manv",Form1.manv);
                cmd.Parameters.AddWithValue("ngaynhaphang", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Thêm dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                //UserControlDanhMucChung.checkdataChange = true;
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm đơn nhập hàng: " + ex.Message);
            }
            String manhaphang = getMaNhapHangMoiNhat();
            for (int i = 0; i < hd.Count; i++)
            {
                String mamathang = hd[i].Mamathang;
                int soluong = hd[i].Soluong;
                double dongianhap = hd[i].Dongianhap;
                try
                {
                    SqlConnection con = new SqlConnection(chuoikn);
                    con.Open();
                    String SqlInsert = "INSERT INTO chitietnhaphang VALUES(@manhaphang,@mamathang,@soluong,@dongianhap)";
                    SqlCommand cmd = new SqlCommand(SqlInsert, con);
                    cmd.Parameters.AddWithValue("manhaphang", manhaphang);
                    cmd.Parameters.AddWithValue("mamathang",mamathang);
                    cmd.Parameters.AddWithValue("soluong", soluong);
                    cmd.Parameters.AddWithValue("dongianhap", dongianhap);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Thêm dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    updateSoLuongSPSauKhiNhapHang(mamathang, soluong);
                    //this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm chi tiết đơn nhập hàng: " + ex.Message);
                }
            }
            UserControlQuanLyKho.check = true;
            MessageBox.Show("Lập phiếu nhập hàng thành công !");
            this.Close();
        }

        private void dataGridViewHoaDOn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String mamathang = "" + dataGridViewHoaDOn.SelectedCells[0].OwningRow.Cells["mamathang"].Value;
            //if click is on new row or header row
            if (e.RowIndex == dataGridViewHoaDOn.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            if (e.ColumnIndex == dataGridViewHoaDOn.Columns["XoaMatHang"].Index)
            {
                for (int i = 0; i < hd.Count; i++)
                {
                    if (hd[i].Mamathang.Equals(mamathang))
                    {
                        hd.RemoveAt(i);
                        load();
                    }
                }
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
