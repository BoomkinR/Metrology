using System;
using System.Collections.Generic;
using Metrology.Models;

namespace Metrology.Models.Dtos
{
    public class UserDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PatrName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime RegistrationDate { get; set;}
        public string Phone { get; set; }
        public Role Role { get; set; }
        public string FullName { get => Surname + " " + Name + " " + PatrName; }
    }
}