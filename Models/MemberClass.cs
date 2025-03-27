using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymWorld.Models
{
    public class MemberClass
    {
        public int MemberId {  get; set; }
        public Member Member { get; set; } 
        public int ClassId { get; set; }
        public Class Class { get; set; } 
    }
}
