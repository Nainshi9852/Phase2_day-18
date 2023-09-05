using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_API.Models;

namespace CRUD_API.Data
{
    public class CRUD_APIDbContext : DbContext
    {
        public CRUD_APIDbContext (DbContextOptions<CRUD_APIDbContext> options)
            : base(options)
        {
        }

        public DbSet<CRUD_API.Models.Movie> Movie { get; set; } = default!;
    }
}
