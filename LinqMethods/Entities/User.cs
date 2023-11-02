using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMethods.Entities
{
    public class User
    {
        public string UserName { get; set; }
        public int FollowerCount { get; set; }

        public User(string userName, int followerCount)
        {
            UserName = userName;
            FollowerCount = followerCount;
        }
    }
}
