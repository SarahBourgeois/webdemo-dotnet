using MVC_WebSite.Models.EDM;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MVC_WebSite.Models
{
    public class ItemData
    {

        // name 
        [Required]
        [Display(Name = "Item name : ")]
        public string Name { get; set; }

        // description 
        [Required]
        [Display(Name = "Item description : ")]
        public string Description { get; set; }

        // new name 
        [Required]
        [Display(Name = "New name : ")]
        public string NewName { get; set; }

        // new description 
        [Required]
        [Display(Name = "New description : ")]
        public string NewDescription { get; set; }

        public List<Item> ItemList { get; set; }
    }
}