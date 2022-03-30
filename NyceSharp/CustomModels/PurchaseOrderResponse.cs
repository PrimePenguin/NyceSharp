using System;
using Newtonsoft.Json;

namespace NyceSharp.CustomModels.PurchaseOrderResponse
{
    public partial class PurchaseOrderResponse
    {
        [JsonProperty("PurchaseOrder")]
        public PurchaseOrder[] PurchaseOrder { get; set; }
    }

    public partial class PurchaseOrder
    {
        [JsonProperty("Number")]
        public string Number { get; set; }

        [JsonProperty("CustomProperties")]
        public CustomProperty[] CustomProperties { get; set; }

        [JsonProperty("LastDeliveryDate")]
        public DateTimeOffset LastDeliveryDate { get; set; }

        [JsonProperty("Lines")]
        public Line[] Lines { get; set; }

        [JsonProperty("Marking")]
        public string Marking { get; set; }

        [JsonProperty("OrderText")]
        public string OrderText { get; set; }

        [JsonProperty("OurReference")]
        public string OurReference { get; set; }

        [JsonProperty("RequestedDeliveryDate")]
        public DateTimeOffset RequestedDeliveryDate { get; set; }

        [JsonProperty("Status")]
        public Status Status { get; set; }

        [JsonProperty("Substatus")]
        public Status Substatus { get; set; }

        [JsonProperty("YourReference")]
        public string YourReference { get; set; }

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

    public partial class Line
    {
        [JsonProperty("Position")]
        public long Position { get; set; }

        [JsonProperty("Subposition")]
        public long Subposition { get; set; }

        [JsonProperty("CustomProperties")]
        public object[] CustomProperties { get; set; }

        [JsonProperty("DeliveredQuantity")]
        public long DeliveredQuantity { get; set; }

        [JsonProperty("Item")]
        public Item Item { get; set; }

        [JsonProperty("LastDeliveryDate")]
        public DateTimeOffset LastDeliveryDate { get; set; }

        [JsonProperty("LineDescription")]
        public string[] LineDescription { get; set; }

        [JsonProperty("OrderQuantity")]
        public long OrderQuantity { get; set; }

        [JsonProperty("Quantity")]
        public long Quantity { get; set; }

        [JsonProperty("PackageIdentifier")]
        public object PackageIdentifier { get; set; }

        [JsonProperty("RequestedDeliveryDate")]
        public DateTimeOffset RequestedDeliveryDate { get; set; }

        [JsonProperty("Status")]
        public Status Status { get; set; }

        [JsonProperty("Substatus")]
        public Status Substatus { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("Sku")]
        public string Sku { get; set; }
    }

    public partial class Status
    {
        [JsonProperty("Code")]
        public string Code { get; set; }
    }
}
