using System.ComponentModel.DataAnnotations;

namespace afternoondemo.Models
{
    public class Character
    {
        [NoZNames]
        [NoFoulLanguage]
        [Required(ErrorMessage = "Name is required!")]
        public string name {get;set;}

        [Required]
        public string race {get;set;}
        
        [Required(ErrorMessage = "Age is required!")]
        public int age {get;set;}
    }

    public class NoZNamesAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (((string)value).ToLower()[0] == 'z')
                return new ValidationResult("No names that start with Z allowed!");
            return ValidationResult.Success;
        }
    }

    public class NoFoulLanguageAttribute : ValidationAttribute
    {
        string[] badWords = {"heffamoose", "blart", "sucks", "apple", "sour", "salty", "cage", "flock", "grundle", "beans"};
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            foreach(string b in badWords)
            {
                if (((string)value).Contains(b))
                    return new ValidationResult("That's a bad word!");
            }
            return ValidationResult.Success;
        }
    }
}