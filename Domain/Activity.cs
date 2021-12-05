using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Activity
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(50)]
        public string? Title { get; set; }
        public DateTime Date { get; set; }

        [StringLength(100)]
        public string? Description { get; set; }

        [StringLength(100)]
        public string? Category { get; set; }

        [StringLength(100)]
        public string? City { get; set; }

        [StringLength(100)]
        public string? Venue { get; set; }
    }
}