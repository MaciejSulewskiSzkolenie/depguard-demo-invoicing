using Newtonsoft.Json;

namespace Demo;

public sealed record Invoice(string Number, decimal Total);

public class InvoiceSerializer
{
    public string Serialize(Invoice invoice) => JsonConvert.SerializeObject(invoice);

    public Invoice? Deserialize(string json) => JsonConvert.DeserializeObject<Invoice>(json);
}
