
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace API.Models
{
    public class DrawDAL
    {
        public Draw Draw5(string id)
        {
            string url = @$"https://deckofcardsapi.com/api/deck/{id}/draw/?count=5";
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string json = rd.ReadToEnd();
            rd.Close();
            Draw d = JsonConvert.DeserializeObject<Draw>(json);
            return d;
        }
    }
}
