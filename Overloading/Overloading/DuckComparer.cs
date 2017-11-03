using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class WeightRelationalComparer : Comparer<Duck>
    {
        public override int Compare(Duck x, Duck y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (ReferenceEquals(null, y)) return 1;
            if (ReferenceEquals(null, x)) return -1;
            return x.WeightInGrams.CompareTo(y.WeightInGrams);
        }
    }
}
