using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace cSharp2022.Models
{
    public class Album
    {
        public int AlbumId {get;set;}
        public int ImageId {get; set;}
        public int GearId{get;set;}
        public Image Image {get;set;}
        public Gear Gear{get;set;}
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}