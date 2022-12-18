using EFcoreRelationships.Models;
using Microsoft.EntityFrameworkCore;

namespace EFcoreRelationships.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<BandMember> BandMembers { get; set; }
        public DbSet<Band> Bands { get; set; }
    }
}
