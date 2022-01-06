using BookStore.Data.Services;
using BookStore.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private BooksService _booksService;
        public BooksController(BooksService booksService)
        {
            _booksService= booksService;
        }


        [HttpPost("add-book")]
        public IActionResult Addbook([FromBody] BookVM book)
        {
            _booksService.AddBook(book);
            return Ok();
        }

        [HttpGet("get-all-books")]
        public IActionResult GetAllBooks()
        {
            var books = _booksService.GetAllBooks();
            return Ok(books);
        }
        [HttpGet("get-book-by-id/{Id}")]
        public IActionResult GetBookById(int Id)
        {
            var book = _booksService.GetBookById(Id);
            return Ok(book);
        }


        [HttpPut("update-book-by-id/{id}")]
        public IActionResult UpdateBookById(int id, [FromBody] BookVM book)
        {
            var updatedBook = _booksService.UpdateBookById(id, book);
            return Ok(updatedBook);
        }

        [HttpDelete("delete-book-by-id/{id}")]
        public IActionResult DeleteBookById(int id)
        {
            _booksService.DeleteBookById(id);
            return Ok();
        }

    }
}
