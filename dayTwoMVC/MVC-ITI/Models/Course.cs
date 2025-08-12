namespace day1MVCITI.Models
{
    public enum CourseCategory
    {
        Development,
        Design,
        Marketing,
        Programming
    }

    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public CourseCategory Category { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public Guid InstructorId { get; set; }
    }
}
