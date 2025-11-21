using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Автосервіс
{
    internal class Worker
    {
        public int id { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public int vacations_count { get; set; }
        //кількість пропущених днів без поважної причини
        public int absences_count { get; set; }
    }
}
