using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GG_Examen.Models;

namespace GG_Examen.Data
{
    public class GG_ExamenContext : DbContext
    {
        public GG_ExamenContext (DbContextOptions<GG_ExamenContext> options)
            : base(options)
        {
        }

        public DbSet<GG_Examen.Models.GGuevara> GGuevara { get; set; } = default!;
    }
}
