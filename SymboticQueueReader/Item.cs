using System.Runtime.CompilerServices;

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
    public string? Sku { get; set; }

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
    public WarehousePack WarehousePack { get; set; }
}