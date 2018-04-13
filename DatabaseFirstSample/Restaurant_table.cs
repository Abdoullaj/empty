namespace DatabaseFirstSample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Restaurant_table
    {
        [Key]
        [StringLength(10)]
        public string ID_table { get; set; }

        [StringLength(10)]
        public string Table_place { get; set; }
    }
}
