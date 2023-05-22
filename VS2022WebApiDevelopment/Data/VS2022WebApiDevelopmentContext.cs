using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VS2022WebApiDevelopment;

namespace VS2022WebApiDevelopment.Data
{
    public class VS2022WebApiDevelopmentContext : DbContext
    {
        public VS2022WebApiDevelopmentContext (DbContextOptions<VS2022WebApiDevelopmentContext> options)
            : base(options)
        {
        }

        public DbSet<VS2022WebApiDevelopment.Contact> Contact { get; set; } = default!;
    }
}
