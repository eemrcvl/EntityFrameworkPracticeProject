using SocialClub.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialClub.DataAccess.Abstract
{
    public interface IClubMemberDal:IEntityRepository<ClubMember>
    {
    }
}
