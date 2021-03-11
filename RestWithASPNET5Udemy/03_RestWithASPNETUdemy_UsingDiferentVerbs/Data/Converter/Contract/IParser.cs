using System.Collections.Generic;

namespace _03_RestWithASPNETUdemy_UsingDiferentVerbs.Data.Converter.Contract
{
    public interface IParser<Origin, Destiny>
    {
        Destiny Parse (Origin origin);

        List<Destiny> Parse(List<Origin> origin);
    }
}