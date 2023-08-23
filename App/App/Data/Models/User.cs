using App.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Data.Models
{
    public class User
    {

        public long Id { get; set; }

   
        public string UserName { get; set; }

        public string Password { get; set; }

        public long RoleId { get; set; }

    
        public virtual UserRole Role { get; set; }
    }
}



