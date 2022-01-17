using Linea195.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Linea195.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class PropertyController : Controller
    {
        private readonly IPropertyRepositories _propertyRepositories;

        public PropertyController(IPropertyRepositories, propertyRepositories)
        {
            _propertyRepositories = propertyRepositories;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProperty()
        {
            return Ok(await _propertyRepositories, GetProperty());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _propertyRepositories, InsertProperty(int id));
        }

        public async Task<IActionResult> InsertImage()
        {

        }
    }
