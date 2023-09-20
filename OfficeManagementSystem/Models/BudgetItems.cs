using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagementSystem.Models
{
    public class BudgetItems
    {
        public int ID { get; set; }
        public int EventsID { get; set; }
        public string Decription { get; set; }
        public decimal Amount { get; set; }
        public int Type { get; set; }
        public DateTime Date { get; set; }

        // Navigations Property
        public Events Events { get; set; }
    }
}
