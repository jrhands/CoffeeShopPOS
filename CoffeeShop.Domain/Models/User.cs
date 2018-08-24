using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Domain.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [MinLength(2)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [RegularExpression(@"(?=.{8,})(?=.*?[^\w\s])(?=.*?[0-9])(?=.*?[A-Z]).*?[a-z].*", ErrorMessage = "Must be at least 8 characters and contain at least one of: lowercase letters, capital letters, numbers, special characters")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Favorite Menu Item")]
        public int ItemId { get; set; }

        [Display(Name = "Favorite Menu Item")]
        public virtual Item FavItem { get; set; }
    }
}
