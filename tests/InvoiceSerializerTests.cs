using Demo;
using Xunit;

public class InvoiceSerializerTests
{
    [Fact]
    public void Serialize_ContainsNumber()
    {
        var json = new InvoiceSerializer().Serialize(new Invoice("INV-1", 10m));
        Assert.Contains("INV-1", json);
    }

    [Fact]
    public void RoundTrip_PreservesTotal()
    {
        var s = new InvoiceSerializer();
        var back = s.Deserialize(s.Serialize(new Invoice("INV-2", 42.5m)));
        Assert.Equal(42.5m, back!.Total);
    }
}
