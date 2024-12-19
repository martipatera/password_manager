using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Password_Manager
{
    public static class PasswordStorage
    {
        private static string FilePath = "passwords.json";

        // list pro ukladani hesel
        private static List<PasswordEntry> _passwords = new List<PasswordEntry>();

        public static void LoadFromFile()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);

                // deserializace na .NET objekt
                _passwords = JsonSerializer.Deserialize<List<PasswordEntry>>(json) ?? new List<PasswordEntry>(); // ?? jestli je null udelej new LIST
            }
        }

        public static void SaveToFile()
        {
            // serializace .NET objektu do JSON
            string json = JsonSerializer.Serialize(_passwords);
            File.WriteAllText(FilePath, json);
        }

        public static void AddPassword(string name, string password)
        {
            _passwords.Add(new PasswordEntry { Name = name, Password = password });
            SaveToFile();
        }

        public static List<PasswordEntry> GetPasswords()
        {
            //vraci LIST ktery obsahuje vsechna hesla
            return _passwords;
        }

        public static void DisplayPasswords(DataGridView PasswordGrid)
        {
            // odstrani predchozi data
            PasswordGrid.DataSource = null;
            // nastavim grid data na data z met. GetPasswords()
            PasswordGrid.DataSource = PasswordStorage.GetPasswords();
        }

        //kontrola hesla a remove
        public static void CheckPassword(string selectedPassword)
        {
            // null NEBO prazdny
            if (_passwords == null || !_passwords.Any())
            {
                MessageBox.Show("No passwords to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // FirstOrDefault hleda prvni objekt ktery, jehoz nazev NEBO heslo se shoduje p => p (promenna)
            var passwordToRemove = _passwords.FirstOrDefault(p => p.Name.Equals(selectedPassword) || p.Password.Equals(selectedPassword, StringComparison.OrdinalIgnoreCase));

            if (passwordToRemove != null)
            {
                _passwords.Remove(passwordToRemove); //removne prvni objekt co se bude shodovat
                SaveToFile(); 
            }
            else
            {
                MessageBox.Show("Password not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //odstraneni hesla tlacitko
        public static void PasswordDelete( ref string _selectedPassword, DataGridView PasswordGrid)
        {
            if (!string.IsNullOrEmpty(_selectedPassword))
            {
                PasswordStorage.CheckPassword(_selectedPassword); //poslu jmeno hesla a removnu ho

                PasswordStorage.DisplayPasswords(PasswordGrid); // updatuju hesla

                MessageBox.Show($"Password {_selectedPassword} deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _selectedPassword = null; //resetuju vyber v hlavni tride pomoci ref
            }
            else
            {
                MessageBox.Show("Please click on password to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //zjisteni na ktere heslo klikam

        public static void PasswordSelect(ref string _selectedPassword, DataGridViewCellEventArgs e, DataGridView PasswordGrid)
        {
            // kliknuti na radek
            if (e.RowIndex >= 0)
            {
                // ten kliknuty radek
                DataGridViewRow row = PasswordGrid.Rows[e.RowIndex];

                // sloupec Name nebo Password
                if (PasswordGrid.Columns[e.ColumnIndex].Name == "Name")
                {
                    // do promenne ulozime data z bunky Name
                    _selectedPassword = row.Cells["Name"].Value?.ToString();  // ?  = pokud neni null
                }
                else if (PasswordGrid.Columns[e.ColumnIndex].Name == "Password")
                {
                    // do promenne ulozime data z bunky Password
                    _selectedPassword = row.Cells["Password"].Value?.ToString(); // ?  = pokud neni null
                }
                
            }
        }


    }


}
