using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFACodeFirstDevam_0.ModelContext.Entities
{
    public class Artist:CommonSpec
    {


        //Relational Properties
        public virtual List<MovieArtist> MovieArtists { get; set; }
    }
}
