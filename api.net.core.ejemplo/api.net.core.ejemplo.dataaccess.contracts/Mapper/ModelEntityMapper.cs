using api.net.core.ejemplo.bussiness.Models;
using api.net.core.ejemplo.dataaccess.contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace api.net.core.ejemplo.dataaccess.contracts.Mapper
{
    public static class ModelEntityMapper
    {

        public static ModelItem Map(Model model)
        {
            return new ModelItem
            {
                EsCliente = model.EsCliente,
                Id = model.Id,
                Nombre = model.Nombre
            };
        }

    }
}
