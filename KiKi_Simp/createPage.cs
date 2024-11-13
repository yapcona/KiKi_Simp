using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiKi_Simp
{
    public partial class createPage : Form
    {
        public createPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int counter = 10; // password char
            string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random random = new Random();

            while (0 < counter--)
            {
                res.Append(valid[random.Next(valid.Length)]);
            }
            txtPass.Text = res.ToString();
        }

        private void btnHide_Show_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
            {
                txtPass.UseSystemPasswordChar = false;
                btnHide_Show.Text = "Hide password";
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                btnHide_Show.Text = "Show password";
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
