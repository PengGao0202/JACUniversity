﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JACUniversity.Models;

namespace JACUniversity.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly JACUniversity.Models.JACUniversityContext _context;

        public IndexModel(JACUniversity.Models.JACUniversityContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }

        public async Task OnGetAsync()
        {
            Course = await _context.Course.ToListAsync();
        }
    }
}
