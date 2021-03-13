using System;
using System.Collections.Generic;
using CapApi.Model;
using CapApi.Infrastructure;
using System.Threading.Tasks;

namespace CapApi.Services
{
    public class ResultsService  :  IResultsService
    {
 
        private ICapDataRepository _dataRepository;

        
        public ResultsService(ICapDataRepository context)
        {
            this._dataRepository = context;
        }

        public async Task<IEnumerable<CapResultEntity>> GetAllResults()
        {
            try
            {
                var res = await _dataRepository.getAll();
                return await Task.FromResult(res);
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.Message);
            }
        }
    }
 
}
