namespace DatabaseFirstSample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clients
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_client { get; set; }

        [Required]
        [StringLength(10)]
        public string name_client { get; set; }

        [StringLength(10)]
        public string phone_client { get; set; }

        [StringLength(10)]
        public string address_client { get; set; }

        public int? ID_table { get; set; }
    }
}
