using day1MVCITI.Models;

namespace MVCITI.Models
{
    public enum Specialization{
        SoftwareDevelopment,
        WebDevelopment,
        Marketing,
        Business,
        Design
    }
    public class Instructor
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public Specialization Specialization { get; set; }
        public bool isActive { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
