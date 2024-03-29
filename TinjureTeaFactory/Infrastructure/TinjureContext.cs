﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TinjureTeaFactory.Models;

namespace TinjureTeaFactory.Infrastructure
{
    public class TinjureContext : IdentityDbContext<AppUser>
    {
        public TinjureContext(DbContextOptions<TinjureContext> options)
            :base(options)
        {

        }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
