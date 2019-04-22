namespace WeAreTogether.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ManagementFood")]
    public partial class ManagementFood
    {
        public int Id { get; set; }

        public int ManagementId { get; set; }

        public DateTime DateOfFood { get; set; }

        public DateTime DeliveryTime { get; set; }

        public bool SupplyDelivery { get; set; }

        public int ResponsibleUser { get; set; }

        public virtual Management Management { get; set; }

        public virtual User User { get; set; }
    }
}
