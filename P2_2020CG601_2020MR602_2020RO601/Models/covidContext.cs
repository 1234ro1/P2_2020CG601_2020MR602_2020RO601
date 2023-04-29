using Microsoft.EntityFrameworkCore;
using P2_2020CG601_2020MR602_2020RO601.Models;
namespace P2_2020CG601_2020MR602_2020RO601.Models
{
    public class covidContext : DbContext
    {
        public covidContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<P2_2020CG601_2020MR602_2020RO601.Models.Departamentos>? Departamentos { get; set; }
        public DbSet<P2_2020CG601_2020MR602_2020RO601.Models.Generos>? Generos { get; set; }
    }
}
