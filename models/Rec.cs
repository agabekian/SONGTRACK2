using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace cSharp2022.Models
{
    public class Recordis //I can call it whatever, since it's just a handle for what will buil out a table based on it's contents
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
        [Display(Name = "artisto", Prompt ="Armasconi")]
        [MinLength(1, ErrorMessage = "Artisto name required")]
        public string artist { get; set; }

        
        public string fileName {get; set;}

        public string MediaFilePath { get; set; }
        public List<Connect> Gears { get; set; }//nav props
        public List<Comment> Comments { get; set; }
        public List<Aversion> Aversions { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    }
}