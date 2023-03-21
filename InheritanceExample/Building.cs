using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    internal abstract class Building
    {
        public abstract int noOfFloors { 
            get; 
            set; 
        }        
        public abstract string buildingType { get; set; } //e.g. residential or commercial

        public abstract string GetBuildingDetails();
    }
}
