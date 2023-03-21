using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    internal class Office : Building
    {
        public Office() 
        {
            buildingType = "commercial";
        }
        public override int noOfFloors { get; set; }
        public override string buildingType { get; set; }

        public override string GetBuildingDetails()
        {
            return "This is an office building containing " + noOfFloors + " floors. The current building type is: " + buildingType;
        }
    }
}
