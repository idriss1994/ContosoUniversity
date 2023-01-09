using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;
using ContosoUniversity.ViewModels;

namespace ContosoUniversity.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly SchoolContext _context;

        public IndexModel(SchoolContext context)
        {
            _context = context;
        }

        //Courses without using view model
        //public IList<Course> Courses { get;set; } = default!;

        //Courses using view model
        public IList<CourseViewModel> Courses { get;set; } = default!;

        //uising Include method to retrieve related data
        //public async Task OnGetAsync()
        //{
        //    Courses = await _context.Courses
        //        .Include(c => c.Department)
        //        .AsNoTracking()
        //        .ToListAsync();
        //}

        //using Select method to retrieve related data
        public async Task OnGetAsync()
        {
            Courses = await _context.Courses
                .Select(c => new CourseViewModel
                {
                    CourseID = c.CourseID,
                    Title = c.Title,
                    Credits = c.Credits,
                    DepartmentName = c.Department.Name
                })
                .ToListAsync();
        }
    }
}
