using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace _03_RestWithASPNETUdemy_UsingDiferentVerbs.Data.VO
{
    public class BookVO
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public decimal Price { get; set; }

        public DateTime LaunchDate { get; set; }

    }
}