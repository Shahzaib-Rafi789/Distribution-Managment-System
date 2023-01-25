using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribution_Managment_System.BL
{
    class Vehicle
    {
        private string vehicleNumber;
        private string chassis;
        private float fuelCapacity;
        private string Type;
        private string Color;
        private bool IsAssigned;
        private bool IsOut;
        private float fuelquantity;
        private float fuelsum=0;

        public Vehicle(string Vehicleid)
        {
            this.VehicleNumber = Vehicleid;      
        }

        public Vehicle(string vehicleNumber, string chassis, string Type, float fuelCapacity, string Color)
        {
            this.vehicleNumber = vehicleNumber;
            this.chassis = chassis;
            this.Type = Type;
            this.fuelCapacity = fuelCapacity;
            this.Color = Color;
            IsAssigned= true;
            Fuelquantity = 0;

        }


        public string VehicleNumber { get => vehicleNumber; set => vehicleNumber = value; }
        public string Chassis { get => chassis; set => chassis = value; }
        public float FuelCapacity { get => fuelCapacity; set => fuelCapacity = value; }
        public string Type1 { get => Type; set => Type = value; }
        public string Color1 { get => Color; set => Color = value; }
        public bool IsAssigned1 { get => IsAssigned; set => IsAssigned = value; }
        public bool IsOut1 { get => IsOut; set => IsOut = value; }
        public float Fuelquantity { get => fuelquantity; set => fuelquantity = value; }

        public float refuel(float fuel)
        {
            if (fuelsum < fuelCapacity)
            {
                fuelsum += fuel;
                
            }
            return fuelsum;
        }

        public float GetFuelConsumed(float Currentfuel)
        {
            if (fuelsum > 0)
            {
                fuelsum -= Currentfuel;
                return fuelsum;
            }
            return 0;
        }

    }
}
