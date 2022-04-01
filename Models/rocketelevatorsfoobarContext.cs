using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using DotNetCoreMySQL.Models;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DotNetCoreMySQL.Models
{
    public partial class rocketelevatorsfoobarContext : DbContext
    {
        public rocketelevatorsfoobarContext()
        {
        }

        public rocketelevatorsfoobarContext(DbContextOptions<rocketelevatorsfoobarContext> options):
            base(options)
        {
        }
        public virtual DbSet<Address> addresses { get; set; } = null!;
        public virtual DbSet<Battery> batteries { get; set; } = null!;
        public virtual DbSet<Building> buildings { get; set; } = null!;
        public virtual DbSet<BuildingDetail> buildingDetails { get; set; } = null!;
        public virtual DbSet<Column> columns { get; set; } = null!;
        public virtual DbSet<Customer> customers { get; set; } = null!;
        public virtual DbSet<Elevator> elevators { get; set; } = null!;
        public virtual DbSet<Employee> employees { get; set; } = null!;
        public virtual DbSet<Lead> leads { get; set; } = null!;
        public virtual DbSet<Quote> quotes { get; set; } = null!;
        // public virtual DbSet<SchemaMigration> SchemaMigrations { get; set; } = null!;
        public virtual DbSet<User> users { get; set; } = null!;

        }
}