namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click_1(object sender, EventArgs e)
        {
            string tendangnhap = txtUser.Text;
            string matkhau = txtPass.Text;
            string message = $"Ten dang nhap: {tendangnhap} \nMatkhau: {matkhau}";

            if (chkNho.Checked)
            {
                message += "\nBan co ghi nho?";
            }
            MessageBox.Show(message, "Thong bao");
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            txtUser.Focus();
            chkNho.Checked = false;
        }

        private void btnDung_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
