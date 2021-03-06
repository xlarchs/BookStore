﻿using Entities.Concrete;
using Entities.Concrete.Authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class BookStoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Database=kutuphanedb;Uid=root;Pwd=12345;");
        }

        public DbSet<Book> Books { get; set; }
    }   
}