using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetStore.Models
{
    public class CetStoreContext : DbContext
    {
        public CetStoreContext(DbContextOptions<CetStoreContext> options):base(options)
        {

        }
       public DbSet<Book> Books { get; set; }
    }
}
