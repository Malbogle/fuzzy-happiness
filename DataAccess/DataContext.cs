﻿using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<User> Users { get; set; }

    }
}
