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
    }

    // Třída pro reprezentaci jednoho hesla
}
