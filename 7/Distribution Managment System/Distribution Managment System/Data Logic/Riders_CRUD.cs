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
    class Riders_CRUD
    {
        private static List<Rider> DriversList = new List<Rider>();

        public static void Add(Rider driver)
        {
            DriversList.Add(driver);
        }

        public static void Load()
        {
            try
            {
                string filePath = "E:\\Semester 3\\final\\Distribution Managment System\\riders.csv";
                StreamReader reader = null;
                if (File.Exists(filePath))
                {
                    reader = new StreamReader(File.OpenRead(filePath));
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        DriversList.Add(new Rider(values[0], values[1], values[2], values[3], double.Parse(values[4])));
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data not loaded into list", ex.Message);
            }
        }



        public static Rider Retrieve(String id)
        {
            foreach (Rider driver in DriversList.ToList())
            {
                if (id == driver.DriverID1)
                {
                    return driver;
                }
            }
            return null;
        }

        public static bool Delete(String id)
        {
            
            foreach (Rider driver in DriversList.ToList())
            {
                if (id == driver.DriverID1)
                {
                    DriversList.Remove(driver);
                    return true;
                }
            }
            return false;
        }

        public static void Update(Rider oldrider, Rider newrider)
        {

            foreach (Rider driver in DriversList.ToList())
            {
                
                if (driver == oldrider)
                {
                    oldrider.DriverID1 = newrider.DriverID1;
                    oldrider.Name1 = newrider.Name1;
                    //oldrider. = newvehicle.Type1;
                    oldrider.Region1 = newrider.Region1;
                    oldrider.Phonenum1 = newrider.Phonenum1;
                }
            }
        }

    }
}
