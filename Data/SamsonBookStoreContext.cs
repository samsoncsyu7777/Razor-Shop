using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SamsonBookStore.Models;

namespace SamsonBookStore.Data
{
    public class SamsonBookStoreContext : DbContext
    {
        public SamsonBookStoreContext (DbContextOptions<SamsonBookStoreContext> options)
            : base(options)
        {
        }

        public DbSet<SamsonBookStore.Models.Book> Book { get; set; }
    }
}
