namespace DatabaseFirstSample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Magazine")]
    public partial class Magazine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_storage { get; set; }

        [StringLength(10)]
        public string name_ingredient { get; set; }

        public double? cost_ingredient { get; set; }

        public int quantity__ingredient { get; set; }

        public int? ID_drink { get; set; }
    }
}
