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
    
    public partial class ReceiptPayment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReceiptPayment()
        {
            this.BillOutStandingsAudjustment = new HashSet<BillOutStandingsAudjustment>();
            this.BillOutStandingsAudjustment1 = new HashSet<BillOutStandingsAudjustment>();
        }
    
        public long ReceiptPaymentID { get; set; }
        public string VoucherNumber { get; set; }
        public string VoucherTypeCode { get; set; }
        public System.DateTime VoucherDate { get; set; }
        public string LedgerType { get; set; }
        public string LedgerTypeCode { get; set; }
        public string PaymentMode { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string BankAccountLedgerTypeCode { get; set; }
        public Nullable<System.DateTime> ChequeDate { get; set; }
        public Nullable<System.DateTime> ChequeClearDate { get; set; }
        public Nullable<bool> IsChequeCleared { get; set; }
        public string POST { get; set; }
        public string PISNumber { get; set; }
        public string ChequeNumber { get; set; }
        public string LedgerTypeName { get; set; }
        public Nullable<decimal> UnadjustedAmount { get; set; }
        public string BankAccountLedgerTypeName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillOutStandingsAudjustment> BillOutStandingsAudjustment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillOutStandingsAudjustment> BillOutStandingsAudjustment1 { get; set; }
    }
}
