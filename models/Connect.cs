using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace cSharp2022.Models
{
    public class Connect
    {
        public int ConnectId {get;set;}
        public int GearId {get; set;}
        public int RecordisId{get;set;}
        public Gear Gear{get;set;}
        public Recordis Recordis {get;set;}
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}