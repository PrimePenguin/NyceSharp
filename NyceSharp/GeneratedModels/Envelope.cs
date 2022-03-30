namespace NyceSharp
{
    public partial class Envelope
    {
        public string MessageId { get; set; }
        public string MessageType { get; set; }
        public string Version { get; set; }
        public string Sender { get; set; }
        public System.DateTime? Created { get; set; }
        public string Client { get; set; }
        public string Warehouse { get; set; }
    }
}
