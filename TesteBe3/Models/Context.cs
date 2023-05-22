using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TesteBe3.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {


        }
        public DbSet<Register> Registers { get; set; }

    }
}
