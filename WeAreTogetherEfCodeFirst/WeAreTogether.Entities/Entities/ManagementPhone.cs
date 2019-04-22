namespace WeAreTogether.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ManagementPhone")]
    public partial class ManagementPhone
    {
        public int Id { get; set; }

        public int ManagementId { get; set; }

        public int PhoneTypeId { get; set; }

        [Required]
        [StringLength(11)]
        public string PhoneNumber { get; set; }

        public virtual Management Management { get; set; }

        public virtual PhoneType PhoneType { get; set; }
    }
}
