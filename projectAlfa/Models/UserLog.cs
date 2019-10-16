using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectAlfa.Models
{
    public class UserLog
    {
        public int UserAccountId { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime LastJobApplyDate { get; set; }
    }
}
