using Ef_Core_Application.Data;
using Ef_Core_Application.Models;

var context = new ApplicationDbContext();

#region Dummy Data

// Create Students
var student1 = new Student { Name = "Osama", Level = 4 };
var student2 = new Student { Name = "Bob", Level = 2 };
var student3 = new Student { Name = "Charlie", Level = 3 };
var student4 = new Student { Name = "David", Level = 1 };

// Add and Save Students
context.Students.AddRange(student1, student2, student3, student4);
context.SaveChanges();

// Create Sessions
var session1 = new Session { Topic = "Solid Principles" };
var session2 = new Session { Topic = "Delegation & Lambda Expressions" };
var session3 = new Session { Topic = "LINQ" };
var session4 = new Session { Topic = "Entity Framework Core" };

// Add and Save Sessions
context.Sessions.AddRange(session1, session2, session3, session4);
context.SaveChanges();

// Create Helpers using navigation properties
var helper1 = new StudentSessionHelper
{
    Student = student1,
    Session = session1,
    HelpDate = DateTime.Now.AddDays(-1)
};

var helper2 = new StudentSessionHelper
{
    Student = student2,
    Session = session2,
    HelpDate = DateTime.Now.AddDays(-2)
};

var helper3 = new StudentSessionHelper
{
    Student = student3,
    Session = session3,
    HelpDate = DateTime.Now.AddDays(-3)
};

var helper4 = new StudentSessionHelper
{
    Student = student4,
    Session = session1,
    HelpDate = DateTime.Now.AddDays(-4)
};

// Add and Save Helpers
context.Helpers.AddRange(helper1, helper2, helper3, helper4);
context.SaveChanges();

// Create Feedbacks using navigation properties
var feedback1 = new Feedback
{
    Student = student1, 
    Session = session1, 
    Comments = "Great session on Solid Principles!"
};

var feedback2 = new Feedback
{
    Student = student2,
    Session = session2,
    Comments = "Delegation and Lambda were explained clearly."
};

var feedback3 = new Feedback
{
    Student = student3,
    Session = session3,
    Comments = "LINQ concepts were easy to follow."
};

var feedback4 = new Feedback
{
    Student = student4,
    Session = session1, 
    Comments = "Entity Framework Core was very insightful!"
};

// Add and Save Feedbacks
context.Feedbacks.AddRange(feedback1, feedback2, feedback3, feedback4);
context.SaveChanges();

#endregion

Console.WriteLine("Data has been successfully saved to the database.");
