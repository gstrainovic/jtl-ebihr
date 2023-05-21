using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayDataFeedbackOut
{
    public int KFeedbackOut { get; set; }

    public string? ItemId { get; set; }

    public string? TargetUser { get; set; }

    public string? CommentText { get; set; }

    public string? CommentType { get; set; }

    public string? TransactionId { get; set; }

    public string? FeedbackId { get; set; }

    public string? Sent { get; set; }
}
