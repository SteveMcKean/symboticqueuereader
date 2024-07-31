using Newtonsoft.Json;

namespace SymboticQueueReader;

public class InboundDimensionalVariant
{
    [JsonProperty("Id")]
    public Guid Id { get; set; }

    [JsonProperty("SkuId")]
    public Guid SkuId { get; set; }

    [JsonProperty("CartonLength")]
    public int CartonLength { get; set; }

    [JsonProperty("CartonWidth")]
    public int CartonWidth { get; set; }

    [JsonProperty("CartonHeight")]
    public int CartonHeight { get; set; }

    [JsonProperty("CartonWeight")]
    public int CartonWeight { get; set; }

    [JsonProperty("TaughtDate")]
    public DateTime TaughtDate { get; set; }

    [JsonProperty("StoredOrientation")]
    public string StoredOrientation { get; set; }

    [JsonProperty("MaxCartonsPerPickFaceLongEdge")]
    public int? MaxCartonsPerPickFaceLongEdge { get; set; }

    [JsonProperty("MaxCartonsPerPickFaceShortEdge")]
    public int? MaxCartonsPerPickFaceShortEdge { get; set; }

    [JsonProperty("IsReceived")]
    public bool IsReceived { get; set; }

    [JsonProperty("IsStorageEligible")]
    public bool IsStorageEligible { get; set; }

    [JsonProperty("ParentInboundDimensionalVariantId")]
    public Guid? ParentInboundDimensionalVariantId { get; set; }

    [JsonProperty("InboundRobotProperty")]
    public InboundRobotProperty InboundRobotProperty { get; set; }

    [JsonProperty("MeasurementStation")]
    public string MeasurementStation { get; set; }

    [JsonProperty("MeasuredBy")]
    public string MeasuredBy { get; set; }
}