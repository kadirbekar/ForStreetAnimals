namespace WeAreTogether.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ManagementShelter")]
    public partial class ManagementShelter
    {
        public int Id { get; set; }

        public int ManagementId { get; set; }

        public int ShelterId { get; set; }

        public bool Active { get; set; }

        public virtual Management Management { get; set; }

        public virtual Shelter Shelter { get; set; }
    }
}
