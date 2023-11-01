using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerApp.Abstract
{
    public interface ICsvConvertible
    {
        string GetValuesCSV();

        void SetValuesCSV(string csv);
    }
}
