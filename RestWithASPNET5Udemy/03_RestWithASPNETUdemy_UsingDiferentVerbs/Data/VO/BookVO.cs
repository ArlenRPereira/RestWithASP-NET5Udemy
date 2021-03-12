using _03_RestWithASPNETUdemy_UsingDiferentVerbs.Hypermedia;
using _03_RestWithASPNETUdemy_UsingDiferentVerbs.Hypermedia.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace _03_RestWithASPNETUdemy_UsingDiferentVerbs.Data.VO
{
    public class BookVO : ISupportsHyperMedia
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public decimal Price { get; set; }

        public DateTime LaunchDate { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

    }
}