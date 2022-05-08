using System;

namespace LearningMicroService.Common
{
    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PersonGender Gender { get; set; }
    }

    public enum PersonGender
    {
        Male, Female, Other
    }
}
