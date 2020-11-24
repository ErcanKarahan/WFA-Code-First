using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFACodeFirstDevam_0.ModelContext.Entities
{
    public abstract class CommonSpec:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}
