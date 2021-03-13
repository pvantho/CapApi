using System;
using System.Collections.Generic;
using System.Threading.Tasks;
 
using CapApi.Model;

namespace CapApi.Infrastructure
{
    public interface ICapDataRepository
    {
      Task<IEnumerable<CapResultEntity>> getAll();

    }
}
