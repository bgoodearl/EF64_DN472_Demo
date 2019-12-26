using System;
using System.ComponentModel.DataAnnotations;

namespace BGoodMusic.Models
{
    public class Rehearsal
    {
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public TimeSpan Time { get; set; }

        public Nullable<TimeSpan> Duration { get; set; }

        [Required(AllowEmptyStrings = true)]
        [MaxLength(512)]
        public string Location { get; set; }

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2048)]
        public string Agenda { get; set; }
    }
}
