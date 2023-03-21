// See https://aka.ms/new-console-template for more information
using InheritanceExample;

Building building = new Bungalow();

try
{
    building.noOfFloors = 0;
    building.buildingType = "office";
    Console.WriteLine("Here are the building details:");
    Console.Write(building.GetBuildingDetails());
}
catch(ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}



