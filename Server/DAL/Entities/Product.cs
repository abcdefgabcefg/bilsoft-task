using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Product : EntityBase 
    {
        [Required]
        public string Title { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
