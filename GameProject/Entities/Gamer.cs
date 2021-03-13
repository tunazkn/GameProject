using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Gamer
    {
        public int Id { get; set; }
        public long IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthOfYear { get; set; }
    }
}
