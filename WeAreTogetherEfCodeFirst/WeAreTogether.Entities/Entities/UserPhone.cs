namespace WeAreTogether.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserPhone")]
    public partial class UserPhone
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(11)]
        public string PhoneNumber { get; set; }

        public int PhoneId { get; set; }

        public virtual PhoneType PhoneType { get; set; }

        public virtual User User { get; set; }
    }
}
