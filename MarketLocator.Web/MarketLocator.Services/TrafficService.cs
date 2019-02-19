using MarketLocator.Interfaces.Database;
using MarketLocator.Interfaces.Services;
using MarketLocator.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MarketLocator.Services
{
    public class TrafficService : ITrafficService
    {
        private const string filteredTrafficProcedure = "GetFilteredTraffic";

        private IDatabaseProvider database;

        public TrafficService(IDatabaseProvider database)
        {
            this.database = database;
        }

        public List<Traffic> GetFilteredLocations(string gender, int minimumAge, int maximumAge, DateTime date)
        {
            List<Traffic> listTraffic = new List<Traffic>();

            SqlDataReader result = this.database.ReadCommand(filteredTrafficProcedure, gender, minimumAge, maximumAge, date);

            while (result.Read())
            {
                listTraffic.Add(
                    new Traffic
                    {
                        ANumber = result.GetValue(0).ToString(),
                        CellLat = decimal.Parse(result.GetValue(4).ToString()),
                        CellLong = decimal.Parse(result.GetValue(5).ToString())
                    }
                );
            }

            return listTraffic;
        }
    }
}