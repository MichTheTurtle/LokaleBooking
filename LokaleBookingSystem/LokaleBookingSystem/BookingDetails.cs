using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace LokaleBookingSystem
{
    public class BookingDetails
    {
        public int ID;

        public DateTime StartTidspunkt;

        public DateTime SlutTidspunkt;

        public Lokale Lokale;

        public int BrugerID;

        public string Navn;
    }
}
