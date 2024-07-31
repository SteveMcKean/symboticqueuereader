using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

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

[DataContract(IsReference = true)]
  public class WarehousePack 
  {
    private Sku sku;
    private List<int> warehousePackHandlingProfiles;

    /// <summary>Initializes a new instance of the <see cref="T:Symbotic.DOM.Sku.WarehousePack" /> class.</summary>
    public WarehousePack()
    {
      this.Id = Guid.NewGuid();
      this.IsManualPickOnly = false;
    }

    public Guid Id { get; set; }

    /// <summary>Gets or sets the sku identifier.</summary>
    /// <value>The sku identifier.</value>
    [DataMember]
    public Guid SkuId { get; set; }

    /// <summary>Gets or sets the length of the warehousepack.</summary>
    /// <value>The length of the warehousepack.</value>
    [DataMember]
    public int? Length { get; set; }

    /// <summary>Gets or sets the width of the warehousepack.</summary>
    /// <value>The width of the warehousepack.</value>
    [DataMember]
    public int? Width { get; set; }

    /// <summary>Gets or sets the height of the warehousepack.</summary>
    /// <value>The height of the warehousepack.</value>
    [DataMember]
    public int? Height { get; set; }

    /// <summary>Gets or sets the carton weight.</summary>
    /// <value>The carton weight.</value>
    /// <remarks>This property maps to the coresponding Dimensional Property</remarks>
    [DataMember]
    public int? Weight { get; set; }

    /// <summary>Gets or sets the parent sku.</summary>
    /// <value>The sku.</value>
    [DataMember]
    public Sku Sku
    {
      get => this.sku;
      set
      {
        this.sku = value;
        if (value == null)
          return;
        this.SkuId = value.Id;
      }
    }

    /// <summary>Gets or sets the WarehousePack Package Type.</summary>
    /// <value> WarehousePack Package Type.</value>
    [DataMember]
    public WarehousePackPackageType? WarehousePackPackageType { get; set; }

    /// <summary>A list of warehouse Pack Handling Profiles associated with this WarehousePack.</summary>
    /// <remarks>Non-Core Properties</remarks>
    /// <value>The Warehouse Pack Handling Profiles.</value>
    [DataMember]
    public List<int> WarehousePackHandlingProfiles
    {
      get
      {
        return this.warehousePackHandlingProfiles ?? (this.warehousePackHandlingProfiles = new List<int>());
      }
      set => this.warehousePackHandlingProfiles = value;
    }

    /// <summary>
    /// Get or Set IsMaualPickOnly; This value will be set through teach in
    /// </summary>
    [DataMember]
    public bool IsManualPickOnly { get; set; }

    /// <summary>
    /// Set or get RoboticPickEligibleScore; This value will be calculated by Berkshire Gray and be a number between 0-1.  Assume 3 digit decimal
    /// </summary>
    [DataMember]
    public Decimal? RoboticPickEligibleScore { get; set; }

    /// <summary>Set or get RoboticPickScoreDate;</summary>
    [DataMember]
    public DateTime? RoboticPickScoreDate { get; set; }

    /// <summary>The source name where the dimensions are measured by.</summary>
    [DataMember]
    public MeasuredBy MeasuredBy { get; set; }

    /// <summary>
    /// The name of the station where dimensions are measured.
    /// </summary>
    [DataMember]
    public string MeasurementStation { get; set; }

    /// <summary>Creates a new WarehousePack.</summary>
    /// <param name="skuId">The sku identifier.</param>
    /// <returns></returns>
    public static WarehousePack CreateNew(Guid skuId)
    {
      WarehousePack warehousePack = new WarehousePack();
      warehousePack.SkuId = skuId;
      warehousePack.InitializeTracking();
      return warehousePack;
    }

    private void InitializeTracking()
    {
      
    }

    /// <summary>Creates a new WarehousePack.</summary>
    /// <param name="sku">The sku.</param>
    /// <returns></returns>
    public static WarehousePack CreateNew(Sku sku)
    {
      WarehousePack warehousePack;
      if (sku != null)
        warehousePack = new WarehousePack()
        {
          Sku = sku,
          SkuId = sku.Id
        };
      else
        warehousePack = new WarehousePack();
      warehousePack.InitializeTracking();
      return warehousePack;
    }
  }

  public class Sku
  {
    public Guid Id { get; set; }
  }

  public enum MeasuredBy
  {
    [EnumMember] Unknown,
    [EnumMember] ManualOperator,
    [EnumMember] Cubiscan,
    [EnumMember] MIB
    
  }

  public enum WarehousePackPackageType
  {
  }

  [DataContract(IsReference = true)]
  public class WarehousePackHandlingProfile 
  {
    public int Id { get; set; }
  }

  [DataContract]
  public enum WarehousePackHandlingProfileType
  {
    /// <summary>The enum value is DelicateItem.</summary>
    [EnumMember] DelicateItem = 1,
    /// <summary>The enum value is Glass.</summary>
    [EnumMember] Glass = 2,
    /// <summary>The enum value is PumpOrPressTop.</summary>
    [EnumMember] PumpOrPressTop = 3,
    /// <summary>The enum value is CanTangle.</summary>
    [EnumMember] CanTangle = 4,
    /// <summary>The enum value is FlimsyPackaging.</summary>
    [EnumMember] FlimsyPackaging = 5,
    /// <summary>The enum value is Rollable.</summary>
    [EnumMember] Rollable = 6,
    /// <summary>The enum value is Foldable.</summary>
    [EnumMember] Foldable = 7,
    /// <summary>The enum value is LoosePlastic.</summary>
    [EnumMember] LoosePlastic = 8,
    /// <summary>The enum value is NoneApply.</summary>
    [EnumMember] NoneApply = 9,

  }
