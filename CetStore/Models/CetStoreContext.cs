using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CetStore.Models;

namespace CetStore.Models
{
    public class CetStoreContext : DbContext
    {
        public CetStoreContext(DbContextOptions<CetStoreContext> options):base(options)
        {

        }
       public DbSet<Book> Books { get; set; }
       public DbSet<CetStore.Models.Category> Category { get; set; }
    }
}
