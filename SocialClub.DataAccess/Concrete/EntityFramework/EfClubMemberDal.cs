using SocialClub.DataAccess.Abstract;
using SocialClub.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialClub.DataAccess.Concrete.EntityFramework
{
    public class EfClubMemberDal : EfEntityRepositoryBase<ClubMember, SocialClubContext>, IClubMemberDal
    {

    }
}