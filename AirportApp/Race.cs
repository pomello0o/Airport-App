namespace AirportApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Race")]
    public partial class Race
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Race()
        {
            AllowedRaceModels = new HashSet<AllowedRaceModel>();
            Flights = new HashSet<Flight>();
        }
        public Race(int ID, string DeparturePoint, string DestinationPoint, TimeSpan DepartureTime, TimeSpan LandingTime, int RaceNumber)
        {
            this.ID = ID;
            this.DeparturePoint = DeparturePoint;
            this.DestinationPoint = DestinationPoint;
            this.DepartureTime = DepartureTime;
            this.LandingTime = LandingTime;
            this.RaceNumber = RaceNumber;
            AllowedRaceModels = new HashSet<AllowedRaceModel>();
            Flights = new HashSet<Flight>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string DeparturePoint { get; set; }

        [Required]
        [StringLength(150)]
        public string DestinationPoint { get; set; }

        public TimeSpan? DepartureTime { get; set; }

        public TimeSpan? LandingTime { get; set; }

        public int RaceNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AllowedRaceModel> AllowedRaceModels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flight> Flights { get; set; }
    }
}
