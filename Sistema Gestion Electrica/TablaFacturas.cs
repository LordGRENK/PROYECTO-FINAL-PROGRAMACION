//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_Gestion_Electrica
{
    using System;
    using System.Collections.Generic;
    
    public partial class TablaFacturas
    {
        public int Id { get; set; }
        public Nullable<int> NIS { get; set; }
        public string NombreUsuario { get; set; }
        public string Compañia { get; set; }
        public Nullable<decimal> KwhTotalAPagar { get; set; }
        public Nullable<decimal> PrecioAlumbradoPublicoTotal { get; set; }
        public Nullable<decimal> PrecioFijoComercialicación { get; set; }
        public Nullable<decimal> PrecioKwhPorMes { get; set; }
        public Nullable<int> Año { get; set; }
        public Nullable<int> Mes { get; set; }
    }
}
