# EF Core Application

This is a console application project demonstrating how to use Entity Framework Core with multiple models, relationships, and configurations. The project includes the following features:

- **One-to-Many** relationship between `Student` and `Session`.
- **Many-to-Many** relationship between `Student` and `Session` via helper tables.
- **One-to-Many** relationship between `Student` and `Feedback`.
- Custom configurations using the `Fluent API`.


## Project Description

This application demonstrates the use of **Entity Framework Core** to manage students, sessions, feedback, and helpers. It implements various relationships such as:

- **One-to-Many**: A student can provide feedback for multiple sessions.
- **Many-to-Many**: A student can attend and help in multiple sessions.
- **Many-to-Many**: A session can have multiple students attending and providing feedback.

The project includes the configuration of each model using the **Fluent API**.

## Technologies Used
- **C#**
- **Entity Framework Core** (EF Core)
- **SQL Server** (for the database)
- **Fluent API** for model configuration

### Clone the repository
Clone the repository to your local machine using the following command:

```bash
git clone https://github.com/yourusername/ef-core-application.git
