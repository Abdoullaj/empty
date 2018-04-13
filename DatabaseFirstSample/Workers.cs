namespace DatabaseFirstSample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Workers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_worker { get; set; }

        [StringLength(10)]
        public string name_worker { get; set; }

        public double? salary_worker { get; set; }

        [StringLength(10)]
        public string task { get; set; }
    }
}
