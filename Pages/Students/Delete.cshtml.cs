using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageLab.Context;
using RazorPageLab.Models;
using RazorPageLab.Repository;

namespace RazorPageLab.Pages.Students
{
    public class DeleteModel : PageModel
    {
        private readonly StudentRepository studentRepository;

        public DeleteModel()
        {
            studentRepository = new StudentRepository();
        }

        [BindProperty]
      public Student Student { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = studentRepository.Get(s=>s.Id == id);

            if (Student==null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            bool result = studentRepository.Delete(s=>s.Id == id);

            if (result)
            {
                return RedirectToPage("Index");
            }
            else
            {
                return NotFound();
            }

            
        }
    }
}
