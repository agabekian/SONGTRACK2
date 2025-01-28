using System;
using System.ComponentModel.DataAnnotations;

namespace cSharp2022.Models
{
    public class Comment
    {
        [Key] public int CommentId { get; set; }

        [MaxLength(64, ErrorMessage = "maxlength is 64 chars")]
        public string Title { get; set; }
        public string Content { get; set; }
        public int RecordisId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}