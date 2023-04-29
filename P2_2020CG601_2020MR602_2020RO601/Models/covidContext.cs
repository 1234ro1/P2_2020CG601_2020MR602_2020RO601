using Microsoft.EntityFrameworkCore;
using P2_2020CG601_2020MR602_2020RO601.Models;
namespace P2_2020CG601_2020MR602_2020RO601.Models
{
    public class covidContext : DbContext
    {
        public covidContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<CasosReportados> CasosReportados { get; set; }
        public DbSet<Departamentos> Departamentos { get; set; }
        public DbSet<Generos> Generos { get; set; }


    }
}
