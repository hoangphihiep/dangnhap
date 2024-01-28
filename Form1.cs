namespace baithuchanh3_freeuts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_dangnhap.Text) || !string.IsNullOrWhiteSpace(txt_MatKhau.Text))
            {
                MessageBox.Show("Đăng nhập thành công !!!");
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");
            }
        }

        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_MatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8)
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txt_MatKhau.PasswordChar = (char)0;
            }
            else
            {
                txt_MatKhau.PasswordChar = '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tool_ThongBao.SetToolTip(txt_dangnhap, "Chỉ được nhập ký tự a-z và 0-9");
            tool_ThongBao.SetToolTip(txt_MatKhau, "Chỉ được nhập ký tự 0-9");
            help_Thongbao.HelpNamespace = "https://www.spoj.com/PTIT/problems/BCPALIN/";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}