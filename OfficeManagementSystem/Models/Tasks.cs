using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagementSystem.Models
{
    public class Tasks
    {
        public int ID { get; set; }
        public int EventsID { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int Priority { get; set; } // Change to a byte?
        public int Status { get; set; } // Change to a byte? 

        // Navigations Property
        public Events Events { get; set; }
    }
}
