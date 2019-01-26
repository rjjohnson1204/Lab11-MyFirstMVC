using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsynInnLab.Models
{
    public class Amenities
    {
        public int ID { get; set; }
        public string Name { get; set }


        //navigation properties

        public ICollection<RoomAmenities> roomAmenities { get; set; }

    }
}
