using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NavBarOtherMethod.Models
{
    public class News
    {       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(maximumLength:1000,MinimumLength = 3)] 
        [Required]
        public string Title { get; set; }

        [StringLength(maximumLength: 1000, MinimumLength = 3)]
        [Required]
        public string Body { get; set; }

        public string Photo { get; set; }
        
        [Required]
        public bool IsVisible { get; set; }

        [Required]
        public int Order { get; set; }


       
        public MenuCategory menuCategory { get; set; }

        [Required]
        public int MenuCategoryId { get; set; }
    }
}