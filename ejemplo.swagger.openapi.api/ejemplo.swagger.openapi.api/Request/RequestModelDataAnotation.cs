using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ejemplo.swagger.openapi.api.Request
{
    public class RequestModelDataAnotation
    {

        [Required]
        public int Id { get; set;}

        [Required]
        [DefaultValue("Anonimo")]
        public string Nombre { get; set; }

        [DefaultValue(20)]
        public int Edad { get; set; }

        [DefaultValue(false)]
        public bool EsSocio { get; set; }
    }
}
