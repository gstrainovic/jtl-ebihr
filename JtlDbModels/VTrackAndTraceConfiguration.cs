using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VTrackAndTraceConfiguration
{
    public int KVersandArt { get; set; }

    public string? CName { get; set; }

    public int? NTrackAndTraceProviderType { get; set; }

    public byte? NIsEnabled { get; set; }
}
