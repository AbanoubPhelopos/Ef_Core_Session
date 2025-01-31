using Ef_Core_Application.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ef_Core_Application.Configurations
{
    public class FeedbackConfig : IEntityTypeConfiguration<Feedback>
    {
        public void Configure(EntityTypeBuilder<Feedback> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Comments)
                .IsRequired() 
                .HasMaxLength(500); 

            
            builder.HasOne(f => f.Student) 
                .WithMany(s => s.Feedbacks) 
                .HasForeignKey(f => f.StudentId) 
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(f => f.Session) 
                .WithMany(s => s.Feedbacks) 
                .HasForeignKey(f => f.SessionId) 
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
