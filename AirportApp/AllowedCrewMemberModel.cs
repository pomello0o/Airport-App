namespace AirportApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AllowedCrewMemberModel")]
    public partial class AllowedCrewMemberModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? CrewMemberID { get; set; }

        public int? ModelID { get; set; }

        public virtual CrewMember CrewMember { get; set; }

        public virtual Model Model { get; set; }
    }
}
