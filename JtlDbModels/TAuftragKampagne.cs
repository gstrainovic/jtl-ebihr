﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAuftragKampagne
{
    public int KAuftrag { get; set; }

    public string? CKampagne { get; set; }

    public string? CKampagneName { get; set; }

    public string? CKampagneDetail { get; set; }

    public string? CReferrer { get; set; }

    public string? CUserAgent { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TAuftrag KAuftragNavigation { get; set; } = null!;
}
