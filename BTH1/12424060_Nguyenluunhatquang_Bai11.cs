using System.Drawing;
using System.Text;

namespace Bai11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboNienKhoa.Items.AddRange(new string[] { "2004", "2005", "2006", "2007" });
            cboLop.Items.AddRange(new string[] { "TH01", "TH02", "TH03", "KT01" });
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMa.Clear();
            this.txtHoten.Clear();
            this.rad1.Checked = false;
            this.rad2.Checked = false;
            this.rad3.Checked = false;
            this.rad4.Checked = false;
            this.chk1.Checked = false;
            this.chk2.Checked = false;
            this.chk3.Checked = false;
            this.chk4.Checked = false;
            cboNienKhoa.SelectedIndex = -1;
            cboLop.SelectedIndex = -1;
            this.txtMa.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoten.Text;
            string lop = cboLop.SelectedItem.ToString();
            string nienKhoa = cboNienKhoa.SelectedItem.ToString();

            string hocKy = "";
            if (rad1.Checked) hocKy = "I";
            else if (rad2.Checked) hocKy = "II";
            else if (rad3.Checked) hocKy = "III";
            else if (rad4.Checked) hocKy = "IV";

            StringBuilder monHocList = new StringBuilder();
            int stt = 1;
            int countMonHoc = 0;

            if (chk1.Checked)
            {
                monHocList.AppendLine($"{stt}. LT Windows");
                stt++;
                countMonHoc++;
            }
            if (chk2.Checked)
            {
                monHocList.AppendLine($"{stt}. LT Internet");
                stt++;
                countMonHoc++;
            }
            if (chk3.Checked)
            {
                monHocList.AppendLine($"{stt}. Mạng máy tính");
                stt++;
                countMonHoc++;
            }
            if (chk4.Checked)
            {
                monHocList.AppendLine($"{stt}. UML");
                stt++;
                countMonHoc++;
            }


            string message = $"Sinh vien: {hoTen}\n" +
                             $"Lop: {lop}\n" +
                             $"Nien khoa: {nienKhoa}\n\n" +
                             $"Dang ky hoc ky {hocKy} cung {countMonHoc} mon:\n" +
                             monHocList.ToString();

            MessageBox.Show(message, "Thanh cong", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
