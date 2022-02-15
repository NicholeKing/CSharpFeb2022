using System.ComponentModel.DataAnnotations;

namespace linqDemo.Models
{
    public class Game
    {
        public string Title {get;set;}
        public string Genre {get;set;}
        public double Price {get;set;}
        public string Rating {get;set;}
        public string[] Platforms {get;set;}
    }
}