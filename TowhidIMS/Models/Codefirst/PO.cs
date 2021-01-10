namespace TowhidIMS.Models.Codefirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PO()
        {
            PODs = new HashSet<POD>();
        }

        [StringLength(50)]
        public string Id { get; set; }

        public int? POSerial { get; set; }

        public decimal BillAmount { get; set; }

        public decimal BillPaid { get; set; }

        public decimal? Discount { get; set; }

        public decimal? Balance { get; set; }

        public decimal? PrevBalance { get; set; }

        public DateTime? Date { get; set; }

        public bool? PurchaseReturn { get; set; }

        public int? SupplierId { get; set; }

        public decimal? PODId { get; set; }

        public decimal? PurchaseOrderAmount { get; set; }

        public decimal? PurchaseReturnAmount { get; set; }

        public decimal? PurchaseOrderQty { get; set; }

        public decimal? PurchaseReturnQty { get; set; }

        [StringLength(100)]
        public string PaymentMethod { get; set; }

        [StringLength(500)]
        public string PaymentDetail { get; set; }

        [StringLength(500)]
        public string Remarks { get; set; }

        [StringLength(500)]
        public string Remarks2 { get; set; }

        public int? EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POD> PODs { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
