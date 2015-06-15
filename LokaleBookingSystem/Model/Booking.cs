﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Booking
    {
        public int BookingID { get; set; }

        public DateTime Tidspunkt { get; set; }

        public virtual Lokale Lokale { get; set; }

        public virtual Bruger Bruger { get; set; }

    }
}
