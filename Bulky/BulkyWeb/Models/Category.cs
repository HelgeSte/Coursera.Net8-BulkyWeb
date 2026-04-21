using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        //[Key] // Tried without this, since the Id name should be enough
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
