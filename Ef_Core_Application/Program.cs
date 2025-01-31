using Ef_Core_Application.Data;
using Ef_Core_Application.Models;
using Microsoft.EntityFrameworkCore;

using var context = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>());

#region Dummy Data

#region Student

var student1 = new Student
{
    Name = "Osama",
    Level = 4
};

var student2 = new Student
{
    Name = "Bob",
    Level = 2
};

var student3 = new Student
{
    Name = "Charlie",
    Level = 3
};

var student4 = new Student
{
    Name = "David",
    Level = 1
};

#endregion

#region Session

var session1 = new Session
{
    Topic = "Solid Principles"
};

var session2 = new Session
{
    Topic = "Delegation & Lambda Expressions"
};

var session3 = new Session
{
    Topic = "LINQ"
};

var session4 = new Session
{
    Topic = "Entity Framework Core"
};

#endregion

#region Helpers
var helper1 = new StudentSessionHelper
{
    StudentId = 1, // Osama is helping in session 1
    SessionId = 1,
    HelpDate = DateTime.Now.AddDays(-1) // Assume he helped yesterday
};

var helper2 = new StudentSessionHelper
{
    StudentId = 2, // Bob is helping in session 2
    SessionId = 2,
    HelpDate = DateTime.Now.AddDays(-2) // Assume he helped two days ago
};

var helper3 = new StudentSessionHelper
{
    StudentId = 3, // Charlie is helping in session 3
    SessionId = 3,
    HelpDate = DateTime.Now.AddDays(-3) // Assume he helped three days ago
};

var helper4 = new StudentSessionHelper
{
    StudentId = 4, // David is helping in session 1
    SessionId = 1,
    HelpDate = DateTime.Now.AddDays(-4) // Assume he helped four days ago
};
#endregion

#region Feedback
var feedback1 = new Feedback
{
    StudentId = 1, // Osama's feedback for session 1
    SessionId = 1,
    Comments = "Great session on Solid Principles!"
};

var feedback2 = new Feedback
{
    StudentId = 2, // Bob's feedback for session 2
    SessionId = 2,
    Comments = "Delegation and Lambda were explained clearly."
};

var feedback3 = new Feedback
{
    StudentId = 3, // Charlie's feedback for session 3
    SessionId = 3,
    Comments = "LINQ concepts were easy to follow."
};

var feedback4 = new Feedback
{
    StudentId = 4, // David's feedback for session 1
    SessionId = 1,
    Comments = "Entity Framework Core was very insightful!"
};
#endregion

#endregion

#region AddToDb

// Add sessions
context.Sessions.AddRange(session1, session2, session3, session4);
context.SaveChanges();

// Add Students
context.Students.AddRange(student1, student2, student3, student4);
context.SaveChanges();

// Add StudentSessionHelpers (for many-to-many relationship)
context.Helpers.AddRange(helper1, helper2, helper3, helper4);
context.SaveChanges();

// Add Feedback (optional if you want to test feedback functionality)
context.Feedbacks.AddRange(feedback1, feedback2, feedback3, feedback4);
context.SaveChanges();
#endregion
