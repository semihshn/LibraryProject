//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KUTUPHANEPROJE_DENEMELER
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLKİTAPLAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLKİTAPLAR()
        {
            this.TBLSECİLEN_KİTAPLAR = new HashSet<TBLSECİLEN_KİTAPLAR>();
            this.TBLAVERAGE_SCORE = new HashSet<TBLAVERAGE_SCORE>();
            this.TBLAVERAGE_NOTE = new HashSet<TBLAVERAGE_NOTE>();
        }
    
        public int ID { get; set; }
        public string BookName { get; set; }
        public string WriterName { get; set; }
        public string Publisher { get; set; }
        public int PageNumber { get; set; }
        public string Barkod { get; set; }
        public bool İsActivite { get; set; }
        public Nullable<int> BookPiece { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSECİLEN_KİTAPLAR> TBLSECİLEN_KİTAPLAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLAVERAGE_SCORE> TBLAVERAGE_SCORE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLAVERAGE_NOTE> TBLAVERAGE_NOTE { get; set; }
    }
}
