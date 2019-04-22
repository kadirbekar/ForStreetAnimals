namespace WeAreTogether.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShelterOfUser")]
    public partial class ShelterOfUser
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int ShelterId { get; set; }

        public bool Active { get; set; }

        public virtual Shelter Shelter { get; set; }

        public virtual User User { get; set; }
    }
}
