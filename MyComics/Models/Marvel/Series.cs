using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyComics.Models.Marvel
{
    public class Series
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public object Description { get; set; }
        public string ResourceURI { get; set; }
        public List<Url> Urls { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public string Rating { get; set; }
        public string Type { get; set; }
        public DateTime Modified { get; set; }
        public Thumbnail Thumbnail { get; set; }
        public Creators Creators { get; set; }
        public Characters Characters { get; set; }
        public Stories Stories { get; set; }
        public Comics Comics { get; set; }
        public Events Events { get; set; }
        public object Next { get; set; }
        public object Previous { get; set; }
    }
}
