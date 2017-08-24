using System.Collections.Generic;

namespace MyComics.Models.Marvel
{
    public class Events
    {
        public int Available { get; set; }
        public string CollectionURI { get; set; }
        public List<Summary> Items { get; set; }
        public int Returned { get; set; }
    }
}