using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.IdentityModel.Tokens;
using RazorPageLab.Context;
using RazorPageLab.Models;
using RazorPageLab.Repository;

namespace RazorPageLab.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly StudentRepository studentRepository;

        public CreateModel()
        {
            studentRepository = new StudentRepository();
        }
        
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }
        
        public IActionResult OnPost()
        {
            if (Student != null)
            {
                if(Student.FirstName.IsNullOrEmpty()|| Student.LastName.IsNullOrEmpty())
                {
                    return Page();
                }
                else
                {
                    studentRepository.Create(Student);
                    return Redirect("Index");
                }
            }
            else
            {
                return Page();
            }

        }
    }
}
