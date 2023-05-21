using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayDataMembermessageIn
{
    public int KMemberMessageIn { get; set; }

    public string? ItemId { get; set; }

    public string? CreationDate { get; set; }

    public string? QuestionBody { get; set; }

    public byte? QuestionDisplayToPublic { get; set; }

    public string? QuestionMessageId { get; set; }

    public string? QuestionMessageType { get; set; }

    public string? QuestionQuestionType { get; set; }

    public string? QuestionRecipientId { get; set; }

    public string? QuestionSenderId { get; set; }

    public string? QuestionSubject { get; set; }

    public byte? Status { get; set; }

    public int? KEbayuser { get; set; }

    public virtual EbayUser? KEbayuserNavigation { get; set; }
}
