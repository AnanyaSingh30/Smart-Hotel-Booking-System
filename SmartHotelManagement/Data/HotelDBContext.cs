using Microsoft.EntityFrameworkCore;
using SmartHotelManagement.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

public class HotelDBContext : DbContext
{
    public HotelDBContext(DbContextOptions<HotelDBContext> options): base(options){}

    // Define your tables as DbSet<T>
    public DbSet<Hotel> Hotels { get; set; }

    // Optional: Fluent API configuration
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //// Example: configure relationships, keys, etc.
        //modelBuilder.Entity<Student>()
        //    .HasKey(s => s.Id);

        //modelBuilder.Entity<Course>()
        //    .HasOne(c => c.Student)
        //    .WithMany(s => s.Courses)
        //    .HasForeignKey(c => c.StudentId);
    }
}
