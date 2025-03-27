using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GymWorld.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password {  get; set; } = string.Empty;

        public int? TrainerId { get; set; }
        public Trainer? Trainer { get; set; }

        public int MembershipId {  get; set; }
        public Membership Membership { get; set; } 


    }
}
