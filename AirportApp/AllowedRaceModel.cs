namespace AirportApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AllowedRaceModel")]
    public partial class AllowedRaceModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? ModelID { get; set; }

        public int? RaceID { get; set; }

        public virtual Model Model { get; set; }

        public virtual Race Race { get; set; }
    }
}
