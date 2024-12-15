using System;
using System.Text;
using System.Windows.Forms;

namespace Password_Manager
{
    public static class PasswordManagerClass
    {
        const string charsNums = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        const string charsNumsSym = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=+[]{}|;:,.<>?";

        public static bool PasswordNameCheck(TextBox PasswordNameTextBox)
        {
            if (string.IsNullOrWhiteSpace(PasswordNameTextBox.Text))
            {
                MessageBox.Show("Must enter a password name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static string GeneratePassword(string passwordType, int passwordLength, string passwordName)
        {
            string password = "";
            var random = new Random();

            for (int i = 0; i < passwordLength; i++)
            {
                int index = random.Next(passwordType.Length);
                password += passwordType[index];
            }

            return $"{passwordName.ToUpper()}: {password}";
        }

        public static void PasswordManager(RadioButton CharsNumsRadBtn, RadioButton CharsNumsSymRadBtn, NumericUpDown PasswordLengthBtn, TextBox PasswordTextBox, TextBox PasswordNameTextBox)
        {

            //
            // RadioBtn Check
            //
            if (!PasswordNameCheck(PasswordNameTextBox))
            {
                return;
            }

            string passwordType = "";

            if (CharsNumsRadBtn.Checked)
            {
                passwordType = charsNums;
            }
            else if (CharsNumsSymRadBtn.Checked)
            {
                passwordType = charsNumsSym;
            }
            else
            {
                MessageBox.Show("Must select a password type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //
            // Generace hesla
            //

            string passwordName = PasswordNameTextBox.Text.Trim();

            string result = GeneratePassword(passwordType, (int)PasswordLengthBtn.Value, passwordName);

            PasswordTextBox.Text = result;
        }
    }
}
