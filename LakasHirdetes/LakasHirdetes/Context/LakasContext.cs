using LakasHirdetes.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace LakasHirdetes.Context
{
    public class LakasContext :DbContext
    {
        public DbSet<Kiado> Kiadok { get; set; }
        public DbSet<Lakas> Lakasok { get; set; }

        public LakasContext(DbContextOptions<LakasContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
