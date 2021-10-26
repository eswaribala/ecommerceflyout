using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ecommerceflyout.Models
{
    public class Member
    {
        [PrimaryKey, AutoIncrement]
        public long MembershipNo { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        public long MobileNo { get; set; }
        
        public DateTime DOB { get; set; }

        public string Password { get; set; }

    }
}
