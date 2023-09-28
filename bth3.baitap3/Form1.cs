using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bth3.baitap3
{
    public partial class Dinhdang : Form
    {
        public Dinhdang()
        {
            InitializeComponent();
        }

       

        private void tbnhapten_TextChanged(object sender, EventArgs e)
        {
            tbketqua.Text = tbnhapten.Text;
        }
        private void Dinhdang_Load(object sender, EventArgs e)
        {
            tbnhapten.ForeColor = rbred.ForeColor;
            tbketqua.ForeColor = rbred.ForeColor;
        }

        private void rbred_CheckedChanged(object sender, EventArgs e)
        {
            if (rbred.Checked == true)
            {
                tbketqua.ForeColor = rbred.ForeColor;
            }
        }

        private void rbgreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgreen.Checked == true)
            {
                tbketqua.ForeColor = rbgreen.ForeColor;
            }
        }

        private void rbblue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbblue.Checked == true)
            {
                tbketqua.ForeColor = rbblue.ForeColor;
            }
        }

        private void rbblack_CheckedChanged(object sender, EventArgs e)
        {
            if (rbblack.Checked == true)
            {
                tbketqua.ForeColor=rbblack.ForeColor;
            }
        }

        private void cbdam_CheckedChanged(object sender, EventArgs e)
        {
            tbketqua.Font = new Font( tbketqua.Font.Name,
                                     tbketqua.Font.Size,   
                                     tbketqua.Font.Style^FontStyle.Bold);
        }

        private void cbnghieng_CheckedChanged(object sender, EventArgs e)
        {
            tbketqua.Font = new Font(tbketqua.Font.Name,
                tbketqua.Font.Size,
                tbketqua.Font.Style ^ FontStyle.Italic);
        }

        private void cbgach_CheckedChanged(object sender, EventArgs e)
        {
            tbketqua.Font = new Font(tbketqua.Font.Name,
                tbketqua.Font.Size,
                tbketqua.Font.Style ^ FontStyle.Underline);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dinhdang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
