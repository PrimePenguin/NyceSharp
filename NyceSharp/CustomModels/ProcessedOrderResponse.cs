using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NyceSharp.CustomModels.ProcessedOrder
{
    public partial class ProcessedOrderResponse
    {
        [JsonProperty("customerOrders")]
        public CustomerOrders CustomerOrders { get; set; }

        [JsonProperty("customerOrdersDeliveries")]
        public CustomerOrdersDeliveries CustomerOrdersDeliveries { get; set; }

        [JsonProperty("shipmentReferences")]
        public ShipmentReferences ShipmentReferences { get; set; }
    }

    public partial class CustomerOrders
    {
        [JsonProperty("CustomerOrder")]
        public List<CustomerOrdersCustomerOrder> CustomerOrder { get; set; }
    }

    public partial class CustomerOrdersCustomerOrder
    {
        [JsonProperty("Number")]
        public string Number { get; set; }

        [JsonProperty("CustomProperties")]
        public CustomProperty[] CustomProperties { get; set; }

        [JsonProperty("Lines")]
        public Line[] Lines { get; set; }

        [JsonProperty("OrderReference")]
        public string OrderReference { get; set; }

        [JsonProperty("OurReference")]
        public object OurReference { get; set; }

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

        [JsonProperty("ModificationDate")]
        public DateTimeOffset ModificationDate { get; set; }

        [JsonProperty("DateAdded")]
        public DateTimeOffset DateAdded { get; set; }
    }

    public partial class Line
    {
        [JsonProperty("Position")]
        public long Position { get; set; }

        [JsonProperty("Subposition")]
        public long Subposition { get; set; }

        [JsonProperty("DeliveredQuantity")]
        public long DeliveredQuantity { get; set; }

        [JsonProperty("Item")]
        public Item Item { get; set; }

        [JsonProperty("ItemDescription")]
        public string[] ItemDescription { get; set; }

        [JsonProperty("OrderQuantity")]
        public long OrderQuantity { get; set; }

        [JsonProperty("RequestedDeliveryDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? RequestedDeliveryDate { get; set; }

        [JsonProperty("Status")]
        public Status Status { get; set; }

        [JsonProperty("Substatus")]
        public Status Substatus { get; set; }

        [JsonProperty("Unit")]
        public Unit Unit { get; set; }

        [JsonProperty("ActualDeliveredQuantity", NullValueHandling = NullValueHandling.Ignore)]
        public long? ActualDeliveredQuantity { get; set; }

        [JsonProperty("CustomProperties", NullValueHandling = NullValueHandling.Ignore)]
        public CustomProperty[] CustomProperties { get; set; }

        [JsonProperty("OrderLine", NullValueHandling = NullValueHandling.Ignore)]
        public OrderLine OrderLine { get; set; }
    }

    public partial class CustomProperty
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("Sku")]
        public string Sku { get; set; }
    }

    public partial class OrderLine
    {
        [JsonProperty("CustomerOrder")]
        public OrderLineCustomerOrder CustomerOrder { get; set; }

        [JsonProperty("Position")]
        public long Position { get; set; }

        [JsonProperty("Subposition")]
        public long Subposition { get; set; }
    }

    public partial class OrderLineCustomerOrder
    {
        [JsonProperty("Number")]
        public string Number { get; set; }

        [JsonProperty("OrderReference")]
        public string OrderReference { get; set; }
    }

    public partial class Status
    {
        [JsonProperty("Code")]
        public string Code { get; set; }
    }

    public partial class Unit
    {
        [JsonProperty("Unit")]
        public Status UnitUnit { get; set; }
    }

    public partial class CustomerOrdersDeliveries
    {
        [JsonProperty("CustomerOrderDelivery")]
        public List<CustomerOrderDeliveryElement> CustomerOrderDelivery { get; set; }
    }

    public partial class CustomerOrderDeliveryElement
    {
        [JsonProperty("Number")]
        public string Number { get; set; }

        [JsonProperty("CustomerOrders")]
        public OrderLineCustomerOrder[] CustomerOrders { get; set; }

        [JsonProperty("CustomProperties")]
        public CustomProperty[] CustomProperties { get; set; }

        [JsonProperty("LastDeliveryDate")]
        public DateTimeOffset LastDeliveryDate { get; set; }

        [JsonProperty("Lines")]
        public Line[] Lines { get; set; }

        [JsonProperty("OrderReference")]
        public string OrderReference { get; set; }

        [JsonProperty("OurReference")]
        public object OurReference { get; set; }

        [JsonProperty("Status")]
        public Status Status { get; set; }

        [JsonProperty("Substatus")]
        public Status Substatus { get; set; }

        [JsonProperty("YourReference")]
        public string YourReference { get; set; }

        [JsonProperty("Id")]
        public long Id { get; set; }

        [JsonProperty("ModificationDate")]
        public DateTimeOffset ModificationDate { get; set; }

        [JsonProperty("DateAdded")]
        public DateTimeOffset DateAdded { get; set; }
    }

    public partial class ShipmentReferences
    {
        [JsonProperty("ShipmentReference")]
        public List<ShipmentReference> ShipmentReference { get; set; }
    }

    public partial class ShipmentReference
    {
        [JsonProperty("CustomerOrderDelivery")]
        public ShipmentReferenceCustomerOrderDelivery CustomerOrderDelivery { get; set; }

        [JsonProperty("DeliveryWay")]
        public Status DeliveryWay { get; set; }

        [JsonProperty("NumberOfPackages")]
        public long NumberOfPackages { get; set; }

        [JsonProperty("NumberOfTags")]
        public long NumberOfTags { get; set; }

        [JsonProperty("SequenceNumber")]
        public string SequenceNumber { get; set; }

        [JsonProperty("SequenceNumber2")]
        public string SequenceNumber2 { get; set; }

        [JsonProperty("SequenceNumberSSCC")]
        public string SequenceNumberSscc { get; set; }

        [JsonProperty("Status")]
        public Status Status { get; set; }

        [JsonProperty("Substatus")]
        public Status Substatus { get; set; }

        [JsonProperty("Id")]
        public long Id { get; set; }
    }

    public partial class ShipmentReferenceCustomerOrderDelivery
    {
        [JsonProperty("Number")]
        public string Number { get; set; }

        [JsonProperty("CustomerOrders")]
        public OrderLineCustomerOrder[] CustomerOrders { get; set; }

        [JsonProperty("OrderReference")]
        public string OrderReference { get; set; }
    }
}
