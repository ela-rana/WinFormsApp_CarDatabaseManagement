//Create a database with a table “Car”. Add columns like VIN, Make, Model, Year, Price etc.
//Create a Windows forms app to display records in grid. Perform basic CRUD.
//CRUD: create, read, update, display: the basics actions performed on stored data
//db or DB: short for database
//LHS and RHS: short for left hand sid and right hand side respectively

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_CarDatabaseManagement
{
    interface CRUD
    {
        /// <summary>
        ///To add a new user input car record to the database where it is stored
        /// </summary>
        /// <param name="car">a car type object (record) to add to the database</param>
        void AddRecord(Car car);

        /// <summary>
        /// To delete a user selected record from the database where it is stored
        /// </summary>
        /// <param name="car">a car type object (record) to delete from the database</param>
        void DeleteRecord(Car car);

        /// <summary>
        /// To edit/update a user selected record in the database where it is stored
        /// </summary>
        /// <param name="vin">the VIN of the car record that needs to be updated</param> 
        /// /// <param name="car">the updated car record that you want to replace the old one with</param>
        void UpdateRecord(string vin,Car car);

        /// <summary>
        /// To find a record in the database when the VIN is given as argument and return the record as a car object
        /// </summary>
        /// <param name="vin">the VIN of the car user wants to find</param>
        /// <returns>the found car object or null if a record with the given vin is not found</returns>
        Car FindRecord(string vin); 

        /// <summary>
        /// Gets all the car records from the database and returns it as an ICollection list
        /// </summary>
        /// <returns>ICollection list of type car consisting of all Car records in our database</returns>
        ICollection<Car> GetAllRecords(); 

        /// <summary>
        /// To search for a passed VIN in the database to see if it is already in the database
        /// </summary>
        /// <param name="vin">the car VIN string</param>
        /// <returns>Boolean true if given VIN is in the database records, and false if not</returns>
        bool VINInDatabase(string vin); //to check if the passed vin is already in database
    }

    class CarRepository : CRUD
    {
        CarDBEntities1 entities;

        public CarRepository()
        {
            entities = new CarDBEntities1();
        }
        public void AddRecord(Car car)
        {
            entities.Cars.Add(car); //add car object to the DBSet ready to be updated to db
            entities.SaveChanges(); //saves changes causing above added object in the DBSet to be added in the actual db
        }

        public void DeleteRecord(Car car)
        {
            entities.Cars.Remove(car);  //remove the passed car record from the the DBSet, ready to be removed from the DB
            entities.SaveChanges(); //save changes causing the record deleted in the DBSet to actually be deleted from the DB
        }
        public void UpdateRecord(string vin, Car car)
        {
            //the reason we pass the vin and the Car object that already has a vin in it separately is in case the vin itself was
            //wrong
            Car carToUpdate = entities.Cars.Find(vin);
            carToUpdate.VIN = car.VIN;
            car
        }

        public Car FindRecord(string vin)
        {
            return entities.Cars.Find(vin); //searches for the passed VIN in the DBSet. If found returned, else returns null
        }

        public ICollection<Car> GetAllRecords()
        {
            return entities.Cars.ToList();  //gets and returns all car records from our DBSet which gets it from the actual db
        }

        public bool VINInDatabase(string vin)
        {
            Car temp = entities.Cars.Find(vin); //LHS: temporary car record to hold search result
                                                //RHS: seraches for a record with the given vin, if not found returns null
            if (temp == null)   //if temp record is null, means record with that vin not found
                return false;   //then return false for VINInDatabase
            else
                return true;    //otherwise (if found), return true for VINInDatabase
        }
    }
}
