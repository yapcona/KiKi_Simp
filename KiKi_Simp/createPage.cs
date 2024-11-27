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
        private bool useLowerCase = true; // Standardmäßig auf true setzen

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
            int counter = 10; // Passwortlänge (individuell anpassen)
            string PassLowerCase = "abcdefghijklmnopqrstuvwxyz";
            string PassUpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string PassNumbers = "1234567890";
            string PassSymbols = "!§$%&/()=?-_,.:";
            StringBuilder res = new StringBuilder(); // Erstelle ein leeres StringBuilder-Objekt
            Random random = new Random();

            // Initialisiere alle möglichen Zeichen basierend auf den Checkbox-Einstellungen
            string allChars = "";
            if (useLowerCase)
            {
                allChars += PassLowerCase;
                res.Append(PassLowerCase[random.Next(PassLowerCase.Length)]);
            }
            allChars += PassUpperCase + PassNumbers + PassSymbols;
            res.Append(PassUpperCase[random.Next(PassUpperCase.Length)]);
            res.Append(PassNumbers[random.Next(PassNumbers.Length)]);
            res.Append(PassSymbols[random.Next(PassSymbols.Length)]);

            // Den Rest der Passwortlänge mit zufälligen Zeichen auffüllen
            for (int i = res.Length; i < counter; i++)
            {
                res.Append(allChars[random.Next(allChars.Length)]);
            }

            // Das Ergebnis mischen und als Text setzen
            txtPass.Text = new string(res.ToString().OrderBy(c => random.Next()).ToArray());
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
            useLowerCase = checkBox1.Checked;
        }
    }
}
