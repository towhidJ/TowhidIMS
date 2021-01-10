namespace TowhidIMS.Models.Codefirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SO()
        {
            Payments = new HashSet<Payment>();
            SODs = new HashSet<SOD>();
        }

        [StringLength(50)]
        public string Id { get; set; }

        public int? SOSerial { get; set; }

        public decimal BillAmount { get; set; }

        public decimal BillPaid { get; set; }

        public decimal? Discount { get; set; }

        public decimal? Balance { get; set; }

        public decimal? PrevBalance { get; set; }

        public DateTime? Date { get; set; }

        public bool? SaleReturn { get; set; }

        public int? CustomerId { get; set; }

        public decimal? SODId { get; set; }

        public decimal? SaleOrderAmount { get; set; }

        public decimal? SaleReturnAmount { get; set; }

        public decimal? SaleOrderQty { get; set; }

        public decimal? SaleReturnQty { get; set; }

        public decimal? Profit { get; set; }

        [StringLength(100)]
        public string PaymentMethod { get; set; }

        [StringLength(500)]
        public string PaymentDetail { get; set; }

        [StringLength(500)]
        public string Remarks { get; set; }

        [StringLength(500)]
        public string Remarks2 { get; set; }

        public int? EmployeeId { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOD> SODs { get; set; }
    }
}
