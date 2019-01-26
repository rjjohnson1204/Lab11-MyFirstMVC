using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsynInnLab.Models
{
    public class RoomAmenities
    {
        public int AmenitiesID { get; set; }
        public int RoomID { get; set; }



        //navigation properties
        public Amenities amenities { get; set; }
        public Room room { get; set; }
    }
}
