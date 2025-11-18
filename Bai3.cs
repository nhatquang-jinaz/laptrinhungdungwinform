namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSo.Text = "";
            cboSo.Items.Clear();
            lboSo.Items.Clear();
            txtSo.Focus();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            cboSo.Items.Add(txtSo.Text);
            lboSo.Items.Add(txtSo.Text);
            txtSo.Clear();
            txtSo.Focus();
        }

        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lboSo.Items.Clear(); 

            int so = int.Parse(cboSo.SelectedItem.ToString());

            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                {
                    lboSo.Items.Add(i);
                }
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            for (int i = 0; i < lboSo.Items.Count; i++)
            {
                tong += int.Parse(lboSo.Items[i].ToString());
            }

            MessageBox.Show("Tổng các ước số = " + tong);
        }

        private void btnchan_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < lboSo.Items.Count; i++)
            {
                int x = int.Parse(lboSo.Items[i].ToString());
                if (x % 2 == 0)
                    dem++;
            }

            MessageBox.Show("Số lượng ước số chẵn = " + dem);
        }

        private bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }

        private void btnSNT_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < lboSo.Items.Count; i++)
            {
                int x = int.Parse(lboSo.Items[i].ToString());
                if (IsPrime(x))
                    dem++;
            }

            MessageBox.Show("Số lượng ước số nguyên tố = " + dem);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
