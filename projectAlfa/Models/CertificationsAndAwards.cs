using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectAlfa.Models
{
    public class CertificationsAndAwards
    {
        public int Id { get; set; }
        public string CertificationName{ get; set; }
        public string CertifyingInstitutionName { get; set; }
        public DateTime CertificationDate { get; set; }
    }
}
