using System.Runtime.CompilerServices;

namespace SymboticQueueReader;

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public class Item
{
    public Item(List<InboundDimensionalVariant> inboundDimensionalVariants)
    {
        InboundDimensionalVariants = inboundDimensionalVariants;
    }

    [JsonProperty(propertyName: nameof(RequestId))]
    public Guid RequestId { get; set; }

    [JsonProperty(propertyName: nameof(SkuId))]
    public Guid SkuId { get; set; }

    [JsonProperty(propertyName: nameof(Sku))]
    public string? Sku { get; set; }

    [JsonProperty(propertyName: nameof(Description))]
    public string? Description { get; set; }

    [JsonProperty(propertyName: nameof(IsPressurized))]
    public bool IsPressurized { get; set; }

    [JsonProperty(propertyName: nameof(IsEligible))]
    public bool IsEligible { get; set; }

    [JsonProperty(propertyName: nameof(IsFridgePack))]
    public bool IsFridgePack { get; set; }

    [JsonProperty(propertyName: nameof(LayersPerPallet))]
    public int LayersPerPallet { get; set; }

    [JsonProperty(propertyName: nameof(CasesPerLayer))]
    public int CasesPerLayer { get; set; }

    [JsonProperty(propertyName: nameof(AllergenTypeId))]
    public string? AllergenTypeId { get; set; }

    [JsonProperty(propertyName: nameof(PackagingTypeId))]
    public int PackagingTypeId { get; set; }

    [JsonProperty(propertyName: nameof(PalletizationGroupTypeId))]
    public int PalletizationGroupTypeId { get; set; }

    [JsonProperty(propertyName: nameof(IsFragile))]
    public bool IsFragile { get; set; }

    [JsonProperty(propertyName: nameof(SegregationCode))]
    public int SegregationCode { get; set; }

    [JsonProperty(propertyName: nameof(ProductTypes))]
    public string? ProductTypes { get; set; }

    [JsonProperty(propertyName: nameof(GripForce))]
    public double GripForce { get; set; }

    [JsonProperty(propertyName: nameof(IsAutoDepal))]
    public bool IsAutoDepal { get; set; }

    [JsonProperty(propertyName: nameof(InboundDimensionalVariants))]
    public List<InboundDimensionalVariant> InboundDimensionalVariants { get; set; }

    [JsonProperty(propertyName: nameof(Extensions))]
    public Dictionary<string, string>? Extensions { get; set; }

    [JsonProperty(propertyName: nameof(IsBreakpackEligibleOverride))]
    public bool? IsBreakpackEligibleOverride { get; set; }

    [JsonProperty(propertyName: nameof(WarehousePack))]
    public WarehousePack? WarehousePack { get; set; }
}