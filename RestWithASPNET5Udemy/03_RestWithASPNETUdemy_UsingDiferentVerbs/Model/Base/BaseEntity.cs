using System.ComponentModel.DataAnnotations.Schema;

namespace _03_RestWithASPNETUdemy_UsingDiferentVerbs.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]    
        public long Id { get; set; }
    }
}