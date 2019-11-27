using System;

namespace DAL.Entities
{
    public class Product : EntityBase 
    {
        public string Title { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
