using System.Collections.Generic;

namespace _03_RestWithASPNETUdemy_UsingDiferentVerbs.Hypermedia.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}