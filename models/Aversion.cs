using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace cSharp2022.Models
{
    public class Aversion
    {
        [Key]
        public int AversionId { get; set; }
        public string MediaFilePath { get; set; }

        [Required]
        [Display(Name = "Title")]
        [MinLength(2, ErrorMessage = "minimum length 2 chars!")]

        public string Title { get; set; }
        public string Length { get; set; }
        public string Notes { get; set; }
        public int RecordisId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}