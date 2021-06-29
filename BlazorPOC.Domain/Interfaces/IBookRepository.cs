using BlazorPOC.Domain.Entities;
using BlazorPOC.Domain.Models;

namespace BlazorPOC.Domain.Interfaces
{
    public interface IBookRepository : IRepositoryBase<Book>
    {
        /// <summary>
        /// This function is useful for adding book data
        /// </summary>
        /// <param name="model"></param>
        void AddBook(BookModel model);
    }
}
