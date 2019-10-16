using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectAlfa.Models
{
    public class EducationDetail
    {
        public int Id { get; set; }
        public string NameOfInstitution { get; set; }
        public string QualificationAttained { get; set; }
        public DateTime DateQualificationWasAttained { get; set; }

    }
}
