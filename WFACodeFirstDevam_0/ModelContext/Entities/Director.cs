using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFACodeFirstDevam_0.ModelContext.Entities
{
    public class Director:CommonSpec
    {


        //Relational Properties

        public virtual List<Movie> Movies { get; set; }


    }
}
