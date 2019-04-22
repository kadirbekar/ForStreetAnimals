namespace WeAreTogether.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Management")]
    public partial class Management
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Management()
        {
            ManagementShelter = new HashSet<ManagementShelter>();
            ManagementFood = new HashSet<ManagementFood>();
            ResponsibleOfManagement = new HashSet<ResponsibleOfManagement>();
            ManagementPhone = new HashSet<ManagementPhone>();
        }

        public int Id { get; set; }

        public int ManagementTypeId { get; set; }

        public int CityId { get; set; }

        public int DistrictId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public virtual Cities Cities { get; set; }

        public virtual Districts Districts { get; set; }

        public virtual ManagementType ManagementType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ManagementShelter> ManagementShelter { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ManagementFood> ManagementFood { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResponsibleOfManagement> ResponsibleOfManagement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ManagementPhone> ManagementPhone { get; set; }
    }
}
