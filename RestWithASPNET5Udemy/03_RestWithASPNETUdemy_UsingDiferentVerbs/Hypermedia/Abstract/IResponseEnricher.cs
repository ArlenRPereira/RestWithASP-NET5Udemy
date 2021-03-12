using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace _03_RestWithASPNETUdemy_UsingDiferentVerbs.Hypermedia.Abstract
{
    public interface IResponseEnricher
    {
        bool CanEnrich(ResultExecutingContext context);

        Task Enrich(ResultExecutingContext context);
    }
}