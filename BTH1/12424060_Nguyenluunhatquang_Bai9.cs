namespace Bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNhap.Clear();
            listBox1.Items.Clear();
            txtNhap.Focus();
            this.MinimumSize = new System.Drawing.Size(600, 400);
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnTong_Click(object sender, EventArgs e)
        {

            int tong = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                tong += int.Parse(listBox1.Items[i].ToString());
            }

            MessageBox.Show("Tổng= " + tong);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtNhap.Text);
            txtNhap.Clear();
            txtNhap.Focus();
        }

        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Danh sach rong");
                return;
            }

            listBox1.Items.RemoveAt(0);//xoa o dau

            if (listBox1.Items.Count > 0)
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);//xoa o cuoi
        }

        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Chua chon phan tu");
                return;
            }

            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = int.Parse(listBox1.Items[i].ToString());
                listBox1.Items[i] = x + 2;
            }
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = int.Parse(listBox1.Items[i].ToString());
                listBox1.Items[i] = x * x;
            }
        }

        private void btnSoChan_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = int.Parse(listBox1.Items[i].ToString());
                if (x % 2 == 0)
                    listBox1.SetSelected(i, true);
            }
        }

        private void btnSoLe_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = int.Parse(listBox1.Items[i].ToString());
                if (x % 2 != 0)
                    listBox1.SetSelected(i, true);
            }
        }
    
    }
}
