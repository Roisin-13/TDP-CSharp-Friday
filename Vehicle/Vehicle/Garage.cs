using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    //    Create a Garage class that can store a list of Vehicle with methods for the following:
    //Adding a new Vehicle to the garageRemoving a Vehicle from the garage by idRemove all Vehicles
    //of a certain typeEmpty garage which removes all vehicles
    //The methods for adding and removing vehicles should call the vehicles ToString() method

    class Garage
    {
        //------list set up
       private IList<Vehicle> myGarage = new List<Vehicle>();

        //public List<Vehicle> GetList()
        //{
        //    return (List<Vehicle>)myGarage;
        //}

        //---Adding method
        public void AddVehicle(Vehicle vehicle)
        {
            myGarage.Add(vehicle);
        }

        public Vehicle getVehicleByID(int vehicle)
        {
            return myGarage[vehicle]        ;
        }


    }
}
