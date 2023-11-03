using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMethodsExcercises.Entities
{
    public class ProductEqualityComparer : IEqualityComparer<Product>
    {
        public bool Equals(Product x, Product y)
        {
            if (x == null && y == null)
                return true;
            if (x == null || y == null)
                return false;
            return x.Name == y.Name && x.Price == y.Price;
        }

        public int GetHashCode(Product obj)
        {
            return (obj.Name + obj.Price).GetHashCode();
        }
    }
}
