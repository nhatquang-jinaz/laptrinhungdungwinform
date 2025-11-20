namespace Bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Ban muon thoat khong?",
                "Xac nhan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGiai.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            Kiemtrahople();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            Kiemtrahople();
        }
        private void Kiemtrahople()
        {
            double a, b;
            bool hople = double.TryParse(txtA.Text, out a);
                           double.TryParse(txtB.Text, out b);
            if (!double.TryParse(txtA.Text, out a))
                this.errorProvider1.SetError(txtA, "A phai la so");
            else
                this.errorProvider1.Clear();
            if (!double.TryParse(txtB.Text,out b))
                this.errorProvider1.SetError(txtB, "B phai la so");
            else
                this.errorProvider1.Clear();
            btnGiai.Enabled=hople;
        }
        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double x;
            if(a==0)
            {
                if (b == 0)
                    txtKQ.Text = "Vo so nghiem";
                else
                    txtKQ.Text = "Vo nghiem";
            }
            else
            {
                x = -b / a;
                txtKQ.Text = "x= " + x.ToString();
            }
            btnXoa.Enabled = true;

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKQ.Clear();
            txtA.Focus();
            btnXoa.Enabled=false;
        }
    }

}
