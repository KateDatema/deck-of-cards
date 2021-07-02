using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    //This class takes in the data from our API and makes it into an object
    public class Deck
    {
         public bool success { get; set; }
         public string deck_id { get; set; }
         public bool shuffled { get; set; }

    }
}
