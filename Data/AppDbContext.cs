﻿using AgendaContatosMVC.Models;
using Microsoft.EntityFrameworkCore;


namespace AgendaContatosMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Contato> Contatos { get; set; }
    }
}
