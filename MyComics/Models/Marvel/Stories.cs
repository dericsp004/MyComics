using System.Collections.Generic;

namespace MyComics.Models.Marvel
{
    public class Stories
    {
        public int Id { get; set; }
        public int Available { get; set; }
        public string CollectionURI { get; set; }
        public List<StorySummary> Items { get; set; }
        public int Returned { get; set; }
    }
}