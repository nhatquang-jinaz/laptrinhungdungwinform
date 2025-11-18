namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKetqua_Click(object sender, EventArgs e)
        {
            string hoten = this.txthoten.Text.Trim();
            if (this.rad1.Checked == true)
            {
                txtKQ.Text = hoten;
                txtKQ.ForeColor = Color.Red;
            }
            if (this.rad2.Checked == true)
            {
                txtKQ.Text = hoten;
                txtKQ.ForeColor = Color.Green;
            }
            if (this.rad3.Checked == true)
            {
                txtKQ.Text = hoten;
                txtKQ.ForeColor = Color.Blue;
            }
            if (this.rad4.Checked == true)
            {
                txtKQ.Text = hoten;
                txtKQ.ForeColor = Color.Black;
            }

            FontStyle style = FontStyle.Regular;
            if (this.chk1.Checked)
                style |= FontStyle.Bold;
            if (this.chk2.Checked)
                style |= FontStyle.Italic;
            if (this.chk3.Checked)
                style |= FontStyle.Underline;
            txtKQ.Font = new Font(txtKQ.Font, style);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
