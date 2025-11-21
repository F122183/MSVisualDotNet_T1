// Mario Nikolov
// F122183
// This class is used as an abstract base class
// that holds common properties for different types of people in the university management system.

namespace UniversityManager.Models
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public string Role { get; set; }


        public Person()
        {
            Name = string.Empty;
            Id = string.Empty;
            Role = string.Empty;
        }

        public abstract string GetDetails();
    }
}
