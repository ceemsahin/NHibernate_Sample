using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UserExperience
    {
        public virtual int TabloID { get; set; } 
        public virtual int UserID { get; set; }
        public virtual string Description { get; set; }
        public virtual int CountExperience { get; set; }
        public virtual DateTime RegisterDate { get; set; }

    }
}
