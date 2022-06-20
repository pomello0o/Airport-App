namespace AirportApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CrewMember")]
    public partial class CrewMember
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CrewMember()
        {
            AllowedCrewMemberModels = new HashSet<AllowedCrewMemberModel>();
            Crews = new HashSet<Crew>();
        }
        public CrewMember(int ID, string name, string surname, string role, string address, DateTime birthday)
        {
            this.ID = ID;
            Name = name;
            Surname = surname;
            Role = role;
            Address = address;
            Birthday = birthday;
            AllowedCrewMemberModels = new HashSet<AllowedCrewMemberModel>();
            Crews = new HashSet<Crew>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Surname { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(15)]
        public string Role { get; set; }

        [Column(TypeName = "date")]
        public DateTime Birthday { get; set; }

        [Required]
        [StringLength(150)]
        public string Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AllowedCrewMemberModel> AllowedCrewMemberModels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Crew> Crews { get; set; }
    }
}
