namespace DatabaseFirstSample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Drink")]
    public partial class Drink
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_drink { get; set; }

        [StringLength(10)]
        public string name_drink { get; set; }

        public double cost_drink { get; set; }
    }
}
