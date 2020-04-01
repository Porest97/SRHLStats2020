using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SRHLStats2020.Models.DataModels;

namespace SRHLStats2020.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SRHLStats2020.Models.DataModels.Arena> Arena { get; set; }
        public DbSet<SRHLStats2020.Models.DataModels.Club> Club { get; set; }
        public DbSet<SRHLStats2020.Models.DataModels.Match> Match { get; set; }
        public DbSet<SRHLStats2020.Models.DataModels.MatchCategory> MatchCategory { get; set; }
        public DbSet<SRHLStats2020.Models.DataModels.MatchStatus> MatchStatus { get; set; }
        public DbSet<SRHLStats2020.Models.DataModels.MatchType> MatchType { get; set; }
        public DbSet<SRHLStats2020.Models.DataModels.Person> Person { get; set; }
        public DbSet<SRHLStats2020.Models.DataModels.Series> Series { get; set; }
        public DbSet<SRHLStats2020.Models.DataModels.Team> Team { get; set; }
    }
}
