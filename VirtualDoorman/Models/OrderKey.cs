using System;
using System.ComponentModel;

namespace VirtualDoorman.Models
{
    public class OrderKey
    {
        public string resident_id { get; set; }
        public string visitor_id { get; set; }
        public string card_type { get; set; }
        public string package_room_access { get; set; }
        public string front_door_access { get; set; }

        public string shipping_fullname { get; set; }
        public string shipping_phone { get; set; }
        public string shipping_street { get; set; }
        public string shipping_apartment_number { get; set; }
        public string shipping_state { get; set; }
        public string shipping_country { get; set; }
        public string shipping_zip { get; set; }

       
    }
}
