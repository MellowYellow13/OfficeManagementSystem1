using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagementSystem.Models
{
    public class Events
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int CategoryID { get; set; }
        public EventCategories EventCategories
        { get; set; }

        public int VenueID { get; set; }
        public Venues Venues
        { get; set; }

        public ICollection<Attendees> Attendees { get; }

        public ICollection<Tasks> Tasks { get; }

        public ICollection<Contacts> Contacts { get; }

        public ICollection<Resources> Resources { get; }

        public ICollection<BudgetItems> BudgetItems { get; }


    }
}
