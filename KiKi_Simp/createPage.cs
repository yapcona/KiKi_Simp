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
            int counter = 10; // password länge (INDIVIDUELL ANPASSUNG hinzufügen)
            string PassLowerCase = "abcdefghijklmnopqrstuvwxyz";
            string PassUpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string PassNumbers = "1234567890";
            string PassSymbols = "!§$%&/()=?-_,.:";
            StringBuilder res = new StringBuilder(); // Create empty StringBuilder-Object
            Random random = new Random();

            // Ensure that the password contains at least one character from each set
            res.Append(PassLowerCase[random.Next(PassLowerCase.Length)]); //.Append
            res.Append(PassUpperCase[random.Next(PassUpperCase.Length)]);
            res.Append(PassNumbers[random.Next(PassNumbers.Length)]);
            res.Append(random.Next(PassSymbols.Length));

            // Fill the rest of the paswor lenght with random characters
            string allChars = PassLowerCase + PassLowerCase + PassNumbers + PassSymbols;
            for (int i = res.Length, i < counter; i++)
            {

            }

            while (0 < counter--)
            {
                res.Append(PassLowerCase[random.Next(PassLowerCase.Length)]);
            }
            txtPass.Text = res.ToString();

            while (0 < counter--)
            {
                res.Append(PassUpperCase[random.Next(PassUpperCase.Length)]);
            }
            txtPass.Text = res.ToString();

            while (0 < counter--)
            {
                res.Append(PassNumbers[random.Next(PassNumbers.Length)]);
            }
            txtPass.Text = res.ToString();

            while (0 < counter--)
            {
                res.Append(PassSymbols[random.Next(PassSymbols.Length)]);
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

        private void createPage_Load(object sender, EventArgs e)
        {

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked) 
            {
                
            }
    }
}
