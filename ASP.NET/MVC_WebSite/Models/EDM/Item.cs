namespace MVC_WebSite.Models.EDM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Item")]
    public partial class Item
    {
        public int Id { get; set; }

        public int user { get; set; }

        [Required]
        public string name { get; set; }

        public string description { get; set; }

        public virtual User User1 { get; set; }
    }
}
