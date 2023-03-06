﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetero.Domain.Entities.WeatherData;

namespace Vetero.Application.Common.Interfaces
{
    public interface IVeteroDbContext
    {
        DbSet<WeatherStationData> WeatherStationData { get; set; }
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
    }
}
