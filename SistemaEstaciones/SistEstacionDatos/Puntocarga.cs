//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistEstacionDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Puntocarga
    {
        public string IdPuntoCarga { get; set; }
        public string CodTipo { get; set; }
        public int CapacidadMaxVehiculos { get; set; }
        public string FechaReemplazo { get; set; }
    
        public virtual Tipo Tipo { get; set; }
    }
}
