namespace TowhidIMS.Models.Codefirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SOD
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Auto { get; set; }

        [StringLength(50)]
        public string SOId { get; set; }

        public int? SODId { get; set; }

        public int? ProductId { get; set; }

        public decimal? OpeningStock { get; set; }

        public int? Quantity { get; set; }

        public decimal? SalePrice { get; set; }

        public decimal? PurchasePrice { get; set; }

        public decimal? PerPack { get; set; }

        public bool? IsPack { get; set; }

        public bool? SaleType { get; set; }

        public decimal? Profit { get; set; }

        [StringLength(500)]
        public string Remarks { get; set; }

        public virtual Product Product { get; set; }

        public virtual SO SO { get; set; }
    }
}
