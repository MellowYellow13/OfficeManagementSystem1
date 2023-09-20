using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagementSystem.Models
{
    public class Attendees
    {
        public int ID { get; set; }
        public int EventsID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public Boolean PaymentStatus { get; set; }

        // Navigations Property
        public Events Events { get; set; }


    }
}
