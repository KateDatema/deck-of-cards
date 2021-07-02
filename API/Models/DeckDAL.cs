using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace API.Models
{//This is our class for calling our API
    public class DeckDAL
    {
        //this makes a request and gets the info
        public string CallDeck()
        {
            string url = @$"https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string JSON = rd.ReadToEnd();
            rd.Close();

            return JSON;
        }
        //This is taking the Json information and changing it to a Deck
        public string GetModel()
        {
            string deckJson = CallDeck();
            Deck c = JsonConvert.DeserializeObject<Deck>(deckJson);
            string id = c.deck_id;
            return id;
        }

 


    }
}
