using System;

namespace Bai12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn0.Click += NumberButtons;
            btn1.Click += NumberButtons;
            btn2.Click += NumberButtons;
            btn3.Click += NumberButtons;
            btn4.Click += NumberButtons;
            btn5.Click += NumberButtons;
            btn6.Click += NumberButtons;
            btn7.Click += NumberButtons;
            btn8.Click += NumberButtons;
            btn9.Click += NumberButtons;
            btnCong.Click += Operations;
            btnTru.Click += Operations;
            btnNhan.Click += Operations;
            btnChia.Click += Operations;
            txtManHinh.Text = "0";
        }

        string chuoitam = "";
        char toantu;
        double[] toanhang = new double[2];
        double ketqua;
        int buoc = 1;

        private void NumberButtons(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (buoc == 3)
            {
                buoc = 1;
                chuoitam = "";
                toantu = ' ';
            }

            if ((b == null) || (b.Text == "0" && chuoitam.Length == 0 && txtManHinh.Text == "0"))
                return;

            if (chuoitam.Length == 0 && b.Text != ".")
            {
                chuoitam = b.Text;
            }
            else
            {
                chuoitam += b.Text;
            }
            txtManHinh.Text = chuoitam;
        }

        private void btnCongTru_Click(object sender, EventArgs e)
        {
            if (chuoitam.Contains('-'))
                chuoitam = chuoitam.Replace("-", "");
            else
                chuoitam = "-" + chuoitam;
            txtManHinh.Text = chuoitam;
        }

        private void btnCham_Click(object sender, EventArgs e)
        {
            if (!chuoitam.Contains('.'))
            {
                if (chuoitam.Length == 0)
                {
                    chuoitam = "0.";
                }
                else
                {
                    chuoitam = chuoitam + ".";
                }
                txtManHinh.Text = chuoitam;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (buoc == 3 || (chuoitam.Length == 0 && toantu != ' '))
            {
                buoc = 1;
                toanhang[0] = toanhang[1] = 0.0;
                toantu = ' ';
                ketqua = 0.0;
                chuoitam = "";
                txtManHinh.Text = "0";
            }
            else if (chuoitam.Length > 0)
            {
                chuoitam = "";
                txtManHinh.Text = "0";
            }
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            if (buoc == 2)
            {
                if (chuoitam.Length == 0)
                {
                    toanhang[1] = toanhang[0];
                }
                else if (chuoitam.Length != 0)
                {
                    if (!Double.TryParse(chuoitam, out toanhang[1]))
                    {
                        MessageBox.Show("Số thứ hai không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else if (buoc == 3)
            {

            }
            else
            {
                return;
            }

            if (toantu == '/' && toanhang[1] == 0)
            {
                txtManHinh.Text = "Lỗi chia 0";
                buoc = 3;
                chuoitam = "";
                return;
            }

            switch (toantu)
            {
                case '+': ketqua = toanhang[0] + toanhang[1]; break;
                case '-': ketqua = toanhang[0] - toanhang[1]; break;
                case '*': ketqua = toanhang[0] * toanhang[1]; break;
                case '/': ketqua = toanhang[0] / toanhang[1]; break;
                default:
                    ketqua = toanhang[0];
                    break;
            }

            txtManHinh.Text = ketqua.ToString();

            toanhang[0] = ketqua;
            buoc = 3;
            chuoitam = "";
        }

        private void Operations(object sender, EventArgs e)
        {
            Button b = sender as Button;
            char toantuMoi = b.Text[0];
            double soHienTai = 0;

            if (chuoitam.Length > 0)
            {
                if (!double.TryParse(chuoitam, out soHienTai))
                {
                    MessageBox.Show("Dữ liệu nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnC_Click(null, null);
                    return;
                }
            }
            else if (buoc == 3)
            {
                toantu = toantuMoi;
                buoc = 2;
                txtManHinh.Text = toanhang[0].ToString() + " " + toantu;
                chuoitam = "";
                return;
            }
            else if (chuoitam.Length == 0 && buoc == 2)
            {
                toantu = toantuMoi;
                txtManHinh.Text = toanhang[0].ToString() + " " + toantu;
                return;
            }

            if (buoc == 1)
            {
                toanhang[0] = soHienTai;
                toantu = toantuMoi;
                buoc = 2;
                txtManHinh.Text = toanhang[0].ToString() + " " + toantu;
            }
            else
            {
                toanhang[1] = soHienTai;

                btnBang_Click(null, null);

                toantu = toantuMoi;
                buoc = 2;

                txtManHinh.Text = toanhang[0].ToString() + " " + toantu;
            }

            chuoitam = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }
    }
}
