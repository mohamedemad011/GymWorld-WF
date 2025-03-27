using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymWorld.Models
{
    public class ClassEquipment
    {
        public int GymClassId {  get; set; }

        public Class GymClass { get; set; }
        public int EquipmentId {  get; set; }
        public Equipment Equipment { get; set; } 
    }
}
