using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NyceSharp.CustomModels.CustomerReturnResponse
{
    public partial class CustomerReturnResponse
    {
        [JsonProperty("CustomerReturn")]
        public List<CustomerReturn> CustomerReturn { get; set; }
    }

    public partial class CustomerReturn
    {
        [JsonProperty("Number")]
        public string Number { get; set; }

        [JsonProperty("CustomerOrder")]
        public CustomerOrder CustomerOrder { get; set; }

        [JsonProperty("CustomProperties")]
        public CustomProperty[] CustomProperties { get; set; }

        [JsonProperty("DocumentCode")]
        public object DocumentCode { get; set; }

        [JsonProperty("DocumentNumber")]
        public object DocumentNumber { get; set; }

        [JsonProperty("Lines")]
        public Line[] Lines { get; set; }

        [JsonProperty("OrderCustomer")]
        public OrderCustomer OrderCustomer { get; set; }

        [JsonProperty("OrderText")]
        public string OrderText { get; set; }

        [JsonProperty("OurReference")]
        public string OurReference { get; set; }

        [JsonProperty("RequestedDeliveryDate")]
        public DateTimeOffset RequestedDeliveryDate { get; set; }

        [JsonProperty("Status")]
        public OrderCustomer Status { get; set; }

        [JsonProperty("Substatus")]
        public OrderCustomer Substatus { get; set; }

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

    public partial class CustomerOrder
    {
        [JsonProperty("Number")]
        public string Number { get; set; }
    }

    public partial class Line
    {
        [JsonProperty("Position")]
        public long Position { get; set; }

        [JsonProperty("Subposition")]
        public long Subposition { get; set; }

        [JsonProperty("CustomProperties")]
        public CustomProperty[] CustomProperties { get; set; }

        [JsonProperty("DeliveredQuantity")]
        public long DeliveredQuantity { get; set; }

        [JsonProperty("OriginalItem")]
        public OriginalItem OriginalItem { get; set; }

        [JsonProperty("OriginalItemDescription")]
        public string[] OriginalItemDescription { get; set; }

        [JsonProperty("NewItemDescription")]
        public string[] NewItemDescription { get; set; }

        [JsonProperty("OrderQuantity")]
        public long OrderQuantity { get; set; }

        [JsonProperty("PriceExcludingVat")]
        public long PriceExcludingVat { get; set; }

        [JsonProperty("PriceIncludingVat")]
        public long PriceIncludingVat { get; set; }

        [JsonProperty("RequestedDeliveryDate")]
        public DateTimeOffset RequestedDeliveryDate { get; set; }

        [JsonProperty("ReturnedQuantities")]
        public ReturnedQuantity[] ReturnedQuantities { get; set; }

        [JsonProperty("Status")]
        public OrderCustomer Status { get; set; }

        [JsonProperty("Substatus")]
        public OrderCustomer Substatus { get; set; }
    }

    public partial class ReturnedQuantity
    {
        [JsonProperty("Quantity")]
        public long Quantity { get; set; }

        [JsonProperty("ReturnCause")]
        public ReturnCause ReturnCause { get; set; }
    }

    public partial class ReturnCause
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
    }

    public partial class OriginalItem
    {
        [JsonProperty("Sku")]
        public string Sku { get; set; }
    }

    public partial class OrderCustomer
    {
        [JsonProperty("Code")]
        public string Code { get; set; }
    }
}
