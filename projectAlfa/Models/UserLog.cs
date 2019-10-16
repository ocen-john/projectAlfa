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
        /**
        * This stores the actions performed on a give object. The client requires that the 
        * application be able to log actions made by HR on an applicants record.
        **/
        public String ActionPerformed {get; set;}
    }
}
