using System;

namespace cSharp2022.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}