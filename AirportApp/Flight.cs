namespace AirportApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Flight")]
    public partial class Flight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flight()
        {
            Crews = new HashSet<Crew>();
        }
        public Flight(int ID, DateTime DepartureDate, int RaceID, int PlaneID)
        {
            this.ID = ID;
            this.DepartureDate = DepartureDate;
            this.SoldTickets = 0;
            this.RaceID = RaceID;
            this.PlaneID = PlaneID;
            Crews = new HashSet<Crew>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DepartureDate { get; set; }

        public int SoldTickets { get; set; }

        public int? RaceID { get; set; }

        public int? PlaneID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Crew> Crews { get; set; }

        public virtual Plane Plane { get; set; }

        public virtual Race Race { get; set; }
    }
}
