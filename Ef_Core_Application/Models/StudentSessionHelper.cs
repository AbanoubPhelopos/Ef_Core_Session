namespace Ef_Core_Application.Models
{
    public class StudentSessionHelper
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int SessionId { get; set; }
        public Session Session { get; set; }

        public DateTime HelpDate { get; set; }
    }
}
