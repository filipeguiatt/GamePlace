using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GamePlace.Models;

namespace GamePlace.Data
{
    public class GamePlaceContext : DbContext
    {
        public GamePlaceContext (DbContextOptions<GamePlaceContext> options)
            : base(options)
        {
        }

        public DbSet<GamePlace.Models.UtilizadorRegistado> UtilizadorRegistado { get; set; }
    }
}
