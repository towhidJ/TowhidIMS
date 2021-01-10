namespace TowhidIMS.Models.Codefirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MyBusinessInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        [StringLength(500)]
        public string BizName { get; set; }

        [StringLength(500)]
        public string BizAddress { get; set; }

        [StringLength(500)]
        public string Mobile { get; set; }

        [StringLength(500)]
        public string Email { get; set; }

        [StringLength(500)]
        public string Website { get; set; }

        [StringLength(500)]
        public string Tagline { get; set; }
    }
}
