using FreelancerApp.Abstract;
using FreelancerApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerApp.Entities
{
    public class Freelancer: Person<Guid>, ICsvConvertible
    {

        public string WorkExperience { get; set; }
        public List<Review> Reviews{ get; set; }

        //Karşılaştırma yaparken float problem çıkarır double veya decimal kullanılmalı.


        public string GetValuesCSV()
        {
            return $"{Id},{CreatedOn},{FirstName},{LastName},{WorkExperience}";
        }

        public void SetValuesCSV(string csv)
        {
            string[] data = csv.Split(',');
            Id = Guid.Parse(data[0]);
            CreatedOn = DateTimeOffset.Parse(data[1]);
            FirstName = data[2];
            LastName = data[3];
            WorkExperience = data[4];
        }
    }
}
