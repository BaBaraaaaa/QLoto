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
    public partial class CardProduct : UserControl
    {
        public CardProduct()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        private String MaSP;
        private String hinhanh;
        private String tensp;
        private String soluong;
        private String gia;
        private String maloaihang;
        private String mahangsx;
        private String mota;
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public string Soluong { get => soluong; set => soluong = value; }
        public string Gia { get => gia; set => gia = value; }
        public string MaSP1 { get => MaSP; set => MaSP = value; }
        public string Maloaihang { get => maloaihang; set => maloaihang = value; }
        public string Mahangsx { get => mahangsx; set => mahangsx = value; }
        public string Mota { get => mota; set => mota = value; }

        private void buttonXemSP_Click(object sender, EventArgs e)
        {
            FormSuaMatHang.mamathang = MaSP1;
            FormSuaMatHang.tenmathang = Tensp;
            FormSuaMatHang.maloaihang = (String)excuteResuft("select tenloaihang from loaihang where maloaihang='"+Maloaihang+"'") ;
            FormSuaMatHang.mahangsx = (String)excuteResuft("select tenhangsx from hangsx where mahangsx='" + Mahangsx + "'");
            FormSuaMatHang.hinhanh = Hinhanh;
            FormSuaMatHang.giaban = Gia;
            FormSuaMatHang.soluong = Soluong;
            FormSuaMatHang.mota = Mota;
            FormSuaMatHang f = new FormSuaMatHang();
            f.ShowDialog();
        }
        
        public Object excuteResuft(String SQL)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                String kq=cmd.ExecuteScalar().ToString();
                con.Close();
                return kq;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.ToString());
                return 0;
            }
        }
        private void CardProduct_Load(object sender, EventArgs e)
        {
            pictureBoxProductIMG.Image = new Bitmap(hinhanh);
            labelTenSP.Text = Tensp;
            labelSoLuong.Text ="Số lượng: "+ Soluong;
            labelGia.Text ="Giá: "+ Gia+" VND";
        }
    }
}
