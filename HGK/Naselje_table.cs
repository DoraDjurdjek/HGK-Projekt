//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HGK
{
    using System;
    using System.Collections.Generic;
    
    public partial class Naselje_table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Naselje_table()
        {
            this.Zapis_osobe_table = new HashSet<Zapis_osobe_table>();
            this.Zapis_poslovnog_subjekta_table = new HashSet<Zapis_poslovnog_subjekta_table>();
        }
    
        public int id { get; set; }
        public string naziv { get; set; }
        public string matbroj { get; set; }
        public int zupanija_id { get; set; }
    
        public virtual Zupanija_table Zupanija_table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zapis_osobe_table> Zapis_osobe_table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zapis_poslovnog_subjekta_table> Zapis_poslovnog_subjekta_table { get; set; }
    }
}
