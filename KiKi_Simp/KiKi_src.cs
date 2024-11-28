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
    public partial class KiKi_src : Form
    {
        // Variablen zur Steuerung der verwendeten Zeichensätze basierend auf den Checkbox-Einstellungen
        private bool useLowerCase = true; // Standardmäßig auf true setzen
        private bool useUpperCase = true;
        private bool useNumbers = true;
        private bool useSymbols = true;

        public KiKi_src()
        {
            // Initialisiert die Komponenten der Form
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

        // Event-Handler für Klicks auf den "Generate"-Button
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Aktualisierung der Checkbox-Zustände unmittelbar vo der Passwortgenerierung#
            useLowerCase = checkBox_LowerCase.Checked;
            useUpperCase = checkBox_UpperCase.Checked;
            useNumbers = checkBox_Numbers.Checked;
            useSymbols = checkBox_Symbols.Checked;

            int counter = 10; // Passwortlänge (todo: kann individuell angepasst werden)

            // Erstellt ein neues StringBuilder-Objekt, um das Passwort zu speichern
            StringBuilder res = new StringBuilder();
            Random random = new Random(); // Erstellt ein Random-Objekt für zufällige Auswahlen

            // Liste der Zeichensätze und ihrer Verwendung, basierend auf den Checkbox-Einstellungen
            var charSets = new List<(string chars, bool use)>
            {
                ("abcdefghijklmnopqrstuvwxyz", useLowerCase),
                ("ABCDEFGHIJKLMNOPQRSTUVWXYZ", useUpperCase),
                ("1234567890", useNumbers),
                ("!§$%&/()=?-_,.:", useSymbols)
            };

            // Initialisiert eine leere Zeichenfolge, um alle erlaubten Zeichen zu speichern
            string allChars = "";

            // Kleine Verzögerung zur Verarbeitung der UI-Änderungen
            Application.DoEvents();
            // Verarbeitet alle Zeichensätze und fügt die erlaubten Zeichen hinzu
            foreach (var (chars, use) in charSets)
            {
                if (use) // Wenn die Checkbox aktiviert ist
                {
                    allChars += chars; // Fügt die Zeichen zur erlaubten Zeichenfolge hinzu
                    res.Append(chars[random.Next(chars.Length)]); // Fügt ein zufälliges Zeichen zum Ergebnis hinzu
                }
            }

            // Überprüft, ob keine der Checkboxen aktiviert ist
            if (string.IsNullOrEmpty(allChars))
            {
                // Zeigt eine Nachricht an, wenn keine Zeichenart ausgewählt wurde
                MessageBox.Show("Please select at least one charactertype!");
                return; // Beendet die Methode
            }

            // Füllt den Rest der Passwortlänge mit zufälligen Zeichen aus den erlaubten Zeichen auf
            for (int i = res.Length; i < counter; i++)
            {
                res.Append(allChars[random.Next(allChars.Length)]);
            }

            // Mischt das Ergebnis und setzt den Text des Passwortfeldes
            txtPass.Text = new string(res.ToString().OrderBy(c => random.Next()).ToArray());
        }

        // Event-Handler für Klicks auf den "Hide/Show Password"-Button
        private void btnHide_Show_Click(object sender, EventArgs e)
        {
            // Überprüft, ob das Passwort aktuell versteckt ist
            if (txtPass.UseSystemPasswordChar == true)
            {
                // Zeigt das Passwort an
                txtPass.UseSystemPasswordChar = false;
                btnHide_Show.Text = "Hide password"; // Ändert den Button-Text
            }
            else
            {
                // Versteckt das Passwort
                txtPass.UseSystemPasswordChar = true;
                btnHide_Show.Text = "Show password"; // Ändert den Button-Text
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

        // Event-Handler für Checkboxen
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            useLowerCase = checkBox_LowerCase.Checked; // Setzt den Zustand basierend auf der Checkbox
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

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPass.Text);
            MessageBox.Show("Copied :3");
        }
    }
}
