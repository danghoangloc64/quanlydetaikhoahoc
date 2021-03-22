using QuanLyDeTaiKhoaHoc.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace QuanLyDeTaiKhoaHoc.DAL
{
    public class QuanLyDeTaiKhoaHocContext : DbContext
    {
        public QuanLyDeTaiKhoaHocContext() : base("QuanLyDeTaiKhoaHocConnectionString")
        {
            Database.CommandTimeout = int.MaxValue;
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<QuyenAccount> QuyenAccounts { get; set; }
        public DbSet<ChuNhiem> ChuNhiems { get; set; }


        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries();
            List<DbEntityEntry> modifiedEntries = new List<DbEntityEntry>();

            //Get entries add or update to database
            foreach (var entry in entries)
            {
                if (entry.Entity is IAuditableEntity && entry.State == EntityState.Added || entry.State == EntityState.Modified)
                {
                    modifiedEntries.Add(entry);
                }
            }

            //Set CreatedBy, CreatedDate, UpdatedBy, UpdatedDate for IAuditableEntity

            foreach (var entry in modifiedEntries)
            {
                IAuditableEntity entity = entry.Entity as IAuditableEntity;
                if (entity != null)
                {
                    DateTime now = DateTime.Now;

                    if (entry.State == EntityState.Added)
                    {
                        entity.CreatedBy = ""/*SystemConfiguration.UserName*/;
                        entity.CreatedDate = now;
                    }
                    else
                    {
                        base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                        base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                    }

                    entity.UpdatedBy = "";//SystemConfiguration.UserName;
                    entity.UpdatedDate = now;
                }
            }

            return base.SaveChanges();
        }
    }
}
