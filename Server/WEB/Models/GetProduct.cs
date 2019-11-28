using System;
using System.ComponentModel.DataAnnotations;

namespace WEB.Models
{
    public class GetProduct
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Category { get; set; }
    }
}
