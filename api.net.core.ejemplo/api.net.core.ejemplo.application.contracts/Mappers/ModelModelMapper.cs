using api.net.core.ejemplo.bussiness.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace api.net.core.ejemplo.application.contracts.Mappers
{
    public static class ModelModelMapper
    {
        public static Model Map(dataaccess.contracts.Entities.ModelItem model)
        {
            return new Model
            {
                EsCliente = model.EsCliente,
                Id = model.Id,
                Nombre = model.Nombre
            };
        }

    }
}
