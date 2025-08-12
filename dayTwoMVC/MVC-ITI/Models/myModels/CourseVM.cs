using day1MVCITI.Models;

namespace MVCITI.Models.VM
{
    public class CourseVM
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public CourseCategory Category { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid InstructorId { get; set; }

    }
}
