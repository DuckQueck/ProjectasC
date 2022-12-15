using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public class Review
    {
        [Key]
        public Guid Id { get; set; }
        public string AuthorName { get; set; }
        public string ReviewText { get; set; }
        public int StarRating { get; set; }
        public DateTime ReviewCreated { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
