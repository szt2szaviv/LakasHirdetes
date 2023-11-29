using Microsoft.EntityFrameworkCore;

namespace LakasHirdetes.Context
{
    public class LakasInMemoryContext : LakasContext
    {
        public LakasInMemoryContext(DbContextOptions<LakasContext> options) : base(options)
        {

        }
    }
}
