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
        private static string FilePath = "passwords.json"; // Cesta k JSON souboru
        private static List<PasswordEntry> _passwords = new List<PasswordEntry>();

        // Načtení hesel ze souboru
        public static void LoadFromFile()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                _passwords = JsonSerializer.Deserialize<List<PasswordEntry>>(json) ?? new List<PasswordEntry>();
            }
        }

        // Uložení hesel do souboru
        public static void SaveToFile()
        {
            string json = JsonSerializer.Serialize(_passwords, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        // Přidání hesla
        public static void AddPassword(string name, string password)
        {
            _passwords.Add(new PasswordEntry { Name = name, Password = password });
            SaveToFile(); // Automaticky uloží seznam do JSON
        }

        // Získání seznamu hesel
        public static List<PasswordEntry> GetPasswords()
        {
            return _passwords;
        }

        public static void DisplayPasswords(DataGridView PasswordGrid)
        {
            PasswordGrid.DataSource = null; // Vymaže aktuální data
            PasswordGrid.DataSource = PasswordStorage.GetPasswords(); // Načte data z PasswordStorage
        }

        // Smazání hesla
        public static void RemovePassword(string passwordName)
        {
            if (_passwords == null || !_passwords.Any())
            {
                MessageBox.Show("No passwords to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var passwordToRemove = _passwords.FirstOrDefault(p => p.Name.Equals(passwordName, StringComparison.OrdinalIgnoreCase));
            if (passwordToRemove != null)
            {
                _passwords.Remove(passwordToRemove);
                SaveToFile(); // Uloží změny do JSON
            }
            else
            {
                MessageBox.Show("Password not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void PasswordCheck(ref string _selectedPasswordName, ref string _selectedPassword, DataGridView PasswordGrid)
        {
            if (!string.IsNullOrEmpty(_selectedPasswordName)) // Zkontroluje, zda je heslo vybráno
            {
                // Odstraní heslo ze storage
                PasswordStorage.RemovePassword(_selectedPasswordName);

                // Aktualizuje DataGridView
                PasswordStorage.DisplayPasswords(PasswordGrid);

                MessageBox.Show($"Password {_selectedPasswordName} deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Vymaže výběr
                _selectedPasswordName = null;

            }
            else
            {
                MessageBox.Show("Please click on password to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void PasswordSelect(ref string _selectedPasswordName, ref string _selectedPassword, DataGridViewCellEventArgs e, DataGridView PasswordGrid)
        {
            if (e.RowIndex >= 0 ) // Ověří, že klik byl na platný řádek
            {
                // Získá řádek na základě indexu
                DataGridViewRow row = PasswordGrid.Rows[e.RowIndex];

                // Získá hodnotu sloupce "Name" (název hesla)
                _selectedPasswordName = row.Cells["Name"].Value?.ToString();

            }

            

            

            


        }

    }
    // Třída pro reprezentaci jednoho hesla
}
