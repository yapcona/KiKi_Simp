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
        private bool useUpperCase = true;
        private bool useNumbers = true;
        private bool useSymbols = true;

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
            int counter = 10; // Passwortlänge (will do it later: individuell anpassen)

            StringBuilder res = new StringBuilder(); // Erstelle ein leeres StringBuilder-Objekt
            Random random = new Random();


            var charSets = new List<(string chars, bool use)>
            {
                ("abcdefghijklmnopqrstuvwxyz", useLowerCase),
                ("ABCDEFGHIJKLMNOPQRSTUVWXYZ", useUpperCase),
                ("1234567890", useNumbers),
                ("!%&/()=?-_,.:", useSymbols)
            };

            // Initialisiere alle möglichen Zeichen basierend auf den Checkbox-Einstellungen
            string allChars = "";

            foreach (var (chars, use) in charSets)
            {
                if (use)
                {
                    allChars += chars;
                    res.Append(chars[random.Next(chars.Length)]);
                }
            }

            if(string.IsNullOrEmpty(allChars))
            {
                MessageBox.Show("Please select at least one character!");
                return;
            }


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
            useLowerCase = checkBox_LowerCase.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            useUpperCase = checkBox_UpperCase.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            useNumbers = checkBox_Numbers.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            useSymbols = checkBox_Symbols.Checked;
        }
    }
}
