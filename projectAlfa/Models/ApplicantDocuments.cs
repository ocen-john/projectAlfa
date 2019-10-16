using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectAlfa.Models
{
    public class ApplicantDocuments
    {
        public int Id { get; set; }
        public string CertificationAwardName { get; set; }
        public string InstitutionName { get; set; }
        public DateTime DateOfCertification { get; set; }
    }
}
