using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MinhaLojaVirtual.Models
{
    public class UserModel: IdentityUser
    {
        public UserModel()
        {
            
        }
        public UserModel(string name, string email, string password, string role)
        {
            this.id = new Guid();
            this.name = name;
            this.email = email;
            this.password = password;
            this.role = role;
        }

        public UserModel(string name, string email, string password)
        {
            this.id = new Guid();
            this.name = name;
            this.email = email;
            this.password = password;
            this.role = "client";
        }


        public Guid id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }
        public string role { get; set; }
    }
}
