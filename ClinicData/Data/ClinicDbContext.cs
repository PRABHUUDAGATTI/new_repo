﻿using ClinicEntity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ClinicData.Data
{
    public class ClinicDbContext:DbContext
    {
        public ClinicDbContext()
        {

        }
        public ClinicDbContext(DbContextOptions<ClinicDbContext> options) : base(options)
        {

        }

        public DbSet<Patient> patients { get; set; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<OtherStaff> otherStaffs { get; set; }
        public DbSet<Pending_Feedback> pending_feedbacks { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Appointment> appointments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=VDC01LTC2125;Initial Catalog=ClinicMngt; Integrated Security=true;");
        }

    }
}
