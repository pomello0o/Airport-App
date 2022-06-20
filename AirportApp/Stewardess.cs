namespace AirportApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Stewardess
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string Surname { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime Birthday { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(150)]
        public string Address { get; set; }
    }
}
