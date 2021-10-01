using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    //Create a Vehicle class which has three subclasses in a vehicle namespace:
    //Car
    //Motorbike
    //Truck
    //You should have at least 3 encapsulated fields(you will require public getters and setters 
    //as private fields are not inherited, but the getters and setters will be and they will still
    //have access to the field) or properties on your Vehicle class which the subclasses inherit from, 
    //these must be used in the ToString() method of each subtype for printing information about the Vehicle.

    //4. Instantiate an instance of each type of Vehicle and print its ToString() method to the console

    //    Create a Garage class that can store a list of Vehicle with methods for the following:
    //Adding a new Vehicle to the garageRemoving a Vehicle from the garage by idRemove all Vehicles
    //of a certain typeEmpty garage which removes all vehicles
    //The methods for adding and removing vehicles should call the vehicles ToString() method

    class Vehicle
    {
        private string vehicleName;
        private string manufacturer;
        private string dateManufactured;

        public string Name
        {
            get { return vehicleName; }
            set { vehicleName = value; }
        }

        public string Made
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public string Date
        {
            get { return dateManufactured; }
            set { dateManufactured = value; }
        }

        //--------get/set vehicle name
        //public string GetVehicleName()
        //{
        //    return vehicleName;
        //}
        //public void SetVehicleName(string vehicleName)
        //{
        //    this.vehicleName = vehicleName;
        //}
        //--------get/set manufacture
        //public string GetManufacturer()
        //{
        //    return manufacturer;
        //}
        //public void SetManufacturer(string manufacturer)
        //{
        //    this.manufacturer = manufacturer;
        //}
        ////--------get/set date manufactured
        //public string GetDateManufactured()
        //{
        //    return dateManufactured;
        //}
        //public void SetDateManufactured(string dateManufactured)
        //{
        //    this.dateManufactured = dateManufactured;
        //}

        //--------set up them instances son
        public Vehicle(string vehicleName, string manufacturer, string dateManufactured)
        {
            this.vehicleName = vehicleName;
            this.manufacturer = manufacturer;
            this.dateManufactured = dateManufactured;
        }
        public Vehicle()
        {
        }
        //-----that's that info mmmmmm tasty
        public string GetInfo()
        {
            return $"{vehicleName} Vehicle, is made by: {manufacturer} in  year: {dateManufactured}.";
        }

    }

    class Car : Vehicle
    {
        
        public Car(string VehicleName, string manufacturer, string dateManufactured)
        {
            this.Name = VehicleName;
            this.Made = manufacturer;
            this.Date = dateManufactured;
        }
        public Car()
        {
        }

        public string GetInfoCar()
        {
            return $"{Name.ToString()} Car, is made by: {Made.ToString()} in  year: {Date.ToString()}.";
        }
    }

    class Motorbike : Vehicle
    {
    }

    class Truck : Vehicle
    {
    }




}
