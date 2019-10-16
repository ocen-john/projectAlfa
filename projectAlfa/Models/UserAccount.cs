using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectAlfa.Models
{
    public class UserAccount
    {
        public int Id { get; set; }
        public int userTypeId { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string gender { get; set; }
        public string isActive { get; set; }
        public string phoneNumber { get; set; }
        public string alternativePhoneNumber { get; set; }
        public string registerationDate { get; set; }

    }
}
