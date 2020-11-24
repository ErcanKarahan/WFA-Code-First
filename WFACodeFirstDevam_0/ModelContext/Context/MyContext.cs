using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WFACodeFirstDevam_0.ModelContext.Entities;

namespace WFACodeFirstDevam_0.ModelContext.Context
{
    public class MyContext : DbContext
    {

        //Eger sizin calısan projeniz belli ise bir DbContext connection string isteyen constructor'a vereceginiz string argüman otomatik olarak Config dosyasına yazdıgınız ConnectionString'inizin ismi olur...


        public MyContext():base("MyConnection")
        {
           
         
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().ToTable("Oyuncular");
            modelBuilder.Entity<Movie>().ToTable("Filmler");
            modelBuilder.Entity<Director>().ToTable("Yonetmenler");
            modelBuilder.Entity<MovieArtist>().ToTable("FilmOyuncuları");
            modelBuilder.Entity<Genre>().ToTable("FilmTurleri");

            modelBuilder.Entity<Artist>().Property(x => x.FirstName).HasColumnName("Isim");

            modelBuilder.Entity<MovieArtist>().Ignore(x => x.ID);

            modelBuilder.Entity<MovieArtist>().HasKey(x => new
            {
                x.ArtistID,
                x.MovieID
            });

        }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Movie>  Movies { get; set; }

        public DbSet<Director> Directors { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<MovieArtist> MovieArtists { get; set; }


    }
}
