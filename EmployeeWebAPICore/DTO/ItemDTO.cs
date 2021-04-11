using System;
using System.Collections.Generic;

#nullable disable

namespace ShopBridgeWebAPICore.DTO
{
    public partial class ItemDTO
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
