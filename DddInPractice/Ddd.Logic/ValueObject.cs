using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ddd.Logic
{
    public abstract class ValueObject<T> where T : ValueObject<T>
    {
        public override bool Equals(object obj)
        {
            var valueObject = obj as T;

            if (ReferenceEquals(valueObject, null)) return false;
            return EqualsCore(valueObject); //abstract the work to this method
        }

        protected abstract bool EqualsCore(T other); //to implement in derived class as equality members will be different (Entities can always use Id)

        public override int GetHashCode()
        {
            return GetHashCodeCore(); //abstract the work to this method
        }

        protected abstract int GetHashCodeCore(); //to implement in derived class

        public static bool operator !=(ValueObject<T> a, ValueObject<T> b)
        {
            return !(a == b); //call our override
        }

        //eg: bool equal = entity1 == entity2
        public static bool operator ==(ValueObject<T> a, ValueObject<T> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

            return a.Equals(b); //call our override
        }

    }
}
