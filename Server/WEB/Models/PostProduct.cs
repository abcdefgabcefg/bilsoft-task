using System;
using System.ComponentModel.DataAnnotations;

namespace WEB.Models
{
    public class PostProduct
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public Guid Category { get; set; }
    }
}
