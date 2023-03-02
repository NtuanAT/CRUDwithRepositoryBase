using System;
using System.Collections.Generic;
using System.Dynamic;
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
    public class IndexModel : PageModel
    {
        
        private StudentRepository studentRepository;
        public IList<Student> Students { get;set; } = default!;
        public IndexModel()
        {
            studentRepository = new StudentRepository();
        }
        public void OnGet()
        {
            
            Students = studentRepository.GetAll();
        }
    }
}
