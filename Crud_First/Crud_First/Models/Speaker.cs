using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_First.Models
{
    public class Speaker
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Name")]
        public string SpeakerName { get; set; }

        [Required]
        [StringLength(100)]
        public string Qualification { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Time")]
        public DateTime SpeakTime { get; set; }

          [Required]
        [StringLength(250)]
        public string Venue { get; set; }

          [Required]
        [Display(Name = "Image")]
        public string ProfilePicture { get; set; }
    }
}
