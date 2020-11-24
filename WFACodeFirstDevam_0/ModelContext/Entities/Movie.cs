using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFACodeFirstDevam_0.ModelContext.Entities
{
    public class Movie:BaseEntity
    {
        public string Title { get; set; }
        public int? GenreID { get; set; }
        public int? DirectorID { get; set; }


        //Relational Properties

        public virtual Genre Genre { get; set; }
        public virtual Director Director { get; set; }

        public virtual List<MovieArtist> MovieArtists { get; set; }




    }
}
