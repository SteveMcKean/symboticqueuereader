using System.Runtime.Serialization;

namespace SymboticQueueReader;

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