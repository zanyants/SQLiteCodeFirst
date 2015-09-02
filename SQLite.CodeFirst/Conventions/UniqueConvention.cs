using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using SQLite.CodeFirst.Attributes;

namespace SQLite.CodeFirst.Conventions
{
    internal class UniqueConvention : IStoreModelConvention<Edm>
    {
        public const string UniqueAnnotationName = "IsUnique";

        //public UniqueConvention()
        //{
        //    Properties()
        //        .Where(p => p.GetCustomAttribute(typeof(UniqueAttribute)) != null)
        //        .Configure(a => a.ClrPropertyInfo.);
        //}


        public void Apply(EdmProperty item, DbModel model)
        {
            item.AddAnnotation(UniqueAnnotationName, true);
        }
    }
}
