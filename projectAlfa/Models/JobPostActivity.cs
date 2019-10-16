using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectAlfa.Models
{
    public class JobPostActivity
    {
        public int Id { get; set; }
        public int JobPostId { get; set; }
        public string UserAccountId{ get; set; }
        public DateTime ApplyDate{ get; set; }
        
    }
}
