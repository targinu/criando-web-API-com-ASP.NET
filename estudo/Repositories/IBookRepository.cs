using estudo.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudo.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Get();

        Task<Book> Get(int id);

        Task<Book> Create(Book book);

        Task<Book> Update(Book book);

        Task<Book> Delete(int id);
    }
}
