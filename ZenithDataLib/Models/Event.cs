using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithDataLib.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Display(Name = "Date")]
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string EnteredBy { get; set; }
        
        [ForeignKey("ActivityCategoryId")]
        [Display(Name = "Activity")]
        public ActivityCategory ActivityCategory { get; set; }
        public int ActivityCategoryId { get; set; }
        public DateTime CreationDate { get; set; }
        public Boolean IsActive { get; set; }
    }
}
