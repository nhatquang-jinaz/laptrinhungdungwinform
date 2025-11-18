using System.Diagnostics.Metrics;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rad2_CheckedChanged(object sender, EventArgs e)
        {
            if (rad2.Checked)
                txtKQ.Font = new Font("Arial", 14);
        }

        private void rad3_CheckedChanged(object sender, EventArgs e)
        {
            if (rad3.Checked)
                txtKQ.Font = new Font("Tahoma", 14);
        }

        private void rad4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rad4.Checked)
                txtKQ.Font = new Font("Courier New", 14);
        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {
            if (rad1.Checked)
                txtKQ.Font = new Font("Times New Roman", 14);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
