namespace ShoppingList.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("List")]
    public partial class List
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string ItemName { get; set; }

        public int Quantity { get; set; }

        [StringLength(150)]
        public string Comments { get; set; }
    }
}
