using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace Infrastructure
{
    public class AplicationDbContext
    {
        public static List<User> Users { get; set; } = new List<User> 
        {
            new User { Id = 1, Name = "John", LastName = "Doe", Email = "john.doe@example.com", Password = "password123", CreationDate = DateTime.Now },
            new User { Id = 2, Name = "Jane", LastName = "Smith", Email = "jane.smith@example.com", Password = "password456", CreationDate = DateTime.Now },
            new User { Id = 3, Name = "Alice", LastName = "Johnson", Email = "alice.johnson@example.com", Password = "password789", CreationDate = DateTime.Now }
        };
    }
}
