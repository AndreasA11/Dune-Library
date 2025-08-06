using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DuneLibrary.Models;

namespace DuneLibrary.Data
{
    public class DuneLibraryContext : DbContext
    {
        public DuneLibraryContext (DbContextOptions<DuneLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<DuneLibrary.Models.Passage> Passage { get; set; } = default!;
    }
}
