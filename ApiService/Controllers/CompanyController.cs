using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace ApiService.Controllers
{
    [Route("api/companies")]
    public class CompanyController:ControllerBase
    {
    private readonly IServiceManager _serviceManager;   
    private readonly ILoggerManager _logger;    
    public CompanyController(IServiceManager serviceManager, ILoggerManager logger)
    {
        _serviceManager = serviceManager;
        _logger = logger;
    }    
       
    [HttpGet()] 
    public IActionResult Get()
    {
        
         _logger.LogInfo("Accessed GetCompanies");  
         return Ok(_serviceManager.CompanyService.GetAllCompanies(false));
        
    }
    [HttpGet("{id:guid}")]
    public IActionResult GetById(Guid id)
    {
        var company = _serviceManager.CompanyService.GetCompany(id, false);
        if (company == null)
        {
            _logger.LogError($"Company with id: {id}, hasn't been found in db.");
            return NotFound();
        }
        else
        {
            return Ok(company);
        }
        
    }
    }
}