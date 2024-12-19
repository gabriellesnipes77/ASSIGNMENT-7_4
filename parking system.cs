using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace ASSIGNMENT_7_4
{
    internal class ParkingSystem
    {
        private Dictionary<int, int> parkingSpaces;


        //Constructor tp intialize the parking system
        public ParkingSystem(int big, int medium, int small)
        {

            //Intialize the parking system with parking spaces for each car type
            parkingSpaces = new Dictionary<int, int>
            {
                { 1, big },
                { 2, medium },
                { 3, small },
            };
        }

        //Method to add a car to the parking lot
        public bool AddCar(int carType)
        {
            // Check if the parking lot contians the carType and if there's an available space
            if (parkingSpaces.ContainsKey(carType) && parkingSpaces[carType] > 0)
            {
                //Decrease the available space for the given car type
                parkingSpaces[carType]--;
                return true;
            }
            return false;
        }
    }
}
 