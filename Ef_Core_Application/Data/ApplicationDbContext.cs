﻿using Ef_Core_Application.Configurations;
using Ef_Core_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Ef_Core_Application.Data
{
    public class ApplicationDbContext : DbContext
    {

        #region Connection string
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options
                .UseSqlServer("Server=DESKTOP-TFU0IME\\SQLEXPRESS;" +
                                    "Database=EfCore;Trusted_Connection=True;" +
                                        "TrustServerCertificate=True;");
        }
        #endregion
        
        
        #region Configurations

        /*protected override void OnModelCreating(ModelBuilder model)
        {
            new StudentConfig().Configure(model.Entity<Student>());
            new SessionConfig().Configure(model.Entity<Session>());
            new StudentSessionHelperConfig().Configure(model.Entity<StudentSessionHelper>());
        }*/

        #endregion


        #region Tables

        
        

        #endregion
    }
}
