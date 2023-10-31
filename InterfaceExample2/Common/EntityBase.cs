using InterfaceExample2.Abstract;
using InterfaceExample2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample2.Common
{
    public class EntityBase<TKey>: IModified
    {
        public TKey Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }
        public User ModifiedBy { get; set; }
    }
}
