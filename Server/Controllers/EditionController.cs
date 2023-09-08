using DoanTMDT.Server.Services.EditionService;
using DoanTMDT.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoanTMDT.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditionController : ControllerBase
    {
        private readonly IEditionService _EditionService;

        public EditionController(IEditionService productTypeService)
        {
            _EditionService = productTypeService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Edition>>>> GetEditions()
        {
            var response = await _EditionService.GetEditions();
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Edition>>>> AddEdition(Edition edition)
        {
            var response = await _EditionService.AddEdition(edition);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<Edition>>>> UpdateEdition(Edition edition)
        {
            var response = await _EditionService.UpdateEdition(edition);
            return Ok(response);
        }
    }
}
