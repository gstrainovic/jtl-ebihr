using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class EbayDataMembermessageOut
{
    public int KMemberMessageOut { get; set; }

    public string? ItemId { get; set; }

    public byte? EmailCopyToSender { get; set; }

    public string? Body { get; set; }

    public byte? DisplayToPublic { get; set; }

    public string? MessageId { get; set; }

    public string? MessageType { get; set; }

    public string? QuestionType { get; set; }

    public string? ParentMessageId { get; set; }

    public string? RecipientId { get; set; }

    public string? Subject { get; set; }

    public string CStatus { get; set; } = null!;

    public string? Sent { get; set; }

    public int? KEbayuser { get; set; }

    public virtual EbayUser? KEbayuserNavigation { get; set; }
}
