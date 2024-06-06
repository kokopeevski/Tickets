using System;
using System.Collections.Generic;

#nullable disable

namespace Tickets.Models
{
    public partial class Flight
    {
        public int Id { get; set; }
        public int FlightNumber { get; set; }
        public string Destination { get; set; }
        public float Price { get; set; }
    }
}
