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
    
    public partial class TempPurchaseSaleBookHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TempPurchaseSaleBookHeader()
        {
            this.TempPurchaseSaleBookLineItem = new HashSet<TempPurchaseSaleBookLineItem>();
        }
    
        public long PurchaseSaleBookHeaderID { get; set; }
        public string VoucherTypeCode { get; set; }
        public System.DateTime VoucherDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public string PurchaseBillNo { get; set; }
        public string LedgerType { get; set; }
        public string LedgerTypeCode { get; set; }
        public Nullable<decimal> Amount01 { get; set; }
        public Nullable<decimal> Amount02 { get; set; }
        public Nullable<decimal> Amount03 { get; set; }
        public Nullable<decimal> Amount04 { get; set; }
        public Nullable<decimal> Amount05 { get; set; }
        public Nullable<decimal> Amount06 { get; set; }
        public Nullable<decimal> Amount07 { get; set; }
        public Nullable<decimal> SGST01 { get; set; }
        public Nullable<decimal> SGST02 { get; set; }
        public Nullable<decimal> SGST03 { get; set; }
        public Nullable<decimal> SGST04 { get; set; }
        public Nullable<decimal> SGST05 { get; set; }
        public Nullable<decimal> SGST06 { get; set; }
        public Nullable<decimal> SGST07 { get; set; }
        public Nullable<decimal> IGST01 { get; set; }
        public Nullable<decimal> IGST02 { get; set; }
        public Nullable<decimal> IGST03 { get; set; }
        public Nullable<decimal> IGST04 { get; set; }
        public Nullable<decimal> IGST05 { get; set; }
        public Nullable<decimal> IGST06 { get; set; }
        public Nullable<decimal> IGST07 { get; set; }
        public Nullable<decimal> CGST01 { get; set; }
        public Nullable<decimal> CGST02 { get; set; }
        public Nullable<decimal> CGST03 { get; set; }
        public Nullable<decimal> CGST04 { get; set; }
        public Nullable<decimal> CGST05 { get; set; }
        public Nullable<decimal> CGST06 { get; set; }
        public Nullable<decimal> CGST07 { get; set; }
        public decimal TotalTaxAmount { get; set; }
        public Nullable<decimal> SurchargeAmount { get; set; }
        public Nullable<decimal> TotalBillAmount { get; set; }
        public Nullable<decimal> TotalCostAmount { get; set; }
        public Nullable<decimal> TotalGrossAmount { get; set; }
        public Nullable<decimal> TotalSchemeAmount { get; set; }
        public Nullable<decimal> TotalDiscountAmount { get; set; }
        public Nullable<decimal> OtherAmount { get; set; }
        public string FreshBreakageExcess { get; set; }
        public string ReturnBillNo { get; set; }
        public Nullable<System.DateTime> ReturBillDate { get; set; }
        public string LocalCentral { get; set; }
        public string OrderNumber { get; set; }
        public string ChallanNumber { get; set; }
        public string Message { get; set; }
        public string Deliveryddress { get; set; }
        public string DeliveredBy { get; set; }
        public string CourierName { get; set; }
        public Nullable<System.DateTime> CourierDate { get; set; }
        public Nullable<decimal> CourierWeight { get; set; }
        public Nullable<int> PurchaseEntryFormID { get; set; }
        public Nullable<decimal> LastBalance { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<long> OldPurchaseSaleBookHeaderID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TempPurchaseSaleBookLineItem> TempPurchaseSaleBookLineItem { get; set; }
    }
}