namespace SymboticQueueReader;

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public class Item
{
    [JsonProperty("RequestId")]
    public Guid RequestId { get; set; }

    [JsonProperty("SkuId")]
    public Guid SkuId { get; set; }

    [JsonProperty("Sku")]
    public string Sku { get; set; }

    [JsonProperty("Description")]
    public string Description { get; set; }

    [JsonProperty("IsPressurized")]
    public bool IsPressurized { get; set; }

    [JsonProperty("IsEligible")]
    public bool IsEligible { get; set; }

    [JsonProperty("IsFridgePack")]
    public bool IsFridgePack { get; set; }

    [JsonProperty("LayersPerPallet")]
    public int LayersPerPallet { get; set; }

    [JsonProperty("CasesPerLayer")]
    public int CasesPerLayer { get; set; }

    [JsonProperty("AllergenTypeId")]
    public string AllergenTypeId { get; set; }

    [JsonProperty("PackagingTypeId")]
    public int PackagingTypeId { get; set; }

    [JsonProperty("PalletizationGroupTypeId")]
    public int PalletizationGroupTypeId { get; set; }

    [JsonProperty("IsFragile")]
    public bool IsFragile { get; set; }

    [JsonProperty("SegregationCode")]
    public int SegregationCode { get; set; }

    [JsonProperty("ProductTypes")]
    public string ProductTypes { get; set; }

    [JsonProperty("GripForce")]
    public double GripForce { get; set; }

    [JsonProperty("IsAutoDepal")]
    public bool IsAutoDepal { get; set; }

    [JsonProperty("InboundDimensionalVariants")]
    public List<InboundDimensionalVariant> InboundDimensionalVariants { get; set; }

    [JsonProperty("Extensions")]
    public Dictionary<string, string> Extensions { get; set; }

    [JsonProperty("IsBreakpackEligibleOverride")]
    public bool? IsBreakpackEligibleOverride { get; set; }

    [JsonProperty("WarehousePack")]
    public string WarehousePack { get; set; }
}

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
