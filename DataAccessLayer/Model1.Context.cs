﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OrganizationDbEntities : DbContext
    {
        public OrganizationDbEntities()
            : base("name=OrganizationDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Image> Image { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }
        public virtual DbSet<OrganizationComment> OrganizationComment { get; set; }
        public virtual DbSet<OrganizationImage> OrganizationImage { get; set; }
        public virtual DbSet<OrganizationParticipant> OrganizationParticipant { get; set; }
        public virtual DbSet<Participant> Participant { get; set; }
    }
}