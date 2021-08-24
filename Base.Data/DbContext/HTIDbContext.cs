using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Data.Models
{
    public class HTIDbContext: DbContext
    {
        public HTIDbContext()
        {
        }

        public HTIDbContext(DbContextOptions<HTIDbContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
