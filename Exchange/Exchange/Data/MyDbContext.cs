using Exchange.Models;
using Microsoft.EntityFrameworkCore;

namespace Exchange.Data
{
    public class MyDbContext :DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext>options):base(options)
        {

        }
        public DbSet<Menjacnica> Menjacnica { get; set; }
    }
}
