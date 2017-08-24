using System.Collections.Generic;

namespace MyComics.Models.Marvel
{
    public class Characters
    {
        public int Id { get; set; }
        public int Available { get; set; }
        public string CollectionURI { get; set; }
        public List<PersonSummary> Items { get; set; }
        public int Returned { get; set; }
    }
}