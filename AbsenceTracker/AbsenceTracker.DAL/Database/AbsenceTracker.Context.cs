﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AbsenceTracker.DAL.Database
{
    using Common.IDatabaseModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class AbsenceTrackerEntities : DbContext, IAbsenceTrackerEntities
    {
        public AbsenceTrackerEntities()
            : base("name=AbsenceTrackerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Absence> Absences { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Compensation> Compensations { get; set; }
        public virtual DbSet<CompensationEntry> CompensationEntries { get; set; }
        public virtual DbSet<Sickness> Sicknesses { get; set; }
        public virtual DbSet<Vacation> Vacations { get; set; }

        public string ConnectionString
        {
            get
            {
                return this.Database.Connection.ConnectionString;
            }
            set
            {
                this.Database.Connection.ConnectionString = value;
            }
        }

        bool AutoDetachChangedEnabled
        {
            get
            {
                return true;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void ExecuteSqlCommand(string p, params object[] os)
        {
            this.Database.ExecuteSqlCommand(p, os);
        }

        public void ExecuteSqlCommand(string p)
        {
            this.Database.ExecuteSqlCommand(p);
        }

        bool IAbsenceTrackerEntities.AutoDetectChangedEnabled
        {
            get
            {
                return this.Configuration.AutoDetectChangesEnabled;
            }
            set
            {
                this.Configuration.AutoDetectChangesEnabled = value;
            }
        }
    }
}