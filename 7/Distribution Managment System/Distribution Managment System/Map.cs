using CsvHelper;
using Distribution_Managment_System.BL;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using Distribution_Managment_System.Algorithms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Distribution_Managment_System.Data_Structure;
using static GMap.NET.Entity.OpenStreetMapRouteEntity;

namespace Distribution_Managment_System
{


        public partial class Map : Form
    {
        List<PointLatLng> P = new List<PointLatLng>();
        public Map()
        {
            InitializeComponent();
            P = new List<PointLatLng>();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyCaOuZCFscGV4dBELoDiGO0Oku1gmPnBlg";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            G.CacheLocation = @"cache";

            G.MapProvider = GMapProviders.GoogleMap;
            //G.Hide();
            G.DragButton = MouseButtons.Left;
            G.SetPositionByKeywords("Lahore, Pakistan");
            //G.Position = new GMap.NET.PointLatLng(Convert.ToDouble(35), Convert.ToDouble(75));
            G.MinZoom = 3;
            G.MaxZoom = 18;
            G.Zoom = 10;

            //GMapMarker marker1 = new GMarkerGoogle(new GMap.NET.PointLatLng(Convert.ToDouble(35), Convert.ToDouble(75)), GMarkerGoogleType.red_dot);
            //GMapMarker marker2 = new GMarkerGoogle(new GMap.NET.PointLatLng(Convert.ToDouble(37), Convert.ToDouble(73)), GMarkerGoogleType.red_dot);
            //G.Position = marker1.Position;
            //GMapOverlay markers = new GMapOverlay("markers");
            //markers.Markers.Add(marker1);
            //markers.Markers.Add(marker2);
            //G.Overlays.Add(markers);
            ////G.ShowCenter = false;
            //var route = GoogleMapProvider.Instance.GetRoute(marker1.Position, marker2.Position, false, false, 14);
            //var r = new GMapRoute(route.Points, "M");

            //var routes = new GMapOverlay("routes");
            //routes.Routes.Add(r);
            //G.Overlays.Add(routes);
            //mark(9.9252, 78.1198);
            //mark(14.0827, 80.2707);
            //GetAddress(new PointLatLng(32.45, 74.3));

            //using (var textWriter = new StreamWriter("Areas.csv"))
            //{
            //    var writer = new CsvWriter(textWriter, CultureInfo.InvariantCulture);

            //    for (double i = 32.0825745595459; i > 30.1261243642246; i -= 0.01)
            //        for (double j = 71.455078125; j < 73.45458984375; j += 0.01)
            //        {
            //            try
            //            {
            //                string a = GetAddress(new PointLatLng(i, j));
            //                if (a != "")
            //                {
            //                    List<string> b = a.Split(',').ToList();
            //                    foreach (string c in b)
            //                        writer.WriteField(c);
            //                }
            //                //else
            //                //{
            //                //    writer.WriteField(i.ToString());
            //                //    writer.WriteField(j.ToString());
            //                //    writer.WriteField("-1error");
            //                //}
            //            }
            //            catch (Exception ex)
            //            {
            //                writer.WriteField(i.ToString());
            //                writer.WriteField(j.ToString());
            //                writer.WriteField("error");
            //            }
            //            writer.NextRecord();
            //        }

            //}

            //using (var textWriter = new StreamWriter("Areas.csv"))
            //{
            //    var writer = new CsvWriter(textWriter, CultureInfo.InvariantCulture);

            //    for (double i = 32.0825745595459; i > 30.1261243642246; i -= 0.01)
            //        for (double j = 71.455078125; j < 73.45458984375; j += 0.01)
            //        {
            //            try
            //            {
            //                string a = GetAddress(new PointLatLng(i, j));
            //                if (a != "")
            //                {
            //                    List<string> b = a.Split(',').ToList();
            //                    foreach (string c in b)
            //                        writer.WriteField(c);
            //                }
            //                //else
            //                //{
            //                //    writer.WriteField(i.ToString());
            //                //    writer.WriteField(j.ToString());
            //                //    writer.WriteField("-1error");
            //                //}
            //            }
            //            catch (Exception ex)
            //            {
            //                writer.WriteField(i.ToString());
            //                writer.WriteField(j.ToString());
            //                writer.WriteField("error");
            //            }
            //            writer.NextRecord();
            //        }

            //}
            
            

        }

