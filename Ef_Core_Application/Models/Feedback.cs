using System.ComponentModel.DataAnnotations;

namespace Ef_Core_Application.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        public string Comments { get; set; } // The feedback content

        #region RelationShips

        //One-to-Many   -> feedback is the many in both relationships

        public int StudentId { get; set; }
        public Student Student { get; set; }
        

        public int SessionId { get; set; }
        public Session Session { get; set; } 

        #endregion

    }
}
