using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvEbayKundenfeedback
{
    public int KFeedbackIn { get; set; }

    public string? DCommentTime { get; set; }

    public string? CItemId { get; set; }

    public int? NCommentingUserScore { get; set; }

    public string CCommentingUser { get; set; } = null!;

    public string? CCommentType { get; set; }

    public string? CCommentText { get; set; }

    public string? CFeedbackId { get; set; }

    public string? CFeedbackRole { get; set; }

    public string? CTransactionId { get; set; }

    public int? KArtikel { get; set; }

    public int? KEbayUser { get; set; }

    public int? KEbayItem { get; set; }

    public int? NSiteId { get; set; }

    public string? CTitle { get; set; }

    public string? CEbayUserName { get; set; }

    public string? CPlattform { get; set; }

    public string? CArtikelnummer { get; set; }
}
