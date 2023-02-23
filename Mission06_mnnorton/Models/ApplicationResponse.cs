using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_mnnorton.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required]
        public string MovieTitle { get; set; }
        [Required]
        public string Rating { get; set; }
        public int YearRelease { get; set; }
        public string Director { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }

        //Build FK here
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
