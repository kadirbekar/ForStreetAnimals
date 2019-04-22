namespace WeAreTogether.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Animal")]
    public partial class Animal
    {
        public int Id { get; set; }

        public int KindOfAnimalId { get; set; }

        public int ShelterId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public DateTime DateOfRegister { get; set; }

        [Required]
        [StringLength(150)]
        public string Note { get; set; }

        public bool Pet { get; set; }

        public virtual Shelter Shelter { get; set; }

        public virtual KindOfAnimal KindOfAnimal { get; set; }
    }
}
