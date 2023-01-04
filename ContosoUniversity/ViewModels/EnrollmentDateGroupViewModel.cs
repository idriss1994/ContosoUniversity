using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.ViewModels
{
    public class EnrollmentDateGroupViewModel
    {
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }
        public int StudentCount { get; set; }
    }
}
