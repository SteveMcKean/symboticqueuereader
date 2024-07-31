using System.Runtime.Serialization;

namespace SymboticQueueReader;

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