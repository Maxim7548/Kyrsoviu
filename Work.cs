using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Автосервіс
{
    internal class Work
    {
        public int id { get; set; }
        public string ServiceName { get; set; }
        public int Price { get; set; }

        public string ClientName { get; set; }

        public string CarModel { get; set; }

        public string CarNumber { get; set; }

        public string WorkerName { get; set; }

        public string StartDate { get; set; }
        public string FinishDate { get; set; }
    }
}
