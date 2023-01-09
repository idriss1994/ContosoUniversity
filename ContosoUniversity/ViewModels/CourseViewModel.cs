﻿using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.ViewModels
{
    public class CourseViewModel
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        [Display(Name = "Department")]
        public string DepartmentName { get; set; }
    }

}
