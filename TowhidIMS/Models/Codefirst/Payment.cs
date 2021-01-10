namespace TowhidIMS.Models.Codefirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payment
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string SOId { get; set; }

        [StringLength(50)]
        public string PaymentMethod { get; set; }

        public decimal PaymentAmount { get; set; }

        public DateTime ReceivedDate { get; set; }

        [StringLength(500)]
        public string Remarks { get; set; }

        public virtual SO SO { get; set; }
    }
}
