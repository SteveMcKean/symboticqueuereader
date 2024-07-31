using System.Runtime.CompilerServices;

namespace SymboticQueueReader;

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public class Item
{
    [JsonProperty(propertyName: nameof(RequestId))]
    public Guid RequestId { get; set; }

    [JsonProperty(propertyName: nameof(SkuId))]
    public Guid SkuId { get; set; }

    [JsonProperty(propertyName: "Sku")]
    public string? Sku { get; set; }

    [JsonProperty(propertyName: nameof(Description))]
    public string Description { get; set; }

    [JsonProperty(propertyName: nameof(IsPressurized))]
    public bool IsPressurized { get; set; }

    [JsonProperty(propertyName: nameof(IsEligible))]
    public bool IsEligible { get; set; }

    [JsonProperty(propertyName: "IsFridgePack")]
    public bool IsFridgePack { get; set; }

    [JsonProperty(propertyName: "LayersPerPallet")]
    public int LayersPerPallet { get; set; }

    [JsonProperty(propertyName: "CasesPerLayer")]
    public int CasesPerLayer { get; set; }

    [JsonProperty(propertyName: "AllergenTypeId")]
    public string AllergenTypeId { get; set; }

    [JsonProperty(propertyName: "PackagingTypeId")]
    public int PackagingTypeId { get; set; }

    [JsonProperty(propertyName: "PalletizationGroupTypeId")]
    public int PalletizationGroupTypeId { get; set; }

    [JsonProperty(propertyName: "IsFragile")]
    public bool IsFragile { get; set; }

    [JsonProperty(propertyName: "SegregationCode")]
    public int SegregationCode { get; set; }

    [JsonProperty(propertyName: "ProductTypes")]
    public string ProductTypes { get; set; }

    [JsonProperty(propertyName: "GripForce")]
    public double GripForce { get; set; }

    [JsonProperty(propertyName: "IsAutoDepal")]
    public bool IsAutoDepal { get; set; }

    [JsonProperty(propertyName: "InboundDimensionalVariants")]
    public List<InboundDimensionalVariant> InboundDimensionalVariants { get; set; }

    [JsonProperty(propertyName: "Extensions")]
    public Dictionary<string, string> Extensions { get; set; }

    [JsonProperty(propertyName: "IsBreakpackEligibleOverride")]
    public bool? IsBreakpackEligibleOverride { get; set; }

    [JsonProperty(propertyName: "WarehousePack")]
    public WarehousePack WarehousePack { get; set; }
}