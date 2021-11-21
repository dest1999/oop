using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingWork
{
    internal class Creator
    {
        //MSDN https://docs.microsoft.com/en-us/dotnet/api/system.collections.hashtable?view=net-5.0
        //We don't recommend that you use the Hashtable class for new development. Instead, we recommend that you use the generic Dictionary<TKey,TValue> class.
        public static Hashtable BuildingsStore { get; } = new();

        public static Building CreateBuild(double height, int floorsQuantity, int flatsQuantity, int entrancesQuantity)
        {
            Building building = new() 
            {
                EntrancesQuantity = entrancesQuantity, 
                Height = height, 
                FloorsQuantity = floorsQuantity, 
                FlatsQuantity = flatsQuantity
            };
            BuildingsStore.Add(building.GetHashCode(), building);
            return building;
        }

        public static Building CreateBuild()
        {
            Building building = new();
            BuildingsStore.Add(building.GetHashCode(), building);
            return building;
        }

        public static bool Delete(int id)
        {
            if (BuildingsStore.ContainsKey(id))
            {
                BuildingsStore.Remove(id);
                return true;
            }
            return false;
        }

        private Creator()
        {

        }
    }

}
