using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    public class Duck
    {
        public string Name { get; }
        public string Type { get; }
        public int WeightInGrams { get; }
        public int AgeInMonths { get; }

        public Duck(string name, string type, int weightInGrams, int ageInMonths)
        {
            Name = name;
            Type = type;
            WeightInGrams = weightInGrams;
            AgeInMonths = ageInMonths;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Duck)obj);
        }

        public bool Equals(Duck other)
        {
            return Name == other.Name && Type==other.Type && WeightInGrams ==other.WeightInGrams && AgeInMonths == other.AgeInMonths;
        }

        public override int GetHashCode()
        {
            var hash = Name.GetHashCode();
            hash = (hash * 31) + Type.GetHashCode();
            hash = (hash * 31) + WeightInGrams;
            hash = (hash * 31) + AgeInMonths;
            return hash;
        }

        public static bool operator ==(Duck left, Duck right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Duck left, Duck right)
        {
            return !Equals(left, right);
        }

        public override string ToString()
        {
            return Name + " is a " + Type + " duck, is " + AgeInMonths + " months old and weighs " + WeightInGrams + " grams.";
        }

        public static bool operator >(Duck left, Duck right)
        {
            var comparer = new WeightRelationalComparer();
            if (comparer.Compare(left, right) > 0)
            {
                return true;
            }
            return false;
        }

        public static bool operator <(Duck left, Duck right)
        {
            var comparer = new WeightRelationalComparer();
            if (comparer.Compare(left, right) < 0)
            {
                return true;
            }
            return false;
        }
    }

}
