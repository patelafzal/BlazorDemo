using BlazorPOC.Domain.Interfaces;
using BlazorPOC.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorPOC.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        [HttpPost]
        public IActionResult AddBook(BookModel model)
        {
            _bookRepository.AddBook(model);
            return Ok();
        }
    }
}
