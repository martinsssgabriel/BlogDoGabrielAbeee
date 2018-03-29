using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogDoGabrielAbee.Models
{
    public class Post
    {
    
        public int Id { get; set; }
        [Required]
        [StringLength(500)]
        public string title { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }
        [Required]
        [StringLength(8000)]
        public string PostingBody { get; set; }
    }
}