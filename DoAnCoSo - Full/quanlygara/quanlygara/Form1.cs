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

namespace quanlygara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        UserControlHome qltrangchu;
        UserControlDanhMucChung quantrihethong;
        UserControlQuanLyKho QuanLyKho;
        UserControlTaiKhoanCaNhan userControlTaiKhoan;
        UserControlSuaChua UserControlSuaChua;
        UserControlThongKeBaoCao UserControlThongKeBao;
        public static String manv;
        //hiện thị user control lên giao diện
        public void ShowUserControls(UserControl user, Panel panel)//hiển thị usercontrol lên giao diện
        {
            panel.Controls.Add(user);
            user.Dock = DockStyle.Fill;
        }
        //set màu cho button
        public void setcolor(string name)
        {
            foreach (Control item in panel1.Controls)
            {
                if(item.GetType()==typeof(Button))
                {
                    if (item.Name.Equals(name))
                    {
                        item.BackColor = Color.FromArgb(0, 153, 153);
                    }
                    else
                    {
                        item.BackColor = Color.Teal;
                    }
                }
            }
        }
        private void button_TrangChu_Click(object sender, EventArgs e)
        {
            qltrangchu = new UserControlHome();
            this.Text = "Trang chủ";
            ShowUserControls(qltrangchu, panel_ShowUserControls);
            qltrangchu.BringToFront();
            setcolor("button_TrangChu");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_TrangChu.PerformClick();
            PhanQuyenGiaoDien();
            label_TenNguoiDungDangNhap.Text = getTen(manv);
        }

        private void button_QLKho_Click(object sender, EventArgs e)
        {
            QuanLyKho = new UserControlQuanLyKho();
            this.Text = "Quản lý kho";
            ShowUserControls(QuanLyKho, panel_ShowUserControls);
            QuanLyKho.BringToFront();
            setcolor("button_QLKho");
        }

        private void button_QLSuaChua_Click(object sender, EventArgs e)
        {
            UserControlSuaChua = new UserControlSuaChua();
            this.Text = "Quản lý sửa chữa/bảo trì xe";
            ShowUserControls(UserControlSuaChua, panel_ShowUserControls);
            UserControlSuaChua.BringToFront();
            setcolor("button_QLSuaChua");
        }

        private void buttonQLDoanhMucChung_Click(object sender, EventArgs e)
        {
            quantrihethong = new UserControlDanhMucChung();
            this.Text = "Quản trị hệ thống";
            ShowUserControls(quantrihethong, panel_ShowUserControls);
            quantrihethong.BringToFront();
            setcolor("buttonQLDoanhMucChung");
        }

        private void buttonTKCaNhan_Click(object sender, EventArgs e)
        {
            userControlTaiKhoan = new UserControlTaiKhoanCaNhan();
            this.Text = "Tài khoản cá nhân";
            ShowUserControls(userControlTaiKhoan, panel_ShowUserControls);
            userControlTaiKhoan.BringToFront();
            setcolor("buttonTKCaNhan");
        }

        private void buttonBaoCao_Click(object sender, EventArgs e)
        {
            UserControlThongKeBao = new UserControlThongKeBaoCao();
            this.Text = "Thống kê báo cáo";
            ShowUserControls(UserControlThongKeBao, panel_ShowUserControls);
            UserControlThongKeBao.BringToFront();
            setcolor("buttonBaoCao");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
        }
        public String getQuyen(String manv)
        {
            try
            {
                String SQL = "select quyen from dangnhap where tendangnhap='" + manv + "'";
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
        public String getTen(String manv)
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
        public void PhanQuyenGiaoDien()
        {
            String quyendangnhap = getQuyen(manv);
            if(quyendangnhap.Equals("Chưa phân quyền"))//chưa phân quyền chủ được nhìn thấy giao diện giới thiệu phần mềm
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item.GetType() == typeof(Button))
                    {
                        if (!item.Name.Equals("button_TrangChu"))
                        {
                            item.Visible =false;
                        }
                        
                    }
                }
            }
            if (quyendangnhap.Equals("Quyền thủ kho"))
            {
                button_QLSuaChua.Visible = false;
                buttonQLDoanhMucChung.Visible = false;
            }
            if (quyendangnhap.Equals("Quyền nhân viên"))
            {
                button_QLKho.Visible = false;
                buttonQLDoanhMucChung.Visible = false;
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
