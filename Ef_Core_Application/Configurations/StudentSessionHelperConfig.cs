using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ef_Core_Application.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ef_Core_Application.Configurations
{
    public class StudentSessionHelperConfig : IEntityTypeConfiguration<StudentSessionHelper>
    {
        public void Configure(EntityTypeBuilder<StudentSessionHelper> builder)
        {
            builder.HasKey(ss => new { ss.StudentId, ss.SessionId });

            builder.HasOne(ss => ss.Student)
                .WithMany(s => s.HelpedSessions)
                .HasForeignKey(ss => ss.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ss => ss.Session)
                .WithMany(s => s.Helpers)
                .HasForeignKey(ss => ss.SessionId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(ss => ss.HelpDate)
                .IsRequired();
        }
    }
}
