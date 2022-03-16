using Microsoft.EntityFrameworkCore;
namespace cSharp2022.Models
{
    // the MyContext class representing a session with our MySQL 
    // database allowing us to query for or save data
    public class MuhContext : DbContext
    {
        public MuhContext(DbContextOptions options) : base(options) { }
        // the "Monsters" table name will come from the DbSet variable name
        public DbSet<Recordis> Recs { get; set; } //this will be actual SQL table's name!


        public DbSet<Gear> Gears { get; set; }
        public DbSet<Connect> Connects { get; set; }
        public DbSet<Image> Images { get; set; } //this will be actual SQL table's name!
        public DbSet<Comment> Comments { get; set; } //this will be actual SQL table's name!
        public DbSet<Album> Albums { get; set; } //this will be actual SQL table's name!
        public DbSet<Aversion> Aversions { get; set; }

    }
}

