using BlazorPOC.Domain.Interfaces;
using BlazorPOC.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorPOC.API.Controllers
{
    /// <summary>
    /// Books controller
    /// </summary>
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

        [HttpPost]
        public IActionResult Updatebook(BookModel model, int Id)
        {
            _bookRepository.Updatebook(model,Id);
            return Ok();
        }

        [HttpPost]
        public IActionResult DeleteBook(int Id)
        {
            _bookRepository.DeleteBook(Id);
            return Ok();
        }
    }
}
