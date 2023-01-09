using ContosoUniversity.Models;

namespace ContosoUniversity.ViewModels
{
    public class InstructorIndexDataViewModel
    {
        public IEnumerable<Instructor> Instructors { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}
