using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DotNetCoreMySQL.Models
{
    public partial class waelContext : DbContext
    {
        public waelContext()
        {
        }

        public waelContext(DbContextOptions<waelContext> options)
            : base(options)
        {
        }

        // public virtual DbSet<ActiveStorageAttachment> ActiveStorageAttachments { get; set; } = null!;
        // public virtual DbSet<ActiveStorageBlob> ActiveStorageBlobs { get; set; } = null!;
        // public virtual DbSet<Address> Addresses { get; set; } = null!;
        // // public virtual DbSet<ArInternalMetadatum> ArInternalMetadata { get; set; } = null!;
        // public virtual DbSet<Battery> Batteries { get; set; } = null!;
        // public virtual DbSet<Building> Buildings { get; set; } = null!;
        // public virtual DbSet<BuildingDetail> BuildingDetails { get; set; } = null!;
        // public virtual DbSet<Column> Columns { get; set; } = null!;
        // public virtual DbSet<Customer> Customers { get; set; } = null!;
        // public virtual DbSet<Elevator> Elevators { get; set; } = null!;
        // public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Intervention> interventions { get; set; } = null!;
        // public virtual DbSet<Lead> Leads { get; set; } = null!;
        // public virtual DbSet<Quote> Quotes { get; set; } = null!;
        // // public virtual DbSet<SchemaMigration> SchemaMigrations { get; set; } = null!;
        // public virtual DbSet<User> Users { get; set; } = null!;

    }
}
