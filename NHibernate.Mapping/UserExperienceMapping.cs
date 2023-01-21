using FluentNHibernate.Mapping;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate.Mapping
{
    public class UserExperienceMapping:ClassMap<UserExperience>
    {

        public UserExperienceMapping()
        {
            Table("tblUserExperience");
            Id(u => u.TabloID).GeneratedBy.Identity();
            Map(u => u.Description);
            Map(u => u.CountExperience).Not.Nullable();
            Map(u => u.UserID);
            Map(u => u.RegisterDate);
        }
    }
}
