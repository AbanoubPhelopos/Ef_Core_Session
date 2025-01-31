using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Ef_Core_Application.Models
{
    public class Student
    {
        public int Id { get; set; }
        
        public string Name { get; set; } 
        public int Level { get; set; }

        #region One-to-Many

        // One-to-Many: A student can attend one session
        public int SessionId { get; set; }
        public Session Session { get; set; }

        #endregion

        #region Many-to-Many

        // Many-to-Many: A student can help in multiple sessions
        public List<StudentSessionHelper> HelpedSessions { get; set; } = new();

        #endregion

    }
}
