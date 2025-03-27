using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymWorld.Models
{
    public class TrainerMember
    {
        public int TrainerId {  get; set; }
        public Trainer Trainer {  get; set; } 
        public int MemberId {  get; set; }
        public Member Member { get; set; } 
    }
}
