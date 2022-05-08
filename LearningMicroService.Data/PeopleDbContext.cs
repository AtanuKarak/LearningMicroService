using LearningMicroService.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace LearningMicroService.Data
{
    public class PeopleDbContext : DbContext
    {
        public PeopleDbContext(DbContextOptions<PeopleDbContext> dbContextOptions)
            :base(dbContextOptions)
        {
            var people = new List<Person>() {
         new Person { Id = Guid.Parse("e6f35f40-48ca-45a8-83bb-3f8e9f0559a1"), FirstName = "Atanu", LastName = "Karak", Gender = PersonGender.Male}
        };
            People.AddRange(people);
            SaveChanges();
        }
        public DbSet<Person> People { get; set; }
    }
}
