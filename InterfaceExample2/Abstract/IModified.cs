using InterfaceExample2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterfaceExample2.Abstract
{
    public interface IModified
    {
        DateTime ModifiedOn { get; set; }
        User ModifiedBy { get; set; } 
    }
}
