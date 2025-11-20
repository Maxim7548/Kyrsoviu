using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Автосервіс
{
    static class currentUser
    {
        public static string login { get; set; }
        public static bool isAdmin { get; set; }
        public static string Status => isAdmin ? "Адміністратор" : "Користувач";

    }
}
