using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VAuftragKampagne
{
    public int KAuftrag { get; set; }

    public string? CKampagne { get; set; }

    public string? CKampagneName { get; set; }

    public string? CKampagneDetail { get; set; }

    public string? CReferrer { get; set; }

    public string? CUserAgent { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
