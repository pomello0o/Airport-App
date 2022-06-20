namespace AirportApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Crew")]
    public partial class Crew
    {
        public Crew()
        {

        }
        public Crew(int ID, int CrewMemberID, int FlightID)
        {
            this.ID = ID;
            this.CrewMemberID = CrewMemberID;
            this.FlightID = FlightID;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? CrewMemberID { get; set; }

        public int? FlightID { get; set; }

        public virtual CrewMember CrewMember { get; set; }

        public virtual Flight Flight { get; set; }
    }
}
