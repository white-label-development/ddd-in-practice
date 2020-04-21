using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ddd.Logic
{
    public abstract class Entity
    {
        public long Id { get; private set; }


        //eg: bool contains = entities.Contains(entity) // Contains will call our Equals override. The default .NET Equals gives us only reference equality.       
        public override bool Equals(object obj)
        {
            var other = obj as Entity;
            if (ReferenceEquals(other, null)) return false;

            if (ReferenceEquals(this, other)) return true; //reference equality

            if (GetType() != other.GetType()) return false;

            if (Id == 0 || other.Id == 0) return false; //identity not established

            return Id == other.Id; //identifier equality

        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b); //call our override
        }

        //eg: bool equal = entity1 == entity2
        public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

            return a.Equals(b); //call our override
        }

        public override int GetHashCode()
        {
            return (GetType().ToString() + Id).GetHashCode(); //objects that are equal to each other should always generate the same hashcode
        }
    }
}
