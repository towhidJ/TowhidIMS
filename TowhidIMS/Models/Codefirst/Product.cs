namespace TowhidIMS.Models.Codefirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            PODs = new HashSet<POD>();
            SODs = new HashSet<SOD>();
        }

        public int Id { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        public decimal PurchasePrice { get; set; }

        public decimal SalePrice { get; set; }

        public decimal? Stock { get; set; }

        public int? PerPack { get; set; }

        public decimal totalPiece { get; set; }

        public bool Saleable { get; set; }

        [StringLength(100)]
        public string RackPosition { get; set; }

        public int SupplierId { get; set; }

        [StringLength(500)]
        public string Image { get; set; }

        [StringLength(1000)]
        public string Remarks { get; set; }

        [StringLength(100)]
        public string BarCode { get; set; }

        public int? ReOrder { get; set; }

        public int? LocationId { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public virtual Location Location { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POD> PODs { get; set; }

        public virtual Supplier Supplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOD> SODs { get; set; }
    }
}
