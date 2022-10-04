using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediateBookStore.Application.Contracts
{
    public interface IAsyncRepos<T> where T : class
    {
        Task<T> GetByIDAsync(Guid Id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> AddAsync(T Obj);
        Task UpdateAsync(T Obj);
        Task DeleteAsync(T Obj);
    }
}
