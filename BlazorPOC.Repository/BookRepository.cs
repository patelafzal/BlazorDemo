using BlazorPOC.Data.Context;
using BlazorPOC.Domain.Entities;
using BlazorPOC.Domain.Interfaces;

namespace BlazorPOC.Repository
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(DatabaseContext context) : base(context) { }
    }
}
