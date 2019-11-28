using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Category : EntityBase
    {
        [Required]
        public string Title { get; set; }
    }
}
