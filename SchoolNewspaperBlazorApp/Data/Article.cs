using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolNewspaperBlazorApp.Data
{
    public class Article
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public required string Title { get; set; }

        [Required]
        public required string Text { get; set; }

        [Required]
        [StringLength(150)]
        public required string Author { get; set; }

        public DateTime PublishDate { get; set; } = DateTime.Now;

        public int FileID { get; set; }
    }
}