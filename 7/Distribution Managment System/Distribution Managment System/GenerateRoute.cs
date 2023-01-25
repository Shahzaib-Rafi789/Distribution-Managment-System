using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Distribution_Managment_System.BL;
using Distribution_Managment_System.Data_Logic;
using Distribution_Managment_System.Data_Structure;
using Distribution_Managment_System.Algorithms;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;

namespace Distribution_Managment_System
{
    public partial class GenerateRoute : Form
    {
        List<Distribution_Managment_System.BL.Location> locations = null;
        GMapOverlay markers = new GMapOverlay();

        public GenerateRoute()
        {
            InitializeComponent();
            CMBBXrEGION.DataSource = Enum.GetNames(typeof(Distribution_Managment_System.BL.Regions)); 
            CMBBXrEGION.SelectedIndex = -1;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (btnGenerate.Text == "Load")
            {
                string region = CMBBXrEGION.Text;
                //MessageBox.Show(region);

                G.SetPositionByKeywords(region + ", Pakistan");
                G.MinZoom = 5;
                G.MaxZoom = 18;
                G.Zoom = 10;

                locations = RegionCRUD.GetAllShopsOf(region);
                MarkersToMap(locations);
                btnGenerate.Text = "Generate";
            }
            else
            {
                if (markers.Markers.Count > 0)
                    PaintRoute();

                else
                    MessageBox.Show("No Shops in this Region", "Alert!!");
                
            }
        }

        private void MarkersToMap(List<Distribution_Managment_System.BL.Location> regions)
        {
            G.Zoom = 10;
            markers = new GMapOverlay("markers");
            foreach (Distribution_Managment_System.BL.Location location in regions)
                markers.Markers.Add(location.Point);
            
            G.Overlays.Add(markers);
            G.Zoom = 11;
        }

        private void PaintRoute()
        {
            double[,] Graph = InitializeGraph();
            Vertex[] vertices = PrimAlgo.Prim(Graph);

            string n = "";
            for (int i = 0; i < markers.Markers.Count; i++)
            {
                for (int j = 0; j < markers.Markers.Count; j++)
                    n += Graph[i, j].ToString() + " , ";
                n += '\n';
            }
            MessageBox.Show(n);

            //double[][] GGraph = Graph;
            string nn = "";
            double ddist = 0;
            var routes = new GMapOverlay("routes");
            foreach (Vertex v in vertices)
            {
                if (v.Parent == -1)
                    nn = locations[v.Identifier].ShopName.ToString() + '\n';

                else
                {
                    var route = GoogleMapProvider.Instance.GetRoute(markers.Markers[v.Parent].Position, markers.Markers[v.Identifier].Position, false, false, 10);
                    var r = new GMapRoute(route.Points, "M")
                    {
                        Stroke = new Pen(Color.Red, 2)
                    };
                                        
                    routes.Routes.Add(r);
                    double dist = route.Distance;
                    nn += locations[v.Parent].ShopName + " to " + locations[v.Identifier].ShopName+ ": Weight:  "+ dist.ToString() + '\n';
                    ddist += dist;
                }
            }
            G.Overlays.Add(routes);
            MessageBox.Show(nn);
            MessageBox.Show("Total Distance: " + ddist.ToString());
            G.Zoom -= 1;
        }

        private double[,] InitializeGraph()
        {
            double[,] Graph = new double[markers.Markers.Count, markers.Markers.Count];

            for (int i = 0; i < markers.Markers.Count - 1; i++)
            {
                for (int j = i; j < markers.Markers.Count; j++)
                {
                    if (i == j)
                    {
                        Graph[i, j] = 0;
                        continue;
                    }
                    PointLatLng Point1 = markers.Markers[i].Position, Point2 = markers.Markers[j].Position;
                    var route = GoogleMapProvider.Instance.GetRoute(Point1, Point2, false, false, 14);
                    Graph[i, j] = route.Distance;
                    Graph[j, i] = route.Distance;
                }
            }

            return Graph;
        }

        private void G_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyCaOuZCFscGV4dBELoDiGO0Oku1gmPnBlg";
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            G.MapProvider = GMapProviders.GoogleMap;
            G.DragButton = MouseButtons.Left;
            G.SetPositionByKeywords("Punjab, Pakistan");
            //G.Position = new GMap.NET.PointLatLng(Convert.ToDouble(35), Convert.ToDouble(75));
            G.MinZoom = 5;
            G.MaxZoom = 18;
            G.Zoom = 5;
        }

        private void CMBBXrEGION_SelectedIndexChanged(object sender, EventArgs e)
        {
            G.Overlays.Clear();
            btnGenerate.Text = "Load";
            markers.Clear();

            G.SetPositionByKeywords("Punjab, Pakistan");
            G.MinZoom = 5;
            G.MaxZoom = 18;
            G.Zoom = 5;
        }
    }
}
