using Automotivo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace AutomotivoFramework
{
    public class DbMap : DbContext
    {
        public DbMap() : base()
        {
            Initialize();
        }

        public DbMap(string connectionString) : base(connectionString)
        {
            Initialize();
        }

        public void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DbMap, Migrations.Configuration>());
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder mb)
        {
            base.OnModelCreating(mb);

            mb.HasDefaultSchema("dbo");
            mb.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
            mb.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.ColumnAttributeConvention>();

            mb.Entity<Log>().HasRequired(x => x.Tapete).WithMany(x => x.Logs).Map(y => y.MapKey("TapeteId"));
        }

        public DbSet<Tapete> Tapetes { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
