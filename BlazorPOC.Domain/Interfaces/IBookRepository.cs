using BlazorPOC.Domain.Entities;
using BlazorPOC.Domain.Models;

namespace BlazorPOC.Domain.Interfaces
{
    public interface IBookRepository : IRepositoryBase<Book>
    {
        void AddBook(BookModel model);
    }
}
