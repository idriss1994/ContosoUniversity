using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }
        //public string Secret { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
