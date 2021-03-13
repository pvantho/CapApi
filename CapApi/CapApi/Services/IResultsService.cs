 
using System.Collections.Generic;
using CapApi.Model;
using System.Threading.Tasks;
namespace CapApi.Services
{
    public interface IResultsService
    {
        Task<IEnumerable<CapResultEntity>> GetAllResults();
    }
}