        private void Map_Load(object sender, EventArgs e)
        {
            //GMapProviders.GoogleMap.ApiKey = @"AIzaSyCaOuZCFscGV4dBELoDiGO0Oku1gmPnBlg";
            //GMaps.Instance.Mode = AccessMode.ServerAndCache;
            //G.CacheLocation = @"cache";

            //G.MapProvider = GMapProviders.GoogleMap;
            ////G.Hide();
            //G.DragButton = MouseButtons.Left;
            //G.SetPositionByKeywords("Lahore, Pakistan");
            ////G.Position = new GMap.NET.PointLatLng(Convert.ToDouble(35), Convert.ToDouble(75));
            ////G.MinZoom = 5;
            ////G.MaxZoom = 30;
            ////G.Zoom = 10;

            ////GMapMarker marker1 = new GMarkerGoogle(new GMap.NET.PointLatLng(Convert.ToDouble(35), Convert.ToDouble(75)), GMarkerGoogleType.red_dot);
            ////GMapMarker marker2 = new GMarkerGoogle(new GMap.NET.PointLatLng(Convert.ToDouble(37), Convert.ToDouble(73)), GMarkerGoogleType.red_dot);
            ////G.Position = marker1.Position;
            ////GMapOverlay markers = new GMapOverlay("markers");
            ////markers.Markers.Add(marker1);
            ////markers.Markers.Add(marker2);
            ////G.Overlays.Add(markers);
            //////G.ShowCenter = false;
            ////var route = GoogleMapProvider.Instance.GetRoute(marker1.Position, marker2.Position, false, false, 14);
            ////var r = new GMapRoute(route.Points, "M");

            ////var routes = new GMapOverlay("routes");
            ////routes.Routes.Add(r);
            ////G.Overlays.Add(routes);
            ////mark(9.9252, 78.1198);
            ////mark(14.0827, 80.2707);
            ///
            var overlay = new GMapOverlay("M");
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

                    double c1 = double.Parse(values[0]), c2 = double.Parse(values[1]);
                    PointLatLng point = new PointLatLng(c1, c2);
                    string add = GetAddress(point);

                    if (add.Split(',')[0].Trim() == "Punjab" && add.Split(',')[1].Trim() == "Lahore")
                    {
                        overlay.Markers.Add(new GMarkerGoogle(new PointLatLng(c1, c2), GMarkerGoogleType.red_dot));
                        MessageBox.Show(add);
                    }
                    else
                    {
                        MessageBox.Show(add);
                    }
                }
                G.Overlays.Add(overlay);
            }
            else
            {
                MessageBox.Show("sbs");
            }

            double[,] Graph = new double[overlay.Markers.Count, overlay.Markers.Count];
            //Graph[0, 0] = 0;
            //Graph[1, 1] = 0;
            //Graph[2, 2] = 0;
            //Graph[3, 3] = 0;

            for (int i = 0; i < overlay.Markers.Count - 1; i++)
            {
                for (int j = i ; j < overlay.Markers.Count; j++)
                {
                    if (i == j)
                    {
                        Graph[i, j] = 0;
                        continue;
                    }
                    PointLatLng Point1 = overlay.Markers[i].Position, Point2 = overlay.Markers[j].Position;
                    var route = GoogleMapProvider.Instance.GetRoute(Point1, Point2, false, false, 14);
                    var r = new GMapRoute(route.Points, "M")
                    {
                        Stroke = new Pen(Color.Red, 2)
                    };

                    var routes = new GMapOverlay("routes");
                    routes.Routes.Add(r);
                    Graph[i, j] = route.Distance;
                    Graph[j, i] = route.Distance;
                    //G.Overlays.Add(routes);
                }
            }

            string n = "";
            for (int i = 0; i< overlay.Markers.Count; i++)
            {
                for (int j = 0; j < overlay.Markers.Count; j++)
                    n += Graph[i, j].ToString() + " , ";
                n += '\n';
            }
            MessageBox.Show(n);

            //double[][] GGraph = Graph;
            Vertex[] vertices = PrimAlgo.Prim(Graph);
            string nn = "";
            foreach (Vertex v in vertices)
            {
                if (v.Parent == -1)
                    nn = v.Identifier.ToString() + '\n'; 

                else
                {
                    nn += v.Parent +" to "+ v.Identifier.ToString() + '\n';
                }
            }

