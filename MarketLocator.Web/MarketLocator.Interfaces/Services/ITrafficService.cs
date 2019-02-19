using MarketLocator.Models;
using System;
using System.Collections.Generic;

namespace MarketLocator.Interfaces.Services
{
    public interface ITrafficService
    {
        List<Traffic> GetFilteredLocations(string gender, int minimumAge, int maximumAge, DateTime date);
    }
}