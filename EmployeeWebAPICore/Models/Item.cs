using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ShopBridgeWebAPICore.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        public string ItemName { get; set; }

        public string ItemDescription { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
