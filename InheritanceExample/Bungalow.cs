using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    internal class Bungalow : Building
    {
        public Bungalow() 
        {
            noOfFloors = 1;
            buildingType = "residential";
        }

        private int _noOfFloors;

        public override int noOfFloors
        {
            get
            {
                return _noOfFloors;   
            }
            set 
            {
                if (value > 1 || value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(noOfFloors), "A bungalow can only have 1 floor.");
                }
                else
                {
                    _noOfFloors = value;
                }
            } 
        }
        public override string buildingType { get; set; }

        public override string GetBuildingDetails()
        {
            return "Building type is: " + buildingType + ". Number of floors: " + _noOfFloors + ". It is a bungalow.";
        }
    }
}
