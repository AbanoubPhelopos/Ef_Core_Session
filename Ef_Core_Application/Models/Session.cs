namespace Ef_Core_Application.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Topic { get; set; }

        #region Relationships

        // One-to-Many: A session can have many students attending
        public List<StudentSessionAttendance> Attendees { get; set; } = new();

        // One-to-Many: A session can have many feedbacks from students
        public List<Feedback> Feedbacks { get; set; } = new();

        // Many-to-Many: A session can have many student helpers
        public List<StudentSessionHelper> Helpers { get; set; } = new();

        #endregion

    }
}
