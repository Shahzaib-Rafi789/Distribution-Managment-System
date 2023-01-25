using CsvHelper;
using Distribution_Managment_System.BL;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribution_Managment_System.Data_Logic
{
    public class RegionCRUD
    {
        static List<Location> AllPoints= new List<Location>();

        public static List<Location> AllPoints1 { get => AllPoints;}

        public static void AddLocation(Location location)
        {
            AllPoints.Add(location);
        }

        public static List<Distribution_Managment_System.BL.Location> GetAllShopsOf(string region)
        {
            List<Distribution_Managment_System.BL.Location> list = new List<Distribution_Managment_System.BL.Location>();
            //foreach (Location s in AllPoints)
            //{ 
            //    if (s.GetRegion() == region)
            //        list.Add(s);
            //}

            if (region == "Lahore")
            {
                list.Add(new Distribution_Managment_System.BL.Location("A", 31.57970536, 74.40490723));
                list.Add(new Distribution_Managment_System.BL.Location("B", 31.42749129, 74.24285889));
                list.Add(new Distribution_Managment_System.BL.Location("C", 31.47786645, 74.48181152));
                list.Add(new Distribution_Managment_System.BL.Location("D", 31.65922621, 74.28268433));
                list.Add(new Distribution_Managment_System.BL.Location("E", 31.54050467, 74.30912018));
                list.Add(new Distribution_Managment_System.BL.Location("F", 31.59666771, 74.36302185));
            }
            else if (region == "Kasur")
            {
                list.Add(new Distribution_Managment_System.BL.Location("A", 31.10821277, 74.40216064));
                list.Add(new Distribution_Managment_System.BL.Location("B", 31.14348028, 74.35134888));
                list.Add(new Distribution_Managment_System.BL.Location("C", 31.09762996, 74.2792511));
            }
            return list;
        }

        public static void LoadLocations()
        {
            AllPoints = new List<Location>();
            string filePath = "routes.csv";
            StreamReader reader = null;
            if (File.Exists(filePath))
            {
                reader = new StreamReader(File.OpenRead(filePath));
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if (line == "")
                        continue;

                    double c1 = double.Parse(values[1]), c2 = double.Parse(values[2]);
                    Location location = new Location(values[0], c1, c2);
                    AllPoints.Add(location);
                }
            }
            else
            {

            }
        }

        public static void StoreLocations(Location location)
        { 
            using (var textWriter = new StreamWriter("routes.csv", true))
            {
                var writer = new CsvWriter(textWriter, CultureInfo.InvariantCulture);

                writer.WriteField(location.ShopID);
                writer.WriteField(location.Point.Position.Lat);
                writer.WriteField(location.Point.Position.Lng);

                writer.NextRecord();
            }
        }

        public static void RewriteLocations()
        {
            using (var textWriter = new StreamWriter("routes.csv", true))
            {
                var writer = new CsvWriter(textWriter, CultureInfo.InvariantCulture);

                foreach (Location location in AllPoints)
                {

                    writer.WriteField(location.ShopID);
                    writer.WriteField(location.Point.Position.Lat);
                    writer.WriteField(location.Point.Position.Lng);

                    writer.NextRecord();
                }
            }
        }
    }
}
