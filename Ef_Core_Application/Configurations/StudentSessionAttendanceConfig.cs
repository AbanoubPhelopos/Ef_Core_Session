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
    public class StudentSessionAttendanceConfig : IEntityTypeConfiguration<StudentSessionAttendance>
    {
        public void Configure(EntityTypeBuilder<StudentSessionAttendance> builder)
        {
            builder.HasKey(ss => new { ss.StudentId, ss.SessionId });

            builder.HasOne(ss => ss.Student)
                .WithMany(s => s.Attendees)
                .HasForeignKey(ss => ss.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ss => ss.Session)
                .WithMany(s => s.Attendees)
                .HasForeignKey(ss => ss.SessionId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
