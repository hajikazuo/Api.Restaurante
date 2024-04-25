using Api.Restaurante.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Api.Restaurante.Context
{
    public class RestauranteContext : DbContext
    {
        public RestauranteContext(DbContextOptions<RestauranteContext> options) : base(options)
        {
        }

        public DbSet<Prato>? Pratos { get; set; }
    }
}
