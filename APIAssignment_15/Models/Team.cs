using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIAssignment_15.Models
{
    [Table("Teams")]
    public class Team
    {
        [Key]
         
         public string TId { get; set; }
         [Required]
         [StringLength(50)]

         public string TName { get; set; }
         [Required]
         public String TEmail { get; set; }
         [Required]
         [StringLength(50)]

          public string TSlogan { get; set; }
        
    }
}