using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TServerConfig
{
    public string CIpAddress { get; set; } = null!;

    public int NPort { get; set; }

    public string CCertificateFingerprint { get; set; } = null!;

    public string CCertificateSerialNumber { get; set; } = null!;
}
