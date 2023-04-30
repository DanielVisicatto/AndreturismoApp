using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AndreTurismoApp.Models;

namespace AndreturismoApp.Data
{
    public class AndreturismoAppContext : DbContext
    {
        public AndreturismoAppContext (DbContextOptions<AndreturismoAppContext> options)
            : base(options)
        {
        }

        public DbSet<AndreTurismoApp.Models.Address> Address { get; set; } = default!;
    }
}
