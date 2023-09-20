using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagementSystem.Models
{
    public class Users
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        // Hashcode is not a supported primitive type or a valid entity type. HashCode changed to byte[]
        public byte[] Password { get; set; }
        public string Role { get; set; }
    }
}
