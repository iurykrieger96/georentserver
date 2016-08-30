﻿using System;

namespace GeoRent.Domain.Entities
{
    public class Residence
    {
        public Residence()
        {
            idResidence = Guid.NewGuid();
        }

        public Guid idResidence { get; set; }

        public virtual User idUser { get; set; }
        public virtual Location idLocation { get; set; }
        public virtual Preference idResidencePreference { get; set; }
    }
}