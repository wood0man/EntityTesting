using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entity.Models;

namespace EntityTesting.Data
{
    public class EntityTestingContext : DbContext
    {
        public EntityTestingContext (DbContextOptions<EntityTestingContext> options)
            : base(options)
        {
        }

        public DbSet<Entity.Models.book> book { get; set; } = default!;
    }
}
