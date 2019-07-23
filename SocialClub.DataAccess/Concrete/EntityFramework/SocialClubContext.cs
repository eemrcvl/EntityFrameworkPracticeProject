using SocialClub.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialClub.DataAccess.Concrete.EntityFramework
{
    public class SocialClubContext:DbContext
    {
        public DbSet<ClubMember> clubMembers { get; set; }
    }
}
