using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Ef_Core_Application.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        #region Relationships

        // Many-to-Many: A student can attend many sessions
        public List<StudentSessionAttendance> Attendees { get; set; } = new();

        // Many-to-Many: A student can help in multiple sessions
        public List<StudentSessionHelper> HelpedSessions { get; set; } = new();

        // One-to-Many: A student can provide feedback for sessions
        public List<Feedback> Feedbacks { get; set; } = new();

        #endregion

    }
}
