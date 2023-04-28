using Microsoft.EntityFrameworkCore;
using FinalCrudWithApi.Model;

namespace FinalCrudWithApi
{
    public class MyAppDbContextcs : DbContext
    {
        public MyAppDbContextcs(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> test_employees { get; set; }
    }
}
