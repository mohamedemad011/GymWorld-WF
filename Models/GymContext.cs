using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymWorld.Models
{
    public class GymContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-7DT7JFM;Database=Gym;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassEquipment>()
                 .HasKey(ce => new { ce.GymClassId, ce.EquipmentId });

            //modelBuilder.Entity<ClassEquipment>()
            //    .HasOne(ce => ce.GymClass)
            //    .WithMany()
            //    .HasForeignKey(ce => ce.GymClassId)
            //    .OnDelete(DeleteBehavior.Cascade);  // Cascade delete for GymClass

            //modelBuilder.Entity<ClassEquipment>()
            //    .HasOne(ce => ce.Equipment)
            //    .WithMany()
            //    .HasForeignKey(ce => ce.EquipmentId)
            //    .OnDelete(DeleteBehavior.Cascade);  // Cascade delete for Equipment

            // MemberClass (Many-to-Many between Member and Class)
            modelBuilder.Entity<MemberClass>()
                .HasKey(mc => new { mc.MemberId, mc.ClassId });

            //modelBuilder.Entity<MemberClass>()
            //    .HasOne<Member>()
            //    .WithMany()
            //    .HasForeignKey(mc => mc.MemberId)
            //    .OnDelete(DeleteBehavior.Cascade);  // Cascade delete for Member

            //modelBuilder.Entity<MemberClass>()
            //    .HasOne<Class>()
            //    .WithMany()
            //    .HasForeignKey(mc => mc.ClassId)
            //    .OnDelete(DeleteBehavior.Restrict);  // No cascade delete for Class (avoid cycle)

            // TrainerMember (Many-to-Many between Trainer and Member)
            modelBuilder.Entity<TrainerMember>()
                .HasKey(tm => new { tm.MemberId, tm.TrainerId });

            //modelBuilder.Entity<TrainerMember>()
            //    .HasOne<Trainer>()
            //    .WithMany()
            //    .HasForeignKey(tm => tm.TrainerId)
            //    .OnDelete(DeleteBehavior.Cascade);  // Cascade delete for Trainer

            //modelBuilder.Entity<TrainerMember>()
            //    .HasOne<Member>()
            //    .WithMany()
            //    .HasForeignKey(tm => tm.MemberId)
            //    .OnDelete(DeleteBehavior.Restrict);  // No cascade delete for Member (avoid cycle)

           
        }



        public DbSet<Admin> Admins { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassEquipment> ClassEquipments {  get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberClass> MemberClasses { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<TrainerMember> TrainerMembers {  get; set; } 
    }
}
