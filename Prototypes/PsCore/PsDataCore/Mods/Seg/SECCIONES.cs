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
    
    public partial class SECCIONES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SECCIONES()
        {
            this.BARRIOS_PARAJES = new HashSet<BARRIOS_PARAJES>();
        }
    
        public int ID { get; set; }
        public string CODIGO { get; set; }
        public string NOMBRE { get; set; }
        public Nullable<int> DISTMUNICIPALID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BARRIOS_PARAJES> BARRIOS_PARAJES { get; set; }
        public virtual DIST_MUNICIPALES DIST_MUNICIPALES { get; set; }
    }
}
