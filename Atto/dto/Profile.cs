using AttoProject.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AttoProject.dto
{
    public class Profile
    {
        //name,surname,phone unique, pswd, created_date, status, role
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; } 
        public string Role { get; set; }



    }
}

