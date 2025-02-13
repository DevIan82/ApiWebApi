using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace ApiService.Controllers
{
    [Route("api/[controller]")] 
    public class EmployeeController:ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private readonly ILoggerManager _loggerManager;
        public  EmployeeController(IServiceManager serviceManager, ILoggerManager loggerManager) { 
            _serviceManager = serviceManager;
            _loggerManager = loggerManager;
        }
    }
}