using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RebecaBarrezueta_APIBurger.Data.Models;

namespace RebecaBarrezueta_APIBurger.Data
{
    public class RebecaBarrezueta_APIBurgerContext : DbContext
    {
        public RebecaBarrezueta_APIBurgerContext (DbContextOptions<RebecaBarrezueta_APIBurgerContext> options)
            : base(options)
        {
        }

        public DbSet<RebecaBarrezueta_APIBurger.Data.Models.Burguer> Burguer { get; set; } = default!;
    }
}
