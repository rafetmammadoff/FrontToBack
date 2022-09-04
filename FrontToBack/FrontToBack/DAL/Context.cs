using FrontToBack.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> opt):base(opt)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
