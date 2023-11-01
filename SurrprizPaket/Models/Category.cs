using System.ComponentModel.DataAnnotations;

namespace SurrprizPaket.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        public string Name{ get; set; }
        public string Description { get; set; }
       






    }
}
