using FluentNHibernate.Mapping;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate.Mapping
{
    public class UserMapping:ClassMap<User>
    {
        public UserMapping()
        {
            Table("tblUser");
            Id(u => u.TabloID).GeneratedBy.Identity();
            Map(u => u.FirstName).Not.Nullable();
            Map(u => u.LastName).Not.Nullable();
            Map(u => u.Age).Not.Nullable();
            Map(u => u.RegisterDate).Not.Nullable();
        }


    }
}
