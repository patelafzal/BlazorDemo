using BlazorPOC.Data.Context;
using BlazorPOC.Domain.Entities;
using BlazorPOC.Domain.Interfaces;
using BlazorPOC.Domain.Models;
using System.Linq;

namespace BlazorPOC.Repository
{
    /// <summary>
    /// Book respository for Book CRUD
    /// </summary>
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

        public void Updatebook(BookModel model, int Id)
        {
            dbcontext.Books.Where(b => b.Id == Id).FirstOrDefault();
            dbcontext.SaveChanges();
        }

        public void DeleteBook(int Id)
        {
            Book book = dbcontext.Books.Find(Id);
            dbcontext.Books.Remove(book);
            dbcontext.SaveChanges();
        }
    }
}
