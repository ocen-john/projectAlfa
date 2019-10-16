using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectAlfa.Models
{
    public class ApplicantBioData
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Residence { get; set; }
        public string PrimaryPhoneNumber{ get; set; }
        public string AlternativePhoneNumber { get; set; }
        public string LanguagesSpoken { get; set; }
        public string WorkedWithIDRC { get; set; }
    }
}
