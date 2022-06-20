using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirportApp
{
    [Table("User")]
    public partial class User
    {
        public User()
        {
            Admin = false;
        }

        public User(string Name, string Surname, string Email, byte[] Password, DateTime Birthday, string Gender)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Email = Email;
            this.Password = Password;
            this.Birthday = Birthday;
            this.Gender = Gender;
            Admin = false;
        }
        public User(string Name, string Surname, string Email, byte[] Password)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Email = Email;
            this.Password = Password;
            Admin = false;
        }
        public int ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }
        [MaxLength(100)]
        [MinLength(5)]
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public Boolean Admin { get; set; }
        public DateTime? Birthday { get; set; }
        public string Gender { get; set; }
        public void Update(string name, string surname, string email, string gender, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Gender = gender;
            Birthday = birthday;
        }
        public void Update(string name, string surname, string email, string gender, DateTime birthday, byte[] password)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Gender = gender;
            Birthday = birthday;
            Password = password;
        }
        public override string ToString()
        {
            return $"{Name} {Surname} {Email} {Admin}";
        }
    }
}
