using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dannyallegrezza.DAL.Models;
using dannyallegrezza.DAL;

namespace dannyallegrezza.API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private BlogDbContext _context;

        public ValuesController(BlogDbContext context)
        {
            _context = context; 
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Post> Get()
        {
            yield return new Post()
            {
                Author = new Author() { FirstName = "Danny" },
                Category = new Category(),
                Id = 1,
                Content = "hello world",
                CreatedDate = DateTime.Now,
                Excerpt = "hello",
                Title = "My First Post"
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
