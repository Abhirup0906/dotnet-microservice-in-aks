using dotnetMSInAKS.EF;
using dotnetMSInAKS.EF.DbModel;
using dotnetMSInAKS.Model.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnetMSInAKS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AdventureDbContext _dbContext;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger, AdventureDbContext dbContext) {
            _dbContext = dbContext;
            _logger = logger;
        }

        [HttpGet(Name = "GetEmployee")]
        public async IAsyncEnumerable<EmployeeBo> Get()
        {
            var query = _dbContext.Employees.AsQueryable();
            await foreach (var result in query.AsAsyncEnumerable())
            {
                var employeeBo = new EmployeeBo()
                {
                    BirthDate = result.BirthDate,
                    EmployeeId = result.EmployeeId,
                    Gender = result.Gender,
                    HireDate = result.HireDate,
                    JobTitle = result.JobTitle,
                    MaritalStatus = result.MaritalStatus
                };
                yield return employeeBo;
            }
        }
    }
}
