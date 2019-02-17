using MarketLocator.Interfaces.Database;
using MarketLocator.Interfaces.Services;

namespace MarketLocator.Services
{
    public class TrafficService : ITrafficService
    {
        private IDatabaseProvider database;

        public TrafficService(IDatabaseProvider database)
        {
            this.database = database;
        }

        public void GetFilteredLocations()
        {
            var p  = this.database.ReadCommand("GetFilteredTraffic", null);
        }
    }
}