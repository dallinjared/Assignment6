using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment5.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        [RegularExpression("[0-9]*[-| ][0-9]*[-| ][0-9]*[-| ][0-9]*[-| ][0-9]*")]
        public string ISBN { get; set; }
        public string Classification { get; set; }
        public double Price { get; set; }
        public int Pages { get; set; }
    }
}
