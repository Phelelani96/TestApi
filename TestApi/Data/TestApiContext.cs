﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestApi.Models;

namespace TestApi.Data
{
    public class TestApiContext : DbContext
    {
        public TestApiContext (DbContextOptions<TestApiContext> options)
            : base(options)
        {
        }

        public DbSet<TestApi.Models.Student> Student { get; set; } = default!;

        public DbSet<TestApi.Models.Module>? Module { get; set; }

        public DbSet<TestApi.Models.Enrollment>? Enrollment { get; set; }
    }
}
