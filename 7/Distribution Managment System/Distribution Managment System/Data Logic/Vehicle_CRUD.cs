using Distribution_Managment_System.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribution_Managment_System.Data_Logic
{
    class Vehicle_CRUD
    {
        private static List<Vehicle> VehicleList = new List<Vehicle>();

        public static void Add(Vehicle vehicle)
        {
            VehicleList.Add(vehicle);
        }

        public static void Load()
        {
            try
            {
                string filePath = "E:\\Semester 3\\final\\Distribution Managment System\\vehicles.csv";
                StreamReader reader = null;
                if (File.Exists(filePath))
                {
                    reader = new StreamReader(File.OpenRead(filePath));
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        VehicleList.Add(new Vehicle(values[0], values[1], values[2],float.Parse(values[3]),values[4]));
                    }
                }
                reader.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Data not loaded into list", ex.Message);
            }
        }



        public static Vehicle Retrieve(String id)
        {
            foreach (Vehicle automobile in VehicleList.ToList())
            {
                if (id == automobile.VehicleNumber)
                {
                    return automobile;
                }
            }
            return null;
        }

        public static bool Delete(String id)
        {
            foreach (Vehicle automobile in VehicleList.ToList())
            {
                if (id == automobile.VehicleNumber)
                {
                    VehicleList.Remove(automobile);
                    return true;
                }
            }
            return false;
        }

        public static void Update(Vehicle oldvehicle, Vehicle newvehicle)
        {
            foreach (Vehicle automobile in VehicleList.ToList())
            {
                if (automobile==oldvehicle)
                {
                   oldvehicle.VehicleNumber= newvehicle.VehicleNumber;
                   oldvehicle.Chassis=newvehicle.Chassis;
                   oldvehicle.Type1=newvehicle.Type1;
                   oldvehicle.FuelCapacity=newvehicle.FuelCapacity;
                   oldvehicle.Color1=newvehicle.Color1;
                }
            }   
        }


    }
}
