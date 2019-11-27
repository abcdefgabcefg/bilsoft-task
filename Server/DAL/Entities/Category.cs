using System.Collections.Generic;

namespace DAL.Entities
{
    public class Category : EntityBase
    {
        public string Title { get; set; }

        public List<Product> Products { get; set; }
    }
}
