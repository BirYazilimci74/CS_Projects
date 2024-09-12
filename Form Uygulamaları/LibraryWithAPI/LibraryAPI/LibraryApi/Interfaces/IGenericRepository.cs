using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Interfaces
{
    public interface IGenericRepository<Entitiy,EntitiyRequest>
    {
        Task<List<Entitiy>> GetAllAsync();
        Task<Entitiy?> GetByIdAsync(int id);
        Task<Entitiy> AddAsync(EntitiyRequest borrowedBook);
        Task<Entitiy?> UpdateAsync(int id,EntitiyRequest book);
        Task<Entitiy?> DeleteAsync(int id);
    }
}