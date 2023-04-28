using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ejemplo.swagger.openapi.api.Request;
using Microsoft.AspNetCore.Mvc;

namespace ejemplo.swagger.openapi.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploRemarksController : ControllerBase
    {
        /// <summary>
        /// Obtiene valores 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Obtiene el valor pasando el id por parametro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Añade una entidad tipo X
        /// </summary>
        /// <param name="request"></param>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /user
        ///     {
        ///        "id": 1,
        ///        "Nombre": "Alberto",
        ///        "Edad": 39
        ///     }
        ///
        /// </remarks>
        [HttpPost]
        [Route("user")]
        public void Post([FromBody] RequestModel request)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <remarks>
        /// TEXTO JSON o XML Informativo
        /// </remarks>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] RequestModel request)
        {
        }

        /// <summary>
        /// Borra la entidad de Id X
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
