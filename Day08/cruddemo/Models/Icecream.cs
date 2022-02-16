using System;
using System.ComponentModel.DataAnnotations;

namespace cruddemo.Models
{
    public class Icecream
    {
        // The Key is required because we need a primary key in MySQL
        [Key]
        public int IcecreamId {get;set;}

        // Here are our attributes
        [Required]
        public string Flavor {get;set;}
        [Required]
        public string Topping {get;set;}
        [Required]
        public bool hasCherry {get;set;}
        [Required]
        public string Container {get;set;}

        // Don't forget your createdAt and updatedAt
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}