//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PharmaDAL.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class BillOutStandings
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BillOutStandings()
        {
            this.BillOutStandingsAudjustment = new HashSet<BillOutStandingsAudjustment>();
            this.BillOutStandingsAudjustment1 = new HashSet<BillOutStandingsAudjustment>();
            this.TempBillOutStandingsAudjustment = new HashSet<TempBillOutStandingsAudjustment>();
        }
    
        public long BillOutStandingsID { get; set; }
        public Nullable<long> PurchaseSaleBookHeaderID { get; set; }
        public string VoucherNumber { get; set; }
        public string VoucherTypeCode { get; set; }
        public System.DateTime VoucherDate { get; set; }
        public string LedgerType { get; set; }
        public string LedgerTypeCode { get; set; }
        public decimal BillAmount { get; set; }
        public decimal OSAmount { get; set; }
        public bool IsHold { get; set; }
        public string HOLDRemarks { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
    
        public virtual PurchaseSaleBookHeader PurchaseSaleBookHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillOutStandingsAudjustment> BillOutStandingsAudjustment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillOutStandingsAudjustment> BillOutStandingsAudjustment1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TempBillOutStandingsAudjustment> TempBillOutStandingsAudjustment { get; set; }
    }
}
