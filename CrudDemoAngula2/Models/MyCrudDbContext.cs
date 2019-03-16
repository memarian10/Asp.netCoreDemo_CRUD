using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudDemoAngula2.Models
{
    public class MyCrudDbContext:DbContext
    {
        public MyCrudDbContext(DbContextOptions<MyCrudDbContext>options):base(options)
        {

        }

        public DbSet<MyCategory> Categories { get; set; }

    }
}
