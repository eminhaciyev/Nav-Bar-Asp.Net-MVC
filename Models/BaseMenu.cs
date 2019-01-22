using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NavBarOtherMethod.Models
{
    public class BaseMenu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [StringLength(maximumLength: 50, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [StringLength(maximumLength: 50, MinimumLength = 5)]
        [Required]
        public string Url { get; set; }

        [Required]
        public bool IsVisible { get; set; }

        [Required]
        public int Order { get; set; }
    }
}