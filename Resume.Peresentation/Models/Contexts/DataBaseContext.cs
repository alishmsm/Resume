using Microsoft.EntityFrameworkCore;
using Resume.Peresentation.Models.Entities.Education;
using Resume.Peresentation.Models.Entities.Experience;
using Resume.Peresentation.Models.Entities.MySkills;

namespace Resume.Peresentation.Models.Contexts;

public class DataBaseContext : DbContext
{

    public DbSet<Education> Educations { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<MySkills> mysKills { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-6P4U7CC; Initial Catalog=_Resume; Integrated Security=True;TrustServerCertificate=true");
    }
}