using System.Runtime.Serialization;

namespace SymboticQueueReader;

public enum MeasuredBy
{
    [EnumMember] Unknown,
    [EnumMember] ManualOperator,
    [EnumMember] Cubiscan,
    [EnumMember] MIB
    
}