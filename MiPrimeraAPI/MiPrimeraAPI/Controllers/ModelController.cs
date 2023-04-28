using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiPrimeraAPI.Models;
using MiPrimeraAPI.Repository;
using MiPrimeraAPI.Request;

namespace MiPrimeraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly IModelItemRepository _modelRepository;

        public ModelController(IModelItemRepository modelRepository)
        {
            _modelRepository = modelRepository;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var entity = await _modelRepository.Get(id);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ModelRequest request)
        {
            var entity = new ModelItem
            {
                EsCliente = true,
                Nombre = request.Nombre
            };

            await _modelRepository.AddModelItem(entity);

            return Ok();
        }


        [HttpPut]
        public void Put([FromBody] ModelItem model)
        {
            _modelRepository.UpdateModelItem(model);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete([FromBody] int id)
        {
            _modelRepository.DeleteModelItem(id);
        }
    }
}
