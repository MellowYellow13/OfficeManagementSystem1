using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagementSystem.Models
{
    public class Venues
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Capacity { get; set; }
        public bool CompanyOwned { get; set; }
        public Byte[] LayoutDiagram { get; set; }

        // Navigations Property
        public ICollection<Events> Events { get; }
    }
}
