﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library.EntityModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntitiesLib : DbContext
    {
        public EntitiesLib()
            : base("name=EntitiesLib")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<BookGenre> BookGenre { get; set; }
        public virtual DbSet<History> History { get; set; }
        public virtual DbSet<Rented> Rented { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
    }
}
