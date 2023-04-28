using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.net.core.ejemplo.dataaccess.contracts.Entities
{
    public class ModelItem
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool EsCliente { get; set; }
    }
}
