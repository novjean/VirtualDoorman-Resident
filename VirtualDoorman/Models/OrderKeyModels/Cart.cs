using System;
using System.Collections.Generic;

namespace VirtualDoorman.Models
{
    public class Cart
    {
        public List<OrderKey> keys = new List<OrderKey>();
        public string loginGUID { get; set; }
		public int fobCount { get; set; }
		public int cardCount { get; set; }
		public int totalKeys { get; set; }
		public bool keysForGuest { get; set; }
        
        public Cart()
        {
        }
    }
}
