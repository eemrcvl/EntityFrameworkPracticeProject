using SocialClub.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialClub.Entities.Concrete
{
    public class ClubMember:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        //FORGOT TO ADD TO DATABASE ADD IT
        public string Occupation { get; set; } 
        public Nullable<decimal> Salary { get; set; }
        public string MaritalStatus { get; set; }
        public string HealthStatus { get; set; }
        public Nullable<int> NumberOfChildren { get; set; }
    }
}
