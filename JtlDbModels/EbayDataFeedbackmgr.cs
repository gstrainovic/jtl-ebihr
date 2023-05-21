using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayDataFeedbackmgr
{
    public int KFeedbackmgr { get; set; }

    public int? KEbayUser { get; set; }

    public byte? NOption { get; set; }

    public byte? NErinnerung { get; set; }

    public string? CMailText { get; set; }

    public byte? NHtml { get; set; }
}
