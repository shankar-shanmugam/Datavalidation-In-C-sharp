using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegularExpressionInC_
{
    internal class Product
    {
        [Required(ErrorMessage ="must to enter the id ")]
        public int Id {  get; set; }
        [Required]                                                    // default error message will be shown if we not override errormessage
        public string Name { get; set; }
        [Required(ErrorMessage = "must to enter the productnumber ")]
        public string ProductNumber { get; set; }
        [Required(ErrorMessage = "must to enter the {0} ")]               
        public string color { get; set; }
        [Required(ErrorMessage = "must to enter the {0} ")]
        public decimal ListPrice { get; set; }
        [Required(ErrorMessage = "must to enter the sellEndDate ")]
        public DateTime sellEndDate { get; set; }


    }
}
