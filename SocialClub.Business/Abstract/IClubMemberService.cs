using SocialClub.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialClub.Business.Abstract
{
    public interface IClubMemberService
    {
        List<ClubMember> GetAll();
        //List<ClubMember> GetClubMember
        void Add(ClubMember clubMember);
        void Delete(ClubMember clubMember);
        void Update(ClubMember clubMember);
    }
}
