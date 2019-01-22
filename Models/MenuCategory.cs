using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NavBarOtherMethod.Models
{
    [Table(name:"Menus")]
    public class MenuCategory:BaseMenu
    {
        public MenuCategory()
        {
            News = new HashSet<News>();
        }

        public ICollection<News> News { get; set; }
    }
}