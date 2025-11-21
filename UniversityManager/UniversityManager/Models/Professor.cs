//Mario Nikolov
//F122183
// This class represents a professor in the university management system,
// inheriting from the Person class and implementing the IDisplayable interface.

using UniversityManager.Interfaces;

namespace UniversityManager.Models
{
    public class Professor : Person, IDisplayable
    {
        public string Department { get; set; }

        public Professor()
        {
            Role = "Faculty Staff";
        }

        public override string GetDetails()
        {
            return $"Professor {Name} - Dept: {Department}";
        }
    }
}
