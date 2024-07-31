using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Converters;

namespace SymboticQueueReader;

[DataContract(Namespace = "Symbotic.ItemMaster.Event", Name = "SkuTeachInCompleted")]
public class SkuTeachInCompleted
{
    [JsonConstructor]
    public SkuTeachInCompleted(Guid requestId, string? sku, SkuTeachInCompletedResultEnum result, string? message)
    {
        RequestId = requestId;
        Sku = sku;
        Result = result;
        Message = message;
    }

    public SkuTeachInCompleted() { }

    [DataMember]
    public Guid RequestId { get; set; }

    [DataMember]
    public string? Sku { get; set; }

    [DataMember]
    public SkuTeachInCompletedResultEnum Result { get; set; }

    [DataMember]
    public string? Message { get; set; }
}

[JsonConverter(typeof(StringEnumConverter))]
public enum SkuTeachInCompletedResultEnum
{
    /// <summary>
    /// The Sku validation succeeded.
    /// </summary>
    [EnumMember]
    [Display(ResourceType = typeof(Strings), Name = "SkuTeachInCompleted_TeachInResult_Success")]
    Success,

    /// <summary>
    /// The Sku failed teach in because the Sku is unknown.
    /// </summary>
    [EnumMember]
    [Display(ResourceType = typeof(Strings), Name = "SkuTeachInCompleted_TeachInResult_FailedSkuUnknown")]
    FailedSkuUnknown,

    /// <summary>
    /// The Sku failed teach in because the parameters are invalid.
    /// </summary>
    [EnumMember]
    [Display(ResourceType = typeof(Strings), Name = "SkuTeachInCompleted_TeachInResult_FailedParametersInvalid")]
    FailedParametersInvalid,

    /// <summary>
    /// The Sku failed teach in because the parameters are null
    /// </summary>
    [EnumMember]
    [Display(ResourceType = typeof(Strings), Name = "SkuTeachInCompleted_TeachInResult_FailedParametersNull")]
    FailedParametersNull,

    /// <summary> 
    /// The sku failed validation.
    /// </summary>
    [EnumMember]
    [Display(ResourceType = typeof(Strings), Name = "SkuTeachInCompleted_TeachInResult_FailedValidation")]
    FailedValidation,

    /// <summary>
    /// The Sku failed teach in because of some other reason.
    /// </summary>
    [EnumMember]
    [Display(ResourceType = typeof(Strings), Name = "SkuTeachInCompleted_TeachInResult_FailedOther")]
    FailedOther
}