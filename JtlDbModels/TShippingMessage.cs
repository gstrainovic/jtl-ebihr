using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TShippingMessage
{
    public int KShippingMessage { get; set; }

    public int KVersand { get; set; }

    public DateTime DZeitstempel { get; set; }

    public string? CMessageContent { get; set; }

    public string? CCode { get; set; }

    public byte? NMessageType { get; set; }

    public string? CMessageShort { get; set; }

    public byte? NMessageSource { get; set; }

    public string? CRequestId { get; set; }

    public byte? NIsTranslated { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
