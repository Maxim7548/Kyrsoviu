using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Автосервіс
{
    internal class WorkerInstrument
    {
        public int id { get; set; }
        public string InstrumentName { get; set; }
        public string WorkerName { get; set; }
        public string GiveDate { get; set; }
        public string ReturnDate { get; set; }
        public string Reason { get; set; }
    }
}
