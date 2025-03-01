using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MTS.Models;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Trainer> Trainers { get; set; }
    public DbSet<Task> Tasks { get; set; }
    public DbSet<Submission> Submissions { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }
    public DbSet<Report> Reports { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure relationships
        modelBuilder.Entity<Task>()
            .HasOne(t => t.Trainer)
            .WithMany()
            .HasForeignKey(t => t.TrainerId);

        modelBuilder.Entity<Submission>()
            .HasOne(s => s.Student)
            .WithMany()
            .HasForeignKey(s => s.StudentId);

        modelBuilder.Entity<Submission>()
            .HasOne(s => s.Task)
            .WithMany()
            .HasForeignKey(s => s.TaskId);

        modelBuilder.Entity<Feedback>()
            .HasOne(f => f.Submission)
            .WithMany()
            .HasForeignKey(f => f.SubmissionId);

        // Configure the primary key for the Report entity
        modelBuilder.Entity<Report>()
            .HasKey(r => r.ReportId); // Specify the primary key
    }
}
