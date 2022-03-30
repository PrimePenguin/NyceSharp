using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NyceSharp.CustomModels.InventoryLocation
{
    public partial class InventoryLocationReponse
    {
        [JsonProperty("ItemLocation")]
        public List<ItemLocation> ItemLocation { get; set; }
    }

    public partial class ItemLocation
    {
        [JsonProperty("Item")]
        public Item Item { get; set; }

        [JsonProperty("Location")]
        public Location Location { get; set; }

        [JsonProperty("Balance")]
        public long Balance { get; set; }

        [JsonProperty("LatestInboundMovementDate")]
        public DateTimeOffset? LatestInboundMovementDate { get; set; }

        [JsonProperty("LatestOutboundMovementDate")]
        public DateTimeOffset? LatestOutboundMovementDate { get; set; }

        [JsonProperty("Id")]
        public long Id { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("Sku")]
        public string Sku { get; set; }

        [JsonProperty("CustomProperties")]
        public CustomProperty[] CustomProperties { get; set; }
    }

    public partial class CustomProperty
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("Code")]
        public string Code { get; set; }
    }
}
