using System;
using System.ComponentModel.DataAnnotations;

namespace WEB.Models
{
    public class PostProduct
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public Guid? Category { get; set; }
    }
}