            MessageBox.Show(nn);
        }

        private void Geocoding(string address)
        {
            if (!address.Trim().Equals(""))
            {
                GeoCoderStatusCode statusCode;
                var point = GoogleMapProvider.Instance.GetPoint(address.Trim(), out statusCode);

                if (statusCode == GeoCoderStatusCode.OK)
                {
                    t1.Text = point?.Lat.ToString();
                    t2.Text = point?.Lng.ToString();

                    List<Placemark> placemarks = null;
                    var statuscode = GMapProviders.GoogleMap.GetPlacemarks(new PointLatLng(Convert.ToDouble( point?.Lat), Convert.ToDouble(point?.Lng)), out placemarks);
                    string region = "";
                    foreach (Placemark i in placemarks)
                        if (i.AdministrativeAreaName.Trim() != "" && i.DistrictName.Trim() != "")
                        {
                            region = i.AdministrativeAreaName + " , " + i.DistrictName;
                            break;
                        }
                    //p.AdministrativeAreaName + " , " + e + p.SubAdministrativeAreaName;

                    txtStatus.Text = region;
                }
            }
        }

        private void mark(double lat, double lng)
        {
            //G.MapProvider = GMapProviders.GoogleMap;
            //G.DragButton = MouseButtons.Left;
            G.Position = new GMap.NET.PointLatLng(Convert.ToDouble(lat), Convert.ToDouble(lng));
            G.MinZoom = 5;
            G.MaxZoom = 18;
            G.Zoom = 10;

            GMapMarker marker1 = new GMarkerGoogle(new GMap.NET.PointLatLng(Convert.ToDouble(lat), Convert.ToDouble(lng)), GMarkerGoogleType.red_dot);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker1);
            P.Add(marker1.Position);
            G.Overlays.Add(markers);
            GetAddress(marker1.Position);
        }

        private void b_Click(object sender, EventArgs e)
        {
            mark(Convert.ToDouble(t1.Text), Convert.ToDouble(t2.Text));
        }

        private void b2_Click(object sender, EventArgs e)
        {
            P.Clear();
        }

        private void bb_Click(object sender, EventArgs e)
        {
            var route = GoogleMapProvider.Instance.GetRoute(P[0], P[1], false, false, 14);
            var r = new GMapRoute(route.Points, "M")
            {
                Stroke = new Pen(Color.Red, 6)
        };

            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            G.Overlays.Add(routes);

            lbl.Text = route.Distance.ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            P.Add(new GMap.NET.PointLatLng(Convert.ToDouble(t1.Text), Convert.ToDouble(t2.Text)));
        }

        private void Polygon_Click(object sender, EventArgs e)
        {
            var polygon = new GMapPolygon(P, "Johar Town")
            {
                Stroke = new Pen(Color.Cyan),
                Fill = new SolidBrush(Color.BurlyWood)
            };

            var polygons = new GMapOverlay("polygons");
            polygons.Polygons.Add(polygon);
            G.Overlays.Add(polygons);

            
        }

       

            private void G_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PointLatLng P = G.FromLocalToLatLng(e.X, e.Y);
                t3.Text = P.Lat.ToString();
                t4.Text = P.Lng.ToString();
                G.Position = P;
                //G.Position = OldP;

                AddMarker(P, GMarkerGoogleType.red_dot);
                GetAddress(P);
            }
        }

            private void AddMarker(PointLatLng P, GMarkerGoogleType icon)
            {
                var marker = new GMarkerGoogle(new PointLatLng(P.Lat, P.Lng), GMarkerGoogleType.green_dot);
                var overlay = new GMapOverlay("j");
                overlay.Markers.Add(marker);
                G.Overlays.Add(overlay);
            }

        private string GetAddress(PointLatLng P)
        {
            List<Placemark> a = null;
            var statusCode = GMapProviders.GoogleMap.GetPlacemarks(P, out a) ;
            string d = "";
            foreach (Placemark i in a)
                if (i.AdministrativeAreaName.Trim() != "" && i.DistrictName.Trim() != "")
                {
                    d += i.AdministrativeAreaName + " , " + i.DistrictName;
                    break;
                }

            return d;
            //Placemark p = a[0];
            //d += e;
            ////p.AdministrativeAreaName + " , " + e + p.SubAdministrativeAreaName;

            //txtStatus.Text = P.Lat.ToString() + " , " + P.Lng.ToString() + " , " + statusCode.ToString() + d+ p.Neighborhood + '\n';
            //if (p.AdministrativeAreaName == "" || p.DistrictName == "")
            //    return P.Lat.ToString() + " , " + P.Lng.ToString() + " , " + statusCode.ToString() + "," + d;
            ////return P.Lat.ToString() + " , " + P.Lng.ToString() + " , " + statusCode.ToString() + d;
            //return "";
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGeoCode_Click(object sender, EventArgs e)
        {
            Geocoding(txtStatus.Text);
        }
    }
}
