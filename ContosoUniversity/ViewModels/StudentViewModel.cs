using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.ViewModels
{
    public class StudentViewModel
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }
    }
}
