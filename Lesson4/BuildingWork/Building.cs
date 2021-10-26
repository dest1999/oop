using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingWork
{
    internal class Building
    {
        static private int buildCounter;
        
        private int buildNumber;
        private double height;
        private int floorsQuantity;
        private int flatsQuantity;
        private int entrancesQuantity;

        public double Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
            }
        }

        public int FloorsQuantity
        {
            set
            {
                if (value > 0)
                {
                    floorsQuantity = value;
                }
            }
        }

        public int FlatsQuantity
        {
            set
            {
                if (value > 0)
                {
                    flatsQuantity = value;
                }
            }
        }

        public int EntrancesQuantity
        {
            set
            {
                if (value > 0)
                {
                    entrancesQuantity = value;
                }
            }
        }

        public Building()
        {
            SetBuildNumber();
        }


        public double FloorHeight()
        {
            return height / floorsQuantity;
        }

        public int FlatsInEntrance()
        {
            return flatsQuantity / entrancesQuantity;
        }

        public int FlatsInFloor()
        {
            return FlatsInEntrance() / floorsQuantity;
        }

        public override string ToString()
        {
            return 
                $"Building No: {buildNumber}\n" +
                $"Building height: {height}\n" +
                $"Building floors: {floorsQuantity}\n" +
                $"Building flats: {flatsQuantity}\n" +
                $"Building entrances: {entrancesQuantity}";
        }

        private void SetBuildNumber()
        {
            buildNumber = ++buildCounter;
        }

    }
}
