using System.ComponentModel.DataAnnotations.Schema;
using _03_RestWithASPNETUdemy_UsingDiferentVerbs.Hypermedia;
using _03_RestWithASPNETUdemy_UsingDiferentVerbs.Hypermedia.Abstract;
using System;
using System.Collections.Generic;

namespace _03_RestWithASPNETUdemy_UsingDiferentVerbs.Data.VO
{
    public class PersonVO : ISupportsHyperMedia
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}