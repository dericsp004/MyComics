using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyComics.Models.Marvel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyComics.Models
{
    public class ComicsContext : DbContext
    {
        private IConfigurationRoot appSettings;

        public ComicsContext(IConfigurationRoot appSettings, DbContextOptions options) : base(options)
        {
            this.appSettings = appSettings;
        }

        public DbSet<Series> Series { get; set; }
        public DbSet<Comics> Comics { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Stories> Stories { get; set; }
        public DbSet<Characters> Characters { get; set; }
        public DbSet<Creators> Creators { get; set; }
        //public DbSet<Summary> Summaries { get; set; }
        //public DbSet<Thumbnail> Thumbnail { get; set; }
        //public DbSet<Url> Urls { get; set; }






        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(appSettings["Data:ConnectionStrings:MyComicsDbConnectionDebug"]);
        }
    }
}
