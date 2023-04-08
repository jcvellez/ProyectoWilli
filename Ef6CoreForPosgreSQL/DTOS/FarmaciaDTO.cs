using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ef6CoreForPosgreSQL.DTOS
{
    public class FarmaciaDTO
    {
        public int IdFarmacia { get; set; }
        [Required(ErrorMessage = "El Nombre de la farmacia  es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La razón social de la farmacia es requerida")]
        public string RazonSocial { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El Ruc de la farmacia es requerido")]
        public string RUC { get; set; }


    }
}