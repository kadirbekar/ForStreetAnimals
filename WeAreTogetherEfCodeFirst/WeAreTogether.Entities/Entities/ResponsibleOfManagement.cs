namespace WeAreTogether.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ResponsibleOfManagement")]
    public partial class ResponsibleOfManagement
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        public int? ManagementId { get; set; }

        public virtual Management Management { get; set; }

        public virtual User User { get; set; }
    }
}
