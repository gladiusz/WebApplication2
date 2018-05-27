using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Podaj Login")]
        [MaxLength(200)]
        public string Login { get; set; }
        [Required(ErrorMessage = "Podaj Haslo")]
        [MaxLength(200)]
        public string Password { get; set; }
    }
}