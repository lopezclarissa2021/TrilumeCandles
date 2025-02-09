using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrilumeCandles.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using TrilumeCandles.Areas.Identity.Data;

namespace TrilumeCandles.Data
{
    public class TrilumeCandlesContext: IdentityDbContext<TrilumeCandlesUser>
    {
        public TrilumeCandlesContext(DbContextOptions<TrilumeCandlesContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
