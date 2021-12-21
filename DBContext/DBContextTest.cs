
using Microsoft.EntityFrameworkCore;
using Test1312.Model;

namespace Test1312.DBContext
{
    public class DBContextTest : DbContext
    {
        public DBContextTest(DbContextOptions<DBContextTest> options): base(options) 
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* modelBuilder.Entity<Participation>()
                 .HasOne(b => b.Room)
                 .WithMany(p => p.participations)
                 .HasForeignKey(bi => bi.roomid); 

             modelBuilder.Entity<Participation>()
                 .HasOne(b => b.User)
                 .WithMany(p => p.participations)
                 .HasForeignKey(bi => bi.userid); 





             modelBuilder.Entity<Selection>()
                 .HasOne(b => b.Room)
                 .WithMany(p => p.selections)
                 .HasForeignKey(bi => bi.idroom);

             modelBuilder.Entity<Selection>()
                 .HasOne(b => b.Question)
                 .WithMany(p => p.selections)
                 .HasForeignKey(bi => bi.idquestion);
            */

            //modelBuilder.Entity<Participation>()
            //     .HasKey(p => new { p.roomid, p.userid });

            modelBuilder.Entity<Participation>()
                 .HasOne(p => p.User).WithMany(p => p.Participations).HasForeignKey(p => p.userid);

            modelBuilder.Entity<Participation>()
                 .HasOne(p => p.Room).WithMany(p => p.participations).HasForeignKey(p => p.roomid);
            
             //modelBuilder.Entity<Selection>()
             //    .HasKey(p => new { p.idroom, p.idquestion });
            
            modelBuilder.Entity<Selection>()
                 .HasOne(p => p.Room).WithMany(p => p.selections).HasForeignKey(p => p.idroom);

            modelBuilder.Entity<Selection>()
                 .HasOne(p => p.Question).WithMany(p => p.selections).HasForeignKey(p => p.idquestion);
            


             modelBuilder.Entity<Response>()
        .HasOne(a => a.questions)
        .WithOne(b => b.responses)
        .HasForeignKey<Response>(b => b.id_question);

        
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<Participation> Participations { get; set; }
        public DbSet<Selection> Selections { get; set; }
    }
}
