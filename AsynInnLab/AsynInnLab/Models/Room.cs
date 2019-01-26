using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsynInnLab.Models
{
    public class Room
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Layout { get; set; }


        //navigation properties

        public HotelRoom hotelRoom { get; set; }
        public RoomAmenities roomAmenities { get; set; }

    }
}
