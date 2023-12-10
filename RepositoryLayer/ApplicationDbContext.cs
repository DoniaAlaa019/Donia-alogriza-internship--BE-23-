using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Hour> Hours { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<DiscountTOPatient> DiscountTOPatients { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity => { });
            /*base.OnModelCreating(modelBuilder);*/
        }
    }
}
