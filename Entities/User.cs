using System.ComponentModel.DataAnnotations;

namespace Entities
  
{
    public class User
    {
        public int UserId { get; set; }

        [EmailAddress]
        public string UserName { get; set; }

        [StringLength(20, ErrorMessage = "name between 5-20", MinimumLength = 5)]
        public string Password { get; set; }
        public string FirstName { get; set; }
     
        public string LastName { get; set; }
    }
}
