using BlazorPOC.Data.Context;
using BlazorPOC.Domain.Entities;
using BlazorPOC.Domain.Interfaces;
using BlazorPOC.Domain.Models;

namespace BlazorPOC.Repository
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        private DatabaseContext dbcontext;
        public BookRepository(DatabaseContext context) : base(context) {
            dbcontext = context;
        }

        public void AddBook(BookModel model)
        {
            dbcontext.Books.Add(new Book() { 
                Author = model.Author,
                Category = model.Author,
                CreatedDate = System.DateTime.Now,
                Price = model.Price,
                Quantity = model.Quantity,
                Title = model.Author,
            });

            dbcontext.SaveChanges();
        }
    }
}
