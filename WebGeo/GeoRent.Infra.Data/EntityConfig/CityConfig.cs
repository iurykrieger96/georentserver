﻿using GeoRent.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GeoRent.Infra.Data.EntityConfig
{
    public class CityConfig : EntityTypeConfiguration<City>
    {
        public CityConfig()
        {
            ToTable("City");
        }
    }
}