using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SampleJson
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Password { get; set; }
        [EmailAddress(ErrorMessage = "El correo electrónico no es válido.")]
        public string Email { get; set; }

        public Usuario(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }
       
    }

}
