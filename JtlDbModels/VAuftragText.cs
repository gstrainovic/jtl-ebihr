using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VAuftragText
{
    public int KAuftrag { get; set; }

    public string? CAnmerkung { get; set; }

    public string? CDrucktext { get; set; }

    public string? CHinweis { get; set; }

    public string? CVorgangsstatus { get; set; }
}
