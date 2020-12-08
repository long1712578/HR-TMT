using System;
using System.Linq;
using HumanResource.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace HumanResource.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogRole> BlogRoles { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<ChildComment> ChildComments { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<DayWork> DayWorks { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Form> Forms  { get; set; }
        public DbSet<FormVersion> FormVersions { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<PositionHistory> PositionHistories { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<RequestApproval> RequestApprovals { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ShiftWork> ShiftWorks { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TimeSheet> TimeSheets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var valueComparer = new ValueComparer<string[]>(
                (c1, c2) => c1.SequenceEqual(c2),
                c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                c => c.ToArray());

            //modelBuilder.Entity<Employee>()
            //    .Property(e => e.Addresses)
            //    .HasConversion(address => string.Join(',', address), address => address.Split(',', StringSplitOptions.RemoveEmptyEntries))
            //    .Metadata.SetValueComparer(valueComparer);
            modelBuilder.Entity<BlogTag>()
                .HasKey(sc => new { sc.BlogId, sc.TagId });

            //modelBuilder.Entity<Employee>()
            //    .Property(e => e.PhoneNumbers)
            //    .HasConversion(phone => string.Join(',', phone), phone => phone.Split(',', StringSplitOptions.RemoveEmptyEntries))
            //    .Metadata.SetValueComparer(valueComparer);
            modelBuilder.Entity<Employee>()
                .Property(e => e.IsActive)
                .HasDefaultValue(true);
            //modelBuilder.Entity<Employee>()
            //    .Property(e => e.DateCreateNewPassword)
            //    .HasDefaultValue(null);
            modelBuilder.Entity<Blog>()
                .Property(e => e.CreateDate)
                .HasDefaultValue(DateTime.Now);
            modelBuilder.Entity<Blog>()
                .Property(e => e.Status)
                .HasDefaultValue(ApplicationCore.Enums.Status.Pendding);
            modelBuilder.Entity<TimeSheet>()
                .Property(e => e.IsActive)
                .HasDefaultValue(true);
            modelBuilder.Entity<ShiftWork>()
                .Property(e => e.IsActive)
                .HasDefaultValue(true);
            modelBuilder.Entity<Role>()
                .Property(e => e.IsActive)
                .HasDefaultValue(true);
            modelBuilder.Entity<Tag>()
                .Property(e => e.IsActive)
                .HasDefaultValue(true);
            modelBuilder.Entity<Comment>()
                .Property(e => e.IsActive)
                .HasDefaultValue(true);
            modelBuilder.Entity<ChildComment>()
                .Property(e => e.IsActive)
                .HasDefaultValue(true);
        }
    }
}