namespace DatabaseFirstSample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pizza")]
    public partial class Pizza
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_pizza { get; set; }

        [StringLength(10)]
        public string Type_pizza { get; set; }

        [StringLength(10)]
        public string cost_pizza { get; set; }

        public int quantity { get; set; }
    }
}
