using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConsumeWS.Models
{
    public class MPersonaClientes
    {
        public string Nombre { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public string Edad { get; set; }

        [Required(ErrorMessage ="El código postal es necesario, vuelva a ingresarlo.")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Escriba un código postal de 5 digitos.")]

        public int CodigoPostal { get; set; }

        public DateTime FNacimiento { get; set; }

        public int NumeroTelefono { get; set; }
        public string Email { get; set; }
    }
}