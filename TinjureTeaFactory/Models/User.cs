using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TinjureTeaFactory.Models
{
    public class User
    {

        [Required, MinLength(2, ErrorMessage = "Minimun length is 2")]

        [Display(Name= "Username")]
        public string UserName { get; set; }



        [Required, EmailAddress]

        public string Email { get; set; }


        [DataType(DataType.Password), Required, MinLength(4, ErrorMessage = "Minimun length is 4")]

        public string Password { get; set; }

        public User() { }

       
    }
}
