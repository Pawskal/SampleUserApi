using System.Collections.Generic;
using System.Threading.Tasks;
namespace SampleUserApi.Services
{
    public interface IModelProvider<T>
    {
        Task<List<T>> GetList();
        Task<T> Find(string id);
        Task Create(T T);
        Task Update(T T);
        Task Delete(string id);
    }
}