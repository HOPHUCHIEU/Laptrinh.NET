using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCaNhan
{
    public partial class frm_DangNhap : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_DangNhap()
        {
            InitializeComponent();
            //tên đăng nhập
            var a = this.PointToScreen(label2.Location);
            a = pictureBox1.PointToClient(a);
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            //mật khẩu
            var b = this.PointToScreen(label3.Location);
            b = pictureBox1.PointToClient(b);
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            //hiển thị
            var c = this.PointToScreen(ck_HienThiMatKhau.Location);
            c = pictureBox1.PointToClient(c);
            ck_HienThiMatKhau.Parent = pictureBox1;
            ck_HienThiMatKhau.BackColor = Color.Transparent;
            //lb1
            var d = this.PointToScreen(label1.Location);
            d = pictureBox1.PointToClient(d);
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            //lb2
            var h = this.PointToScreen(label4.Location);
            h = pictureBox1.PointToClient(h);
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            //lb3
            var l = this.PointToScreen(label5.Location);
            l = pictureBox1.PointToClient(l);
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;
            //lb6
            var e = this.PointToScreen(label6.Location);
            e = pictureBox1.PointToClient(e);
            label6.Parent = pictureBox1;
            label6.BackColor = Color.Transparent;
        }

        private void ck_HienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_HienThiMatKhau.Checked == true)
                txt_MatKhau.UseSystemPasswordChar = false;
            else txt_MatKhau.UseSystemPasswordChar = true;
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string sql = "Select COUNT (*) from MAYBAY where TenTK = '" + txt_TenDangNhap.Text + "' and MatKhau = '" + txt_MatKhau.Text + "'";
            int kq = (int)lopchung.GetData(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Đăng nhập thành công!");
                frm_DangNhap sv = new frm_DangNhap();
                sv.Show();
            }
            else MessageBox.Show("Đăng nhập thất bại, tài khoản hoặc mật khẩu không đúng");
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) Application.Exit();
        }
    }
}
