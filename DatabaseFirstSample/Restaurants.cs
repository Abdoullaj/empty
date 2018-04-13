namespace DatabaseFirstSample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Restaurants
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_restaurant { get; set; }

        public int? ID_worker { get; set; }

        [StringLength(10)]
        public string name_restaurant { get; set; }

        public int? table_place { get; set; }

        public double? overprice_on_product { get; set; }
    }
}
