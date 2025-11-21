// Mario Nikolov
// F122183
// This class represents a student in the university management system,
// inheriting from the Person class and implementing the IDisplayable interface.

using UniversityManager.Interfaces;

namespace UniversityManager.Models
{
    public class Student : Person, IDisplayable
    {
        public double Grade { get; set; }

        public Student()
        {
            Role = "Student";
        }

        public override string GetDetails()
        {
            return $"Student {Name} - Grade: {Grade}";
        }
    }
}
