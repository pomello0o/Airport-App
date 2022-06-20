namespace AirportApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Plane")]
    public partial class Plane
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plane()
        {
            Flights = new HashSet<Flight>();
        }
        public Plane(int ID, string boardNumber, int hoursWorked, int modelID)
        {
            this.ID = ID;
            BoardNumber = boardNumber;
            HoursWorked = hoursWorked;
            ModelID = modelID;
            Flights = new HashSet<Flight>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(11)]
        public string BoardNumber { get; set; }

        public int HoursWorked { get; set; }

        public int? ModelID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flight> Flights { get; set; }

        public virtual Model Model { get; set; }
    }
}
