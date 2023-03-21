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
using quanlygara.Report;

namespace quanlygara.UserControls
{
    public partial class UserControlThongKeBaoCao : UserControl
    {
        public UserControlThongKeBaoCao()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        public void HienThiDuLieu02(DataGridView data, string tungay, string denngay)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SQL = "select mahoadon,tenkhachhang,hoadon.sdt,nhanvien.hotennv,ngaylaphd,dbo.tongtienHoaDOn(mahoadon) as tongthanhtien from hoadon INNER JOIN nhanvien ON hoadon.manv=nhanvien.manv where cast(ngaylaphd as date)>='"+tungay+"' and cast(ngaylaphd as date)<='"+denngay+"'";
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
        private void buttonXemBC_Click(object sender, EventArgs e)
        {
            String tungay =dateTimePickerTuNgay.Value.ToString("yyyy-MM-dd");
            String denngay = dateTimePickerDenNgay.Value.ToString("yyyy-MM-dd");
            HienThiDuLieu02(dataGridViewHoaDon, tungay, denngay);
        }
        public void loadmathang()
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                string sqlselect = "select mamathang,tenmathang,loaihang.tenloaihang,hangsx.tenhangsx,giaban,soluong,mota from mathang INNER JOIN loaihang ON mathang.maloaihang = loaihang.maloaihang INNER JOIN hangsx ON mathang.mahangsx = hangsx.mahangsx";
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
        private void buttonXuatHD_Click(object sender, EventArgs e)
        {
            CrystalReportBCDoanhThu xuatbc = new CrystalReportBCDoanhThu();
            xuatbc.SetDataSource(dataGridViewHoaDon.DataSource);
            //hiển thị báo cáo lên form in báo cáo
            FormInBaoCao inbc = new FormInBaoCao();
            inbc.crystalReportViewer1.ReportSource = xuatbc;
            inbc.ShowDialog();
        }

        private void UserControlThongKeBaoCao_Load(object sender, EventArgs e)
        {
            loadmathang();
            loadcombobox("nhanvien", "manv", "hotennv", comboBoxnhanviennn);
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
        private void buttonXuatBCSP_Click(object sender, EventArgs e)
        {
            CrystalReportBCSP xuatbc = new CrystalReportBCSP();
            xuatbc.SetDataSource(dataGridViewMatHang.DataSource);
            //hiển thị báo cáo lên form in báo cáo
            FormInBaoCao inbc = new FormInBaoCao();
            inbc.crystalReportViewer1.ReportSource = xuatbc;
            inbc.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonxembcnv_Click(object sender, EventArgs e)
        {
            String tungay = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            String denngay = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            HienThiDuLieu03(dataGridViewreportnvvvvv, tungay, denngay);
        }
        public void HienThiDuLieu03(DataGridView data, string tungay, string denngay)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SQL = "select mahoadon,tenkhachhang,hoadon.sdt,nhanvien.hotennv,ngaylaphd,dbo.tongtienHoaDOn(mahoadon) as tongthanhtien from hoadon INNER JOIN nhanvien ON hoadon.manv=nhanvien.manv where cast(ngaylaphd as date)>='" + tungay + "' and cast(ngaylaphd as date)<='" + denngay + "' and hoadon.manv=N'"+ comboBoxnhanviennn .SelectedValue.ToString()+ "'";
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonxuatbcccccc_Click(object sender, EventArgs e)
        {
            CrystalReportBCDoanhThu xuatbc = new CrystalReportBCDoanhThu();
            xuatbc.SetDataSource(dataGridViewreportnvvvvv.DataSource);
            //hiển thị báo cáo lên form in báo cáo
            FormInBaoCao inbc = new FormInBaoCao();
            inbc.crystalReportViewer1.ReportSource = xuatbc;
            inbc.ShowDialog();
        }
    }
}
