using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApp.Models
{
    [Table("People")]
    public class User
    {
        [DisplayName("User ID")] // annotaction to customize the view filed names
        public int Id { get; set; }
        //[Column(name:"First_Name", TypeName="ntext")]
        [Required(ErrorMessage = "Input Name")]
        [MinLength(2)]
        public string Name { get; set; }
       
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
       
        public User() 
        { 
        }

        public User(int id, string name, string email, string password, bool status)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Status = status;
           
        }
    }
}
