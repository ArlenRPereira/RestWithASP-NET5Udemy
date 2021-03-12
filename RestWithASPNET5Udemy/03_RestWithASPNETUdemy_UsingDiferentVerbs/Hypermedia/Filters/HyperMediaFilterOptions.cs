using System.Collections.Generic;
using _03_RestWithASPNETUdemy_UsingDiferentVerbs.Hypermedia.Abstract;

namespace _03_RestWithASPNETUdemy_UsingDiferentVerbs.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList{ get; set; } = new List<IResponseEnricher>();
    }
}