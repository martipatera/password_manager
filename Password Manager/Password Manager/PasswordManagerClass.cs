using System;
using System.Text;
using System.Windows.Forms;

namespace Password_Manager
{
    public static class PasswordManagerClass
    {
        const string charsNums = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        const string charsNumsSym = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=+[]{}|;:,.<>?";
        private static string _currentPasswordName = "";
        private static string _currentPassword = "";
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
            _currentPasswordName = passwordName.Trim();
            _currentPassword = "";

            //string password = "";
            var random = new Random();

            for (int i = 0; i < passwordLength; i++)
            {
                int index = random.Next(passwordType.Length);
                _currentPassword += passwordType[index];
                //password += passwordType[index];
            }

            //return $"{passwordName.ToUpper()}: {password}";
            return _currentPassword;
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

            //PasswordStorage.AddPassword(passwordName.ToUpper(), result);


            PasswordTextBox.Text = result;
        }

        public static void SavePassword(TextBox passwordNameTextBox, TextBox passwordTextBox)
        {
            if (string.IsNullOrWhiteSpace(_currentPasswordName) )
            {
                MessageBox.Show("No password name to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (string.IsNullOrWhiteSpace(_currentPassword))
            {
                MessageBox.Show("No password to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PasswordStorage.AddPassword(_currentPasswordName.ToUpper(), _currentPassword);

            MessageBox.Show("Password saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _currentPasswordName = "";
            _currentPassword = "";
            passwordNameTextBox.Clear();
            passwordTextBox.Clear();
        }
    }

}
