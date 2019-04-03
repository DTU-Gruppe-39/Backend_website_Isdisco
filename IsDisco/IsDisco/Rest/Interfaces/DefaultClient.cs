using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsDisco.Rest.Interfaces
{
    public interface UserClient<T>
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T element);
        Task<T> Update(int id, T newElement);
        Task<T> Delete(int id);
    }
}
