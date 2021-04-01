using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="Length of Sentence should be less than or equal to 50")]
        public string HowTo { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Length of Sentence should be less than or equal to 50")]
        public string Line { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Length of Sentence should be less than or equal to 50")]
        public string Platform { get; set; }
    }
}
