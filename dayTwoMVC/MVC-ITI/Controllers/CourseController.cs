using day1MVCITI.Models;
using Microsoft.AspNetCore.Mvc;
using MVCITI.Models.VM;


namespace day1MVCITI.Controllers
{
    public class CourseController : Controller
    {
        public static List<Course> _courses =new List<Course>(){
        new Course{

            Id = 1,
            Name = "C#",
            Description = "learn programming with c#",
            Category = CourseCategory.Development,
            StartDate = new DateTime(2023, 10, 1),
            EndDate = new DateTime(2023, 12, 20),
            IsActive = true,
            //InstructorId = Guid.Parse("b1f8c5d2-3e4f-4c5a-9b6e-7c8d9e0f1a2b") 
            }
        ,        new Course{

            Id = 2,
            Name = "mvc",
            Description = "learn creating web apps with mvc",
            Category = CourseCategory.Development,
            StartDate = new DateTime(2023, 7, 1),
            EndDate = new DateTime(2023, 9, 20),
            IsActive = true,
            //InstructorId = Guid.Parse("b1f8c5d2-8dsf-4c5a-9b6e-7c8d9ers9a2b")
            },        new Course{

            Id = 3,
            Name = "Database",
            Description = "learn designing databases",
            Category = CourseCategory.Development,
            StartDate = new DateTime(2023, 3, 9),
            EndDate = new DateTime(2023, 5, 20),
            IsActive = true,
            //InstructorId = Guid.Parse("bfa8j8c5d2-3e4f-4faf5a-ruakj-7c8d9e0f1a2b")
            }, new Course{

            Id = 4,
            Name = "Digital marketing",
            Description = "learn digital marketing",
            Category = CourseCategory.Marketing,
            StartDate = new DateTime(2023, 3, 12),
            EndDate = new DateTime(2023, 7, 20),
            IsActive = true,
              //InstructorId = Guid.Parse("obia8j34d2-3e4f-4faf5a-f97akj-7c8d320f1a2b")
            },
            new Course{
            Id = 5,
            Name = "Graphic Design",
            Description = "learn Graphic Design",
            Category = CourseCategory.Design,
            StartDate = new DateTime(2023, 3, 15),
            EndDate = new DateTime(2023, 5, 20),
            IsActive = true,
              //InstructorId = Guid.Parse("obia8j34d2-3e4f-4fafd-7c8d320f1a2b")
            }

};
        [HttpGet]
        public IActionResult Index(string cat)
        {
            ViewBag.Categories = Enum.GetNames(typeof(CourseCategory)).ToList();
            if (!string.IsNullOrEmpty(cat))
            {

                Enum.TryParse(cat, out CourseCategory s);
                var courses = _courses.Where(c => c.Category == s).ToList();
                return View(courses);
            }
            else
            {

                return View(_courses);

            }
        }
          public IActionResult GetByID(int id)
        {
            var course=_courses.FirstOrDefault(c => c.Id == id);
            if (course == null)
            {
                return NotFound();
            }
            else {
                CourseVM c = new CourseVM {
                    Name = course.Name,
                    Description = course.Description,
                    Category = course.Category,
                    StartDate = course.StartDate,
                    EndDate = course.EndDate,
                    //InstructorId = course.InstructorId,
                };

                return View("Details",c);
            }

        }


        }
    }
