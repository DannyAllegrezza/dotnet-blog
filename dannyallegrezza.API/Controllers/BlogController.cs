﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dannyallegrezza.DAL;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dannyallegrezza.API.Controllers
{
    public class BlogController : Controller
    {
        public BlogController(BlogDbContext context)
        {

        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
