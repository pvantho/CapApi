
using System.Collections.Generic;
using CapApi.Model;
using Microsoft.AspNetCore.Mvc;
using CapApi.Services;
using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CapApi.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class ResultsController : Controller
    {

        public Services.IResultsService CapResultService;
        private readonly ILogger<IEnumerable<CapResultEntity>> _logger;

        public ResultsController(IResultsService resultsService, ILogger<IEnumerable<CapResultEntity>> logger)
        {
            this.CapResultService = resultsService;
            _logger = logger;
        }
   
        [HttpGet]
        public async System.Threading.Tasks.Task<IActionResult> Get()
        {
            _logger.LogInformation("Get All Results ");
            var result =  await CapResultService.GetAllResults();
            return Ok(result);
        } 
    }
}
