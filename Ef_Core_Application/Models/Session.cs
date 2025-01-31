namespace Ef_Core_Application.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Topic { get; set; }

        #region One-to-Many

        // One-to-Many: A session has many students
        //public List<Student> Attendees { get; set; } = new();

        #endregion

        #region Many-to-Many

        // Many-to-Many: A session has many student helpers
        public List<StudentSessionHelper> Helpers { get; set; } = new();

        #endregion

    }
}
