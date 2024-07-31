using System.Runtime.Serialization;

namespace SymboticQueueReader;

[DataContract(IsReference = true)]
public class WarehousePackHandlingProfile 
{
    public int Id { get; set; }
}