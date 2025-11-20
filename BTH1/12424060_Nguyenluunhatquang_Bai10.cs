using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lbxLopA.SelectedIndex == -1)
            {
                MessageBox.Show("Chua chon phan tu");
                return;
            }

            lbxLopA.Items.RemoveAt(lbxLopA.SelectedIndex);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            lbxLopA.Items.Add(txtHoTen.Text);
            txtHoTen.Clear();
            txtHoTen.Focus();
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtHoTen, "Ten khong duoc rong");
            else
                this.errorProvider1.Clear();
        }

        private void btnChuyenPhai_Click(object sender, EventArgs e)
        {
            ChuyenMot(lbxLopA, lbxLopB);
        }

        private void btnChuyenTrai_Click(object sender, EventArgs e)
        {
            ChuyenMot(lbxLopB, lbxLopA);
        }

        private void btnChuyenHetPhai_Click(object sender, EventArgs e)
        {
            ChuyenTatCa(lbxLopA, lbxLopB);
        }

        private void btnChuyenHetTrai_Click(object sender, EventArgs e)
        {
            ChuyenTatCa(lbxLopB, lbxLopA);
        }
        private void ChuyenMot(ListBox sourceListbox, ListBox destinationListbox)
        {
            if (sourceListbox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chon sinh vien de chuyen", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<string> selectedItems = new List<string>();
            foreach (object item in sourceListbox.SelectedItems)
            {
                selectedItems.Add(item.ToString());
            }

            foreach (string item in selectedItems)
            {
                destinationListbox.Items.Add(item);
            }

            for (int j = selectedItems.Count - 1; j >= 0; j--)
            {
                sourceListbox.Items.Remove(selectedItems[j]);
            }
        }
        private void ChuyenTatCa(ListBox sourceListbox, ListBox destinationListbox)
        {
            if (sourceListbox.Items.Count == 0)
            {
                MessageBox.Show("Danh sach nguon rong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (object item in sourceListbox.Items)
            {
                if (!destinationListbox.Items.Contains(item))
                {
                    destinationListbox.Items.Add(item);
                }
            }

            sourceListbox.Items.Clear();
        }
    }
}
