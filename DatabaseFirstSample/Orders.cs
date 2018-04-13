namespace DatabaseFirstSample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_order { get; set; }

        public int ID_Client { get; set; }

        public int? ID_pizza { get; set; }

        public int? ID_drink { get; set; }

        public int? ID_table { get; set; }

        [StringLength(10)]
        public string hour_order { get; set; }

        [StringLength(10)]
        public string address_client { get; set; }

        public int? ID_customPizza { get; set; }
    }
}
