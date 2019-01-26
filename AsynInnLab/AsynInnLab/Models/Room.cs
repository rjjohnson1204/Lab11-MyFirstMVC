﻿using System;
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

        public ICollection<HotelRoom> HotelRoom { get; set; }
        public ICollection<RoomAmenities> RoomAmenities { get; set; }

    }

    public enum Layout
    {
        Studio,
        OneBedRoom,
        TwoBedRoom
    }
}
