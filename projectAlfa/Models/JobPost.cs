using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectAlfa.Models
{
    public class JobPost
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string DutiesAndResponsibilities { get; set; }
        public string DutyStation { get; set; }
        public DateTime DeadlineDate { get; set; }
    }
}
