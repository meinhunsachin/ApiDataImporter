using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace ApiDataImporter.Models
{

    public class Article
    {
        [Key]
        public string Id { get; set; } = "";

        [Required]
        public string? Journal { get; set; }

        [Required]
        public string? Eissn { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime PublicationDate { get; set; }

        [Required]
        public string? ArticleType { get; set; }

        // [NotMapped]
        [Required]
        public List<Author>? AuthorDisplay { get; set; }

        // [NotMapped]
        public List<Abstract>? Abstract { get; set; }

        [Required]
        [MaxLength(255)] // Adjust the length as needed
        public string? TitleDisplay { get; set; }

        [Required]
        public double Score { get; set; }
    }


    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorId { get; set; }
        public string? Name { get; set; }
    }

    public class Abstract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AbstractId { get; set; }
        public string? Content { get; set; }
    }
}