using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Use this with the brackets like [Key]
//System.ComponentModel.DataAnnotations;

namespace OfficeManagementSystem.Models
{
    public class Contacts
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Organization { get; set; }

        // Navigations Property
        public ICollection<Events> Events { get; }
    }
}
