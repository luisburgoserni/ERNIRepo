using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.net.core.ejemplo.application.contracts.Services;
using api.net.core.ejemplo.bussiness.Models;
using api.net.core.ejemplo.dataaccess.contracts.Entities;
using api.net.core.ejemplo.dataaccess.contracts.Repository;
using api.net.core.ejemplo.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.net.core.ejemplo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {

        private readonly IModelService _modelService;

        public ModelController(IModelService modelService)
        {
            _modelService = modelService;
        }

        // GET api/model/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entity = await _modelService.GetModels(id);

            return Ok();
        }

        // GET api/model/5
        [HttpGet]
        [Route("where/{id}")]
        public IActionResult GetWhere(int id)
        {
            var entity = _modelService.GetModels(id);

            return Ok();
        }

        // POST api/model
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]ModelRequest request)
        {
            var model = new Model
            {
                EsCliente = true,
                Nombre = request.Nombre
            };

            await _modelService.AddModel(model);

            return Ok();
        }

        // PUT api/model/5
        [HttpPut]
        public void Put([FromBody]ModelRequest request)
        {
            var model = new Model
            {
                EsCliente = true,
                Nombre = request.Nombre
            };

            _modelService.UpdateModel(model);
        }

        [HttpPatch]
        public void Patch([FromBody]ModelItem request)
        {

            var model = new Model
            {
                EsCliente = true,
                Nombre = request.Nombre
            };

            _modelService.UpdateModel(model);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _modelService.DeleteModel(id);
        }

    }
}