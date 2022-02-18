using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OneToMany.Models
{
    public class Person
    {
        [Key]
        public int PersonId {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        [Range(18,10000, ErrorMessage = "You must be at least 18 to own these creatures!")]
        public int Age {get;set;}

        public List<Creature> Pets {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}