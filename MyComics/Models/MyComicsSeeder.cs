using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyComics.Models.Marvel;

namespace MyComics.Models
{
    public class MyComicsSeeder
    {
        private ComicsContext context;

        public MyComicsSeeder(ComicsContext context)
        {
            this.context = context;
        }

        public async Task EnsureSeedData()
        {
            if (!context.Series.Any())
            {
                Series america = new Series()
                {
                    SeriesNo = 22997,
                    Title = "America (2017 - Present)",
                    Description = null,
                    ResourceURI = "http://gateway.marvel.com/v1/public/series/22997",
                    Urls = new List<Url>()
                    {
                        new Url()
                        {
                            Type = "detail",
                            UrlString = "http://marvel.com/comics/series/22997/america_2017_-_present?utm_campaign=apiRef&utm_source=a88713c7e664210b39c945f1bbeffaf1"
                        }
                    },
                    StartYear = 2017,
                    EndYear = 2099,
                    Rating = "",
                    Type = "ongoing",
                    Modified = new DateTime(2017, 2, 24),
                    Thumbnail = new Thumbnail() { Path = "http://i.annihil.us/u/prod/marvel/i/mg/6/00/58b0b1d81562c", Extension = "jpg" },
                    Creators = new Creators()
                    {
                        Available = 8,
                        CollectionURI = "http://gateway.marvel.com/v1/public/series/22997/creators",
                        Items = new List<PersonSummary> ()
                        {
                            new PersonSummary()
                            {
                                ResourceURI = "http://gateway.marvel.com/v1/public/creators/12744",
                                Name = "Tamra Bonvillain",
                                Role = "colorist"
                            },

                            new PersonSummary()
                            {
                                ResourceURI = "http://gateway.marvel.com/v1/public/creators/8836",
                                Name = "Jose Villarrubia",
                                Role = "colorist"
                            },

                            new PersonSummary()
                            {
                                ResourceURI = "http://gateway.marvel.com/v1/public/creators/12744",
                                Name = "Tamra Bonvillain",
                                Role = "colorist"
                            },

                            new PersonSummary()
                            {
                                ResourceURI = "http://gateway.marvel.com/v1/public/creators/12716",
                                Name = "Stacey Lee",
                                Role = "penciler"
                            },

                            new PersonSummary()
                            {
                                ResourceURI ="http://gateway.marvel.com/v1/public/creators/12973",
                                Name = "Gabby Rivera",
                                Role = "writer"
                            }
                        },

                        Returned = 8
                    },

                    Characters = new Characters()
                    {
                        Available = 3,
                        CollectionURI = "http://gateway.marvel.com/v1/public/series/22997/characters",
                        Items = new List<PersonSummary>()
                        {
                            new PersonSummary()
                            {
                                ResourceURI = "http://gateway.marvel.com/v1/public/characters/1010808",
                                Name = "Hawkeye (Kate Bishop)"
                            },

                            new PersonSummary()
                            {
                                ResourceURI = "http://gateway.marvel.com/v1/public/characters/1010803",
                                Name = "Ultimates"
                            },

                            new PersonSummary()
                            {
                                ResourceURI = "http://gateway.marvel.com/v1/public/characters/1009726",
                                Name = "X-Men"
                            },
                        },

                        Returned = 3
                        
                    },
                    Stories = new Stories()
                    {
                        Available = 15,
                        CollectionURI = "http://gateway.marvel.com/v1/public/series/23021/stories",
                        Items = new List<StorySummary>()
                        {
                            new StorySummary()
                            {
                                ResourceURI = "http://gateway.marvel.com/v1/public/stories/140989",
                                Name = "cover from America (2017) #8",
                                Type = "cover"
                            },
                        },
                        Returned = 1  
                    },
                    Comics = new Comics()
                    {
                        Available = 6,
                        CollectionURI = "http://gateway.marvel.com/v1/public/series/22997/comics",
                        Items = new List<Summary>()
                        {
                            new Summary()
                            {
                                ResourceURI = "http://gateway.marvel.com/v1/public/comics/62656",
                                Name = "America (2017) #1"
                            },

                            new Summary()
                            {
                                ResourceURI = "http://gateway.marvel.com/v1/public/comics/64279",
                                Name = "America (2017) #6"
                            }
                        },

                        Returned = 6,
                    },
                    Events = new Events
                    {
                        Available = 0,
                        CollectionURI = "http://gateway.marvel.com/v1/public/series/22997/events",
                        Items = new List<Summary>(),
                        Returned = 0
                    },
                    Next = null,
                    Previous = null
                };

                Series scarletSpider = new Series()
                {
                    SeriesNo = 23021,
                    Title = "Ben Reilly: Scarlet Spider (2017 - Present)",
                    Description = null,
                    ResourceURI = "http://gateway.marvel.com/v1/public/series/23021",
                    Urls = new List<Url>()
                    {
                        new Url()
                        {
                            Type = "detail",
                            UrlString = "http://marvel.com/comics/series/23021/ben_reilly_scarlet_spider_2017_-_present?utm_campaign=apiRef&utm_source=a88713c7e664210b39c945f1bbeffaf1"
                        }
                    },
                    StartYear = 2017,
                    EndYear = 2099,
                    Rating = "",
                    Type = "ongoing",
                    Modified = new DateTime(2017, 4, 21),
                    Thumbnail = new Thumbnail() { Path = "http://i.annihil.us/u/prod/marvel/i/mg/9/90/58fa51d0e55c8", Extension = "jpg" },
                    Creators = new Creators()
                    {
                        Available = 12,
                        CollectionURI = "http://gateway.marvel.com/v1/public/series/23021/creators",
                        Items = new List<PersonSummary>()
                        {
                            new PersonSummary()
                            {
                                ResourceURI = "http://gateway.marvel.com/v1/public/creators/87",
                                Name = "Mark Bagley",
                                Role = "penciler (cover)"
                            },

                            new PersonSummary()
                            {
                                ResourceURI ="http://gateway.marvel.com/v1/public/creators/12982",
                                Name = "Vc Joe Caramagna",
                                Role = "letterer"
                            },

                            new PersonSummary()
                            {
                                ResourceURI = "http://gateway.marvel.com/v1/public/creators/8028",
                                Name = "Andrew Crossley",
                                Role = "colorist (cover)"
                            },

                            new PersonSummary()
                            {
                                ResourceURI = "http://gateway.marvel.com/v1/public/creators/121",
                                Name = "Peter David",
                                Role = "writer"
                            },

                            new PersonSummary()
                            {
                                ResourceURI ="http://gateway.marvel.com/v1/public/creators/774",
                                Name = "Morry Hollowell",
                                Role = "colorist (cover)"
                            }
                        },

                        Returned = 12
                    },

                    Characters = new Characters()
                    {
                        Available = 2,
                        CollectionURI = "http://gateway.marvel.com/v1/public/series/23021/characters",
                        Items = new List<PersonSummary>()
                        {
                            new PersonSummary()
                            {
                                ResourceURI = "http://gateway.marvel.com/v1/public/characters/1011197",
                                Name = "Scarlet Spider (Ben Reilly)"
                            },

                            new PersonSummary()
                            {
                                ResourceURI = "http://gateway.marvel.com/v1/public/characters/1011426",
                                Name = "Scarlet Spider (Kaine)"
                            }
                        },

                        Returned = 2

                    },
                    Stories = new Stories()
                    {
                        Available = 15,
                        CollectionURI = "http://gateway.marvel.com/v1/public/series/23021/stories",
                        Items = new List<StorySummary>()
                        {
                            new StorySummary()
                            {
                                ResourceURI = "http://gateway.marvel.com/v1/public/stories/136997",
                                Name = "cover from Ben Reilly: The Scarlet Spider (2017) #1",
                                Type = "cover"
                            },
                        },
                        Returned = 1
                    },
                    Comics = new Comics()
                    {
                        Available = 7,
                        CollectionURI = "http://gateway.marvel.com/v1/public/series/23021/comics",
                        Items = new List<Summary>()
                        {
                            new Summary()
                            {
                                ResourceURI = "http://gateway.marvel.com/v1/public/comics/62726",
                                Name = "Ben Reilly: Scarlet Spider (2017) #6"
                            },

                            new Summary()
                            {
                                ResourceURI = "http://gateway.marvel.com/v1/public/comics/64279",
                                Name = "Ben Reilly: Scarlet Spider (2017) #7"
                            }
                        },

                        Returned = 7,
                    },
                    Events = new Events
                    {
                        Available = 0,
                        CollectionURI = "http://gateway.marvel.com/v1/public/series/23021/events",
                        Items = new List<Summary>(),
                        Returned = 0
                    },
                    Next = null,
                    Previous = null
                };
                context.Series.Add(america);
                context.Series.Add(scarletSpider);
                context.Creators.Add(america.Creators);
                context.Creators.Add(scarletSpider.Creators);
                context.Characters.Add(america.Characters);
                context.Characters.Add(scarletSpider.Characters);
                context.Stories.Add(america.Stories);
                context.Stories.Add(scarletSpider.Stories);
                context.Comics.Add(america.Comics);
                context.Comics.Add(scarletSpider.Comics);
                context.Events.Add(america.Events);
                context.Events.Add(scarletSpider.Events);

                await context.SaveChangesAsync();
            };           
        }
    }
}
