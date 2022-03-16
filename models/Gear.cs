using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace cSharp2022.Models
{
    public class Gear //I can call it whatever, it's just a handle for what'll be a db table based on it's contents
    {
        [Key]
        public int GearId { get; set; }

        [Required]
        [Display(Name = "Name")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters long")]
        public string title { get; set; }

        [Required]
        [Display(Name = "Gear description")]
        [MinLength(2, ErrorMessage = "The description is required")]
        public string desc { get; set; }

        [Required]
        [Display(Name = "Role description", Prompt ="Producer, Bass, etc")]
        [MinLength(2, ErrorMessage = "The description is required")]
        public string role { get; set; }

        public List<Connect> Recs { get; set; }
        public List<Album> Images { get; set; }//nav prop
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}