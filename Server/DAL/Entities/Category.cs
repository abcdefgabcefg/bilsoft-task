using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Category : EntityBase
    {
        [Required]
        public string Title { get; set; }

        public List<Product> Products { get; set; }
    }
}
