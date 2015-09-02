using System;

namespace SQLite.CodeFirst.Attributes
{
    public class UniqueAttribute : Attribute
    {
        public bool IsUnique { get; private set; }

        public UniqueAttribute()
        {
            IsUnique = true;
        }

        public UniqueAttribute(bool isUnique)
        {
            IsUnique = isUnique;
        }
    }
}
