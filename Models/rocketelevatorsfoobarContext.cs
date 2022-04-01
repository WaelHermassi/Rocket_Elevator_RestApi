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

        // public virtual DbSet<ActiveStorageAttachment> ActiveStorageAttachments { get; set; } = null!;
        // public virtual DbSet<ActiveStorageBlob> ActiveStorageBlobs { get; set; } = null!;
        public virtual DbSet<Address> addresses { get; set; } = null!;
        // public virtual DbSet<ArInternalMetadatum> ArInternalMetadata { get; set; } = null!;
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

// dotnet aspnet-codegenerator controller -name BatteryController -async -api -m Battery -dc rocketelevatorsfoobarContext -outDir Controllers

// dotnet aspnet-codegenerator controller -name BuildingController -async -api -m Building -dc rocketelevatorsfoobarContext -outDir Controllers

// dotnet aspnet-codegenerator controller -name ColumnController -async -api -m Column -dc rocketelevatorsfoobarContext -outDir Controllers

// dotnet aspnet-codegenerator controller -name ElevatorController -async -api -m Elevator -dc rocketelevatorsfoobarContext -outDir Controllers

// dotnet aspnet-codegenerator controller -name LeadController -async -api -m Lead -dc rocketelevatorsfoobarContext -outDir Controllers

// dotnet aspnet-codegenerator controller -name UserController -async -api -m User -dc rocketelevatorsfoobarContext -outDir Controllers

// dotnet aspnet-codegenerator controller -name CustomerController -async -api -m Customer -dc rocketelevatorsfoobarContext -outDir Controllers