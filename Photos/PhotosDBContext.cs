using Microsoft.EntityFrameworkCore;
using Photos.Modeles;

namespace Photos;

public partial class PhotosDbContext : DbContext
{
    public PhotosDbContext()
    {
    }

    public PhotosDbContext(DbContextOptions<PhotosDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Evenement> Evenements { get; set; }
    public virtual DbSet<Jour> Jours { get; set; }
    public virtual DbSet<Photo> Photos { get; set; }
    public virtual DbSet<Param> Params { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(Properties.Settings.Default.PhotosOrganiserDBConnectionString);
}
