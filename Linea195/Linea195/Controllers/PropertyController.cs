using Linea195.Data.Repositories;
using Linea195.Model;
using Microsoft.AspNetCore.Mvc;

namespace Linea195.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class PropertyController : Controller
    {
        private readonly IPropertyRepositories _propertyRepositories;

        public PropertyController(IPropertyRepositories propertyRepositories)
        {
            _propertyRepositories = propertyRepositories;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProperty()
        {
            return Ok(await _propertyRepositories.GetProperty());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _propertyRepositories.InsertProperty(id));
        }

        [HttpPost]
        public async Task<IActionResult> InsertImage([FromBody] Propertys propertys)
        {
            if (propertys == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var created = await _propertyRepositories.InsertImage(propertys);
            return Created("imagen agregada", created);
        }
        [HttpPost]
        public async Task<IActionResult>UpdateProperty([FromBody] Propertys propertys)
        {
            if (propertys == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var created = await _propertyRepositories.UpdateProperty(propertys);
            return Created("Propiedad alterada", created);
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePrice([FromBody] Propertys propertys)
        {
            if (propertys == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var created = await _propertyRepositories.UpdatePrice(propertys);
            return Created("Precio cambiado", created);
        }

    }
