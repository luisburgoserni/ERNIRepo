using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ejemplo.swagger.openapi.api.Request;
using ejemplo.swagger.openapi.api.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ejemplo.swagger.openapi.api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploTipoRespuesta : ControllerBase
    {


        /// <summary>
        /// Agrega un registro de tipo Model
        /// </summary>
        /// <param name="request"></param>
        /// <response code="201"><see cref="ResponseModel"/>Si crea bien el objeto</response>
        /// <response code="400">Si no encuentra la ruta</response> 
        /// <response code="403">Si la llamada no esta autenticada</response>
        /// <response code="500">Si se produce un error</response>
        [HttpPost]
        [ProducesResponseType(201)]    
        [ProducesResponseType(400)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        [ProducesResponseType(typeof(ResponseModel), (int)HttpStatusCode.OK)]
        public IActionResult Post([FromBody] RequestModel request)
        {

            return Ok();
        }    
    }
}
