using System.ComponentModel;
using System.Text.Json.Serialization;

namespace HPlusSport.API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Sku { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set;}
        public bool IsAvaliable { get; set; }

        public int CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category Category{ get; set; }
    }
}