//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PsDataCore.Mods.Seg
{
    using System;
    using System.Collections.Generic;
    
    public partial class AUTORES_PAGO
    {
        public int ID { get; set; }
        public Nullable<int> AUTORID { get; set; }
        public string REFERENCIA { get; set; }
        public Nullable<int> MONEDAID { get; set; }
        public Nullable<decimal> MONTO { get; set; }
        public string DETALLE { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
    
        public virtual AUTORES AUTORES { get; set; }
        public virtual MONEDAS MONEDAS { get; set; }
    }
}
