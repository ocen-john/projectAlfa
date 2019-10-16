using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectAlfa.Models
{
    public class EmploymentHistory
    {
        public int Id { get; set; }
        public string EmployerName { get; set; }
        public DateTime EmploymentStartDate { get; set; }
        public DateTime EmploymentEndDate { get; set; }
        public string JobTitle { get; set; }
        public string SummaryOfDuties { get; set; }
        public string SummaryOfAchievments { get; set; }
    }
}
