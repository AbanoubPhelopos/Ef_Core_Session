namespace Ef_Core_Application.Models
{
    public class StudentSessionAttendance
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int SessionId { get; set; }
        public Session Session { get; set; }
    }
}
