using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    public class PasswordEntry
    {
        public string Name { get; set; } // Název hesla (např. název účtu)
        public string Password { get; set; } // Samotné heslo
    }
}
