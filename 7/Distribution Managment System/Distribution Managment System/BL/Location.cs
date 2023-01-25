using Distribution_Managment_System.Data_Logic;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribution_Managment_System.BL
{
    public class Location
    {
        string shopID, shopName;
        GMapMarker point;

        public Location(string address) 
        {
            GeoCode(address);
        }

        public Location(string id, double Lat, double Lng) 
        { 
            ShopID = id;
            Point = new GMarkerGoogle(new PointLatLng(Lat, Lng), GMarkerGoogleType.red_dot);
            //shopName = Shops_CRUD.getNamebyID(id);
            shopName= id;
            Point.ToolTipText = shopName;            
        }

        public string ShopID { get => shopID; set => shopID = value; }
        public GMapMarker Point { get => point; set => point = value; }
        public string ShopName { get => shopName; }

        public void GeoCode(string address)
        {
            if (!address.Trim().Equals(""))
            {
                GeoCoderStatusCode statusCode;
                var point = GoogleMapProvider.Instance.GetPoint(address.Trim(), out statusCode);

                if (statusCode == GeoCoderStatusCode.OK)
                {
                    PointLatLng P = new PointLatLng(Convert.ToDouble(point?.Lat), Convert.ToDouble(point?.Lng));
                    Point = new GMarkerGoogle(P, GMarkerGoogleType.red_dot);
                }
            }
        }
        
        public string GetRegion()
        {            
            return Shops_CRUD.GetRegion(ShopID);
        }

    }
}
