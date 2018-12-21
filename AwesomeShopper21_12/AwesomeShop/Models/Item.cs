using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AwesomeShop.Models /*Other name like "OperasWebSite.Models" ?*/
{
    public class Item
    {
        public int ItemID { get; set; }

        
        public int UserID { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string Title { get; set; }

        [DisplayName("Photo")]
        [MaxLength]
        [Required]
        public byte[] ItemPhoto { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string ImageMimeType { get; set; }

        
        public bool Sold { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Created Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
        
    }
}