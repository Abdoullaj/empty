namespace DatabaseFirstSample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomPizza")]
    public partial class CustomPizza
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_customPizza { get; set; }

        public int ID_pizza { get; set; }

        [StringLength(10)]
        public string Ingredient1 { get; set; }

        [StringLength(10)]
        public string ingredient2 { get; set; }

        [StringLength(10)]
        public string ingredient3 { get; set; }
    }
}
