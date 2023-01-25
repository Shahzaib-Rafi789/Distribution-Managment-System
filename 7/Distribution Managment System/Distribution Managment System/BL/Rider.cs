using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribution_Managment_System.BL
{
    class Rider
    {
        private string Name;
        private string DriverID;
        private string Region;
        private double Phonenum;
        Vehicle TransportVehicle;

        public Rider(string driverID,string name, string Vehicleid, string region, double phonenum)
        { 
            Name = name;
            DriverID = driverID;
            Region = region;
            Phonenum = phonenum;
            Vehicle vehicle= new Vehicle(Vehicleid);  
            
        }

        public string Name1 { get => Name; set => Name = value; }
        public string DriverID1 { get => DriverID; set => DriverID = value; }
        public string Region1 { get => Region; set => Region = value; }
        public double Phonenum1 { get => Phonenum; set => Phonenum = value; }
        Vehicle TransportVehicle1 { get => TransportVehicle; set => TransportVehicle = value; }


    }
}
