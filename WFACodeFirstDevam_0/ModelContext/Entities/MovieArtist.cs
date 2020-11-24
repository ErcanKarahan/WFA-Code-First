using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFACodeFirstDevam_0.ModelContext.Entities
{
    public class MovieArtist : BaseEntity
    {
        public int MovieID { get; set; }
        public int ArtistID { get; set; }

        //Relational Properties

        public virtual Artist Artist { get; set; }
        public virtual Movie Movie { get; set; }


    }
}
