using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AwesomeShop.Models /*Other name like "OperasWebSite.Models" ?*/
{
    public class Item
    {
        public int ItemID { get; set; }

        //[Required]?
        public string Title { get; set; } /*Stringlenth?*/

        /*NAME? ADD TIL CLASS DIAGRAM?*/

        /*Photo? which filetype?*/

        //[Required]?
        public int Price { get; set } /*Double/float instead?*/

        //[Required]?
        public int UserID { get; set; } /*Have this?*/

        //[Required]?
        public bool Sold { get; set; }

        /*METHODS*/

        //Stuff like
        //public class CheckValidYear : ValidationAttribute
        //?
    }
}