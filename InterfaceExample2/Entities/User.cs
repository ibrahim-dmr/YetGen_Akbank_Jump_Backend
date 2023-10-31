using InterfaceExample2.Common;
using InterfaceExample2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample2.Entities
{
    public class User : EntityBase<Guid>
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public MembershipType Membership { get; set; }
        public DateTime Birthday { get; set; }

    }
}
