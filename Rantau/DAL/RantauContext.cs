using Microsoft.EntityFrameworkCore;
using Rantau.Models;
using System;

namespace Rantau.DAL
{
    public class RantauContext : DbContext
    {
        private static bool IsDevelopment => Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";
        //private static string DefaultConnectionString = "UserID=postgres;Password=sa;Server=localhost;Port=5433;Database=RantauDB;IntegratedSecurity=true;Pooling=true;";
        private static string DefaultConnectionString = "User ID=vgcjowfmhxudge;Password=236886c0a5806b6df5b9d75e3b0dfc11e5b5bfa81d50a6368c5a5a8b0e429ea6;Host=ec2-44-196-146-152.compute-1.amazonaws.com;Port=5432;Database=dagr35cfvjo1pr;;Pooling=true;SSL Mode=Require;Trust Server Certificate=True;";

        public DbSet<Pasien> pasien { get; set; }
        public DbSet<InfoRekamMedis> infoRekamMedis { get; set; }
        public DbSet<TemplatPesan> templatPesan { get; set; }
        public DbSet<HistoriPesan> historiPesan { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(IsDevelopment ? DefaultConnectionString : GetHerokuConnectionString());

        private string GetHerokuConnectionString()
        {
            // Get the connection string from the ENV variables
            string connectionUrl = Environment.GetEnvironmentVariable("DATABASE_URL");

            // parse the connection string
            var databaseUri = new Uri(connectionUrl);

            string db = databaseUri.LocalPath.TrimStart('/');
            string[] userInfo = databaseUri.UserInfo.Split(':', StringSplitOptions.RemoveEmptyEntries);

            return $"User ID={userInfo[0]};Password={userInfo[1]};Host={databaseUri.Host};Port={databaseUri.Port};Database={db};Pooling=true;SSL Mode=Require;Trust Server Certificate=True;";
        }
    }
}
