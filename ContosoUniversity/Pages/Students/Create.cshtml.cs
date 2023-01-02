using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContosoUniversity.Data;
using ContosoUniversity.Models;
using ContosoUniversity.ViewModels;

namespace ContosoUniversity.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly ContosoUniversity.Data.SchoolContext _context;

        public CreateModel(ContosoUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        //[BindProperty]
        //public Student Student { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        // Prevent overposting using TryUpdateModelAsync method:
        //public async Task<IActionResult> OnPostAsync()
        //{
        //    var emptyStudent = new Student();

        //    if (await TryUpdateModelAsync<Student>(emptyStudent,
        //        "student", // Prefix for form value.
        //        s => s.FirstName, s => s.LastName, s => s.EnrollmentDate))
        //    {
        //        _context.Students.Add(emptyStudent);
        //        await _context.SaveChangesAsync();
        //        return RedirectToPage("./Index");
        //    }

        //    return Page();
        //}

        // prevent overposting using student view model:
        [BindProperty]
        public StudentViewModel StudentVM { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var entry = await _context.Students.AddAsync(new Student());
            entry.CurrentValues.SetValues(StudentVM);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
