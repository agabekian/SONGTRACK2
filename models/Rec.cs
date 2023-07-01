using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace cSharp2022.Models
{
    public class Recordis
    {
        [Key]
        public int RecordisId { get; set; }

        [Required]
        [Display(Name = "title")]
        [MinLength(2, ErrorMessage = "minimum length 2 chars!")]
        public string title { get; set; }

        [Required]
        [Display(Name = "desc")]
        [MinLength(2, ErrorMessage = "minimum length 2 chars!")]
        public string desc { get; set; }

        [Required]
        [Display(Name = "length")]
        [MinLength(2, ErrorMessage = "minimum length 2 chars!")]
        public string length { get; set; }
        

        [Required]
        [Display(Name = "artist", Prompt ="Armasconi")]
        [MinLength(1, ErrorMessage = "Artist name required")]
        public string artist { get; set; }
        public string fileName {get; set;}
        public string MediaFilePath { get; set; }
        public List<Connect> Gears { get; set; }//nav props
        public List<Comment> Comments { get; set; }
        public List<Aversion> Aversions { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}