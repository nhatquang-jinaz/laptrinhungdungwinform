namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNhap_Click(object sender, EventArgs e)
        {

        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnKetqua_Click(object sender, EventArgs e)
        {
            double s1 = double.Parse(txtS1.Text);
            double s2 = double.Parse(txtS2.Text);
            double Tong = s1 + s2;
            double Hieu = s1 - s2;
            double Tich = s1 * s2;
            double Thuong = s1 / s2;

            if (this.rad1.Checked == true)
                txtKQ.Text = Tong.ToString();
            if (this.rad2.Checked == true)
                txtKQ.Text = Hieu.ToString();
            if (this.rad3.Checked == true)
                txtKQ.Text = Tich.ToString();
            if (this.rad4.Checked == true)
                txtKQ.Text = Thuong.ToString();
        }
    }
}
