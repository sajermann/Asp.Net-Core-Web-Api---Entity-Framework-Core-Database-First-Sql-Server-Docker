using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        masterContext context = new masterContext();
        [HttpGet]
        public IEnumerable<Author> Get()
        {
            //Get author by id
            //var t = context.Author.Where(author => author.AuthorId == 1).ToList();

            //Get all authors
            //var t = context.Author.ToList();

            //Add a author
            //Author author = new Author();
            //author.FirstName = "Bruno";
            //author.LastName = "Sajermann";
            //context.Author.Add(author);
            //context.SaveChanges();

            return context.Authors.Where(author => author.FirstName == "Bruno").ToList();
        }
    }
}
