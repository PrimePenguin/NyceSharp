using System.Collections.Generic;
using Newtonsoft.Json;

namespace NyceSharp.CustomModels.Inventory
{
    public partial class InventoryReponse
    {
        [JsonProperty("Item")]
        public List<Item> Item { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("Sku")]
        public string Sku { get; set; }

        [JsonProperty("Balance")]
        public long Balance { get; set; }

        [JsonProperty("CustomProperties")]
        public CustomProperty[] CustomProperties { get; set; }

        [JsonProperty("Id")]
        public long Id { get; set; }
    }

    public partial class CustomProperty
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }
}
