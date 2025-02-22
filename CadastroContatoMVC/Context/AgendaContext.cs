﻿using System;
using CadastroContatoMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroContatoMVC.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) {}

        public DbSet<Contato> Contatos { get; set; }

    }
}
