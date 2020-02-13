using System.IO;
using System.Net;

namespace googleMapsAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "https://maps.googleapis.com/maps/api/place/details/json?place_id=ChIJN1t_tDeuEmsRUsoyG83frY4&fields=name,rating&key=AIzaSyDvjchyqGe0vRHFDPNSKAHjD-zjt38liqc";

            var req = WebRequest.Create(url);
            var res = req.GetResponse();

            var data = res.GetResponseStream();
            var reader = new StreamReader(data);

            var resFromServer = reader.ReadToEnd();

            res.Close();
        }
    }
}
