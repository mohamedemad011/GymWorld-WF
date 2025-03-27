using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymWorld.Models
{
    public class Membership
    {
        public int MembershipId { get; set; }
        public string Type {  get; set; } = string.Empty;
        public double Price {  get; set; }

    }
}
