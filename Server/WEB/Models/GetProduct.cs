using System;
using System.ComponentModel.DataAnnotations;

namespace WEB.Models
{
    public class GetProduct
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }
    }
}
