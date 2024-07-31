using Newtonsoft.Json;

namespace SymboticQueueReader;

public class InboundRobotProperty
{
    [JsonProperty("Id")]
    public Guid Id { get; set; }

    [JsonProperty("ProfileName")]
    public string ProfileName { get; set; }

    [JsonProperty("SupportLayoutN")]
    public int SupportLayoutN { get; set; }

    [JsonProperty("SupportLayoutM")]
    public int SupportLayoutM { get; set; }

    [JsonProperty("ReducedSupport")]
    public int ReducedSupport { get; set; }

    [JsonProperty("LayerHeight")]
    public int LayerHeight { get; set; }

    [JsonProperty("DelayerPlatePressure")]
    public int DelayerPlatePressure { get; set; }

    [JsonProperty("DelayerClosePlatesDelay")]
    public int DelayerClosePlatesDelay { get; set; }

    [JsonProperty("DelayerRobotAcceleration")]
    public int DelayerRobotAcceleration { get; set; }

    [JsonProperty("TopStrength")]
    public int TopStrength { get; set; }

    [JsonProperty("SingulatorRobotAcceleration")]
    public int SingulatorRobotAcceleration { get; set; }

    [JsonProperty("DelayerPickNumber")]
    public int DelayerPickNumber { get; set; }

    [JsonProperty("VisionPickMode")]
    public string VisionPickMode { get; set; }

    [JsonProperty("SingulatorPickStrengthLongSide")]
    public int SingulatorPickStrengthLongSide { get; set; }

    [JsonProperty("SingulatorPickStrengthShortSide")]
    public int SingulatorPickStrengthShortSide { get; set; }
}